using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PJRCoreDataUtilities;
using UniversalDataLoader.Models;
using PJRLoggingUtility;

namespace UniversalDataLoader
{
    public partial class Form1 : Form
    {
        public delegate void ActivityLogDelegate(string message);

        public Form1()
        {
            InitializeComponent();
            VoidLoadDefaults();
            this.Text = Util.GetApplicationName();

        }

        private readonly string tablelistquery = Properties.Settings.Default.DatabaseTableListQuery;
        private string sourceFile;
        readonly int maxstring = Properties.Settings.Default.MaxFileHolder;
        private string[] files = null;

        public void LogActivityDelegateMethod(string message)
        {


            if (this.logDataGridView.InvokeRequired)
            {
                ActivityLogDelegate d = new ActivityLogDelegate(LogActivityDelegateMethod);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                this.logDataGridView.Rows.Insert(0, DateTime.Now, "Info", "Main", message, "");
                logDataGridView.Refresh();
            }

        }

        public void VoidLoadDefaults()
        {
            rdoCsv.Checked = true;
            rdoCsv.Refresh();
            rdoUseSourceTables.Checked = true;
            rdoMultipleFiles.Checked = true;

            //Load Database Connection

            string connectionsfile = Properties.Settings.Default.ConnectionFile;
            IList<ConnectionString> connectionStringList = null;

            connectionStringList = new List<ConnectionString>();
            foreach (string line in File.ReadLines(connectionsfile))
            {
                string[] connections = line.Split('|');
                ConnectionString connectionString = new ConnectionString();
                connectionString.Name = connections[0];
                connectionString.Value = connections[1];

                connectionStringList.Add(connectionString);

            }

            cboDbServerConnections.DataSource = connectionStringList;
            cboDbServerConnections.DisplayMember = "Name";
            cboDbServerConnections.ValueMember = "Value";
            cboDbServerConnections.Refresh();


            //TableList
            connectionStringList = new List<ConnectionString>();
            DbConnectionOptions dbconnectionOption = new DbConnectionOptions();

            dbconnectionOption.DbConnectionString = cboDbServerConnections.SelectedValue.ToString();
            dbconnectionOption.DbConnectionType = DatabaseConnectionType.MsSql;

            DataRequest dataRequest = new DataRequest();
            DataSet ds = dataRequest.GetDataset(dbconnectionOption, tablelistquery);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    ConnectionString connectionString = new ConnectionString();
                    connectionString.Name = r["name"].ToString();
                    connectionString.Value = r["name"].ToString();
                    connectionStringList.Add(connectionString);
                }
            }

            cboTables.DataSource = connectionStringList;
            cboTables.DisplayMember = "Name";
            cboTables.ValueMember = "Value";
            cboTables.Refresh();


            //Log Window
            //Update Date GridView
            Type t = typeof(Log);
            PropertyInfo[] pia = t.GetProperties();
            foreach (PropertyInfo pi in pia)
            {
                if ((pi.PropertyType.IsGenericType))
                {
                    Type typeOfColumn = pi.PropertyType.GetGenericArguments()[0];
                    logDataGridView.Columns.Add(pi.Name, pi.Name);
                }
                else
                    logDataGridView.Columns.Add(pi.Name, pi.Name);
            }





        }

        private void cboDbServerConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            files = new string[maxstring];

            if (rdoMultipleFiles.Checked)
            {
                if (string.IsNullOrEmpty(lblMultipleFilePath.Text.Trim()) || lblMultipleFilePath.Text.Trim() == "-")
                {
                    MessageBox.Show("When the Multiple File option is selected,  a source directory must be provided.");
                    return;
                }

                string pattern = "*.{0}";
                if (rdoCsv.Checked)
                {
                    pattern = string.Format(pattern, "csv");
                }
                else if (rdoXls.Checked)
                {
                    pattern = string.Format(pattern, "xls");
                }
                else if (rdoXlsx.Checked)
                {
                    pattern = string.Format(pattern, "xlsx");
                }
                else if (rdoXml.Checked)
                {
                    pattern = string.Format(pattern, "xml");
                }
                else
                {
                    pattern = string.Format(pattern, txtDelimiter.Text);
                }

                // filehandler = string.Format(pattern, pattern);
                files = Directory.GetFiles(lblMultipleFilePath.Text, pattern);
                //files = Directory.GetFiles(Properties.Settings.Default.FilePath, pattern);
            }
            else
            {
                sourceFile = lblSingleFileName.Text;
                files[0] = sourceFile;
            }

            progressBar1.Maximum = files.Length;
            progressBar1.Minimum = 0;


            ActivityLogDelegate activityLogDelegate = new ActivityLogDelegate(LogActivityDelegateMethod);

            tabControl1.SelectedTab = tabPage2;


            ProcessFiles(activityLogDelegate);
        }

        private void ProcessFiles(ActivityLogDelegate activityLogDelegate)
        {
            if (activityLogDelegate != null)
            {

                activityLogDelegate("Processing Started");
                activityLogDelegate(string.Format("{0} file(s) Found.", files.Length));
            }


            string filepath = null;
            string destinationTableName = "";
            string sqlcon = cboDbServerConnections.SelectedValue.ToString();

            #region Get Destination Table

            if (rdoUseSourceTables.Checked)
            {
                destinationTableName = null;
            }

            else if (rdoUseTableInDestinationDatabase.Checked)
            {
                destinationTableName = cboTables.SelectedValue.ToString();
            }

            if (!string.IsNullOrEmpty(destinationTableName))
            {
                if (!destinationTableName.Contains("["))
                {
                    destinationTableName = "[" + destinationTableName;
                }

                if (!destinationTableName.Contains("]"))
                {
                    destinationTableName = destinationTableName + "]";
                }
            }

            #endregion 


            foreach (string fullfilename in files)
            {
                if (fullfilename == null)
                    continue;

                activityLogDelegate(string.Format("File: {0}", fullfilename));
                string shortfilename = Path.GetFileName(fullfilename);

                DataOperation dataOperation = new DataOperation();
                DataRequest dataRequest = new DataRequest();
                SubmitData submitData = new SubmitData();

                string connectionstring = null;
                DataSet ds = new DataSet();


                filepath = Path.GetDirectoryName(fullfilename);


                try
                {
                    if (rdoCsv.Checked)
                    {

                        connectionstring =
                            string.Format(Properties.Settings.Default.OleFlatFileConnectionTemplate.ToString(), filepath,
                                ',');
                        ds = dataOperation.OleDbExcelSheetsToDataSet(connectionstring, shortfilename);

                    }
                    else if (rdoXls.Checked)
                    {
                        connectionstring =
                            string.Format(Properties.Settings.Default.OleExcelConnectionTemplate.ToString(),
                                fullfilename);
                        ds = dataOperation.OleDbExcelSheetsToDataSet(connectionstring);
                    }
                    else if (rdoXlsx.Checked)
                    {
                        connectionstring =
                            string.Format(Properties.Settings.Default.OleExcelXmlFileConnectionTemplate.ToString(),
                                fullfilename);
                        ds = dataOperation.OleDbExcelSheetsToDataSet(connectionstring);
                    }
                    else if (rdoXml.Checked)
                    {
                        connectionstring =
                            string.Format(Properties.Settings.Default.OleExcelConnectionTemplate.ToString(),
                                fullfilename);
                        ds = dataOperation.OleDbExcelSheetsToDataSet(connectionstring);
                    }
                    else if (rdoOther.Checked)
                    {
                        if (string.IsNullOrEmpty(txtDelimiter.Text.Trim()))
                        {
                            MessageBox.Show("When the Other option is selected, A  delimited must be provided");
                            return;
                        }

                        connectionstring =
                            string.Format(Properties.Settings.Default.OleFlatFileConnectionTemplate.ToString(), filepath,
                                txtDelimiter.Text.Trim());
                        ds = dataOperation.OleDbExcelSheetsToDataSet(connectionstring, shortfilename);



                    }
                }
                catch (Exception exp)
                {
                    activityLogDelegate(string.Format("Error Reading from: {0} Details {1}", shortfilename, exp.Message));

                }


                if (ds != null)
                {
                    activityLogDelegate(
                        string.Format(string.Format("File: {0} contains {1} Sheets", fullfilename, ds.Tables.Count)));

                    //Insert Data
                    foreach (DataTable dt in ds.Tables)
                    {
                        if (dt.Rows.Count < 1)
                            continue;

                        if (destinationTableName != null)
                        {
                            dt.TableName = destinationTableName;
                        }


                        // string droptable = Properties.Settings.Default.DropExistingTable.Replace("@TableName", dt.TableName);

                        string createstatement = dataOperation.DataTableToMsSqlCreateStatement(dt);


                        bool status = submitData.MsSqlExecuteNonQuery(sqlcon, createstatement);

                        string insertstatement = dataOperation.DataTableToMssqlInsertStatement(dt);
                        try
                        {
                            //Data Cleaning
                            StringReplacementParameter stringReplacementParameter = new StringReplacementParameter();
                            List<StringReplacementParameter> stringReplacementParameterList =
                                new List<StringReplacementParameter>();
                            stringReplacementParameter.oldstring = "\r\n";
                            stringReplacementParameter.newstring = "";
                            stringReplacementParameterList.Add(stringReplacementParameter);
                            stringReplacementParameter.oldstring = "\r";
                            stringReplacementParameter.newstring = "";
                            stringReplacementParameterList.Add(stringReplacementParameter);
                            stringReplacementParameter.oldstring = "\n";
                            stringReplacementParameter.newstring = "";
                            stringReplacementParameterList.Add(stringReplacementParameter);

                            DataCleanOptions dataCleanOptions = new DataCleanOptions();
                            dataCleanOptions.StringReplacementParameterList = stringReplacementParameterList;
                            DataTable cleandata = dataOperation.CleanDataTable(dt, dataCleanOptions);

                            int recordcount = cleandata.Rows.Count;
                            double batchprocessingsize = (double)(recordcount) *
                                                         ((double)Convert.ToInt16(txtBatchPercentage.Text) / 100);
                            batchprocessingsize = (double)recordcount / batchprocessingsize;

                            if (dataOperation.DataTableBulkInsertMsSqlTable(sqlcon, cleandata, (int)batchprocessingsize))
                            {


                                activityLogDelegate(string.Format(
                                    "{0} record(s) retreived from Sheet: {1}  of file: {2} and inserted into database table: {3}",
                                    dt.Rows.Count, dt.TableName, fullfilename, dt.TableName));
                            }
                            else
                            {
                                activityLogDelegate("Insert Failed");

                            }
                        }
                        catch (Exception exp)
                        {
                            activityLogDelegate("Insert Failed" + exp.StackTrace);

                        }
                    }
                }
                else
                {
                    activityLogDelegate(string.Format("File: {0} contains {1} Sheet(s)", fullfilename, "0"));

                }
            }
            activityLogDelegate("Processed Completed");
            MessageBox.Show("Processed Completed");
        }




        private void btnSingleFile_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                lblSingleFileName.Text = openFileDialog1.FileName;

            }
        }

        private void btnMultipleFiles_Click_1(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            lblMultipleFilePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void rdoSingleFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSingleFiles.Checked)
            {
                btnSingleFile.Enabled = true;
            }
            else
            {
                btnSingleFile.Enabled = false;
            }

        }

        private void rdoMultipleFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMultipleFiles.Checked)
            {
                btnMultipleFiles.Enabled = true;
            }
            else
            {
                btnMultipleFiles.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cboDbServerConnections_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string connectionString = cboDbServerConnections.ValueMember.ToString();
            if (!connectionString.Contains("=") || string.IsNullOrEmpty(connectionString))
            {
                connectionString = cboDbServerConnections.SelectedValue.ToString();

            }
            if (!connectionString.Contains("=") || string.IsNullOrEmpty(connectionString))
            {
                return;

            }

            //TableList
            List<ConnectionString> connectionStringList = null;
            connectionStringList = new List<ConnectionString>();
            DbConnectionOptions dbconnectionOption = new DbConnectionOptions();

            dbconnectionOption.DbConnectionString = connectionString;
            dbconnectionOption.DbConnectionType = DatabaseConnectionType.MsSql;

            DataRequest dataRequest = new DataRequest();
            DataSet ds = dataRequest.GetDataset(dbconnectionOption, tablelistquery);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    ConnectionString connectionStringClass = new ConnectionString();
                    connectionStringClass.Name = r["name"].ToString();
                    connectionStringClass.Value = r["name"].ToString();
                    connectionStringList.Add(connectionStringClass);
                }
            }

            cboTables.DataSource = connectionStringList;
            cboTables.DisplayMember = "Name";
            cboTables.ValueMember = "Value";
            cboTables.Refresh();
        

    }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {  
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            DialogResult result = saveFileDialog.ShowDialog(); // Sh
            string filename = null;

           
            if (result == DialogResult.OK) // Test result.
            {
                filename = openFileDialog1.FileName;

            }
            HelperMethods.SaveDataGridToFile(filename, logDataGridView);


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logDataGridView.Rows.Clear();
        }
    }
}
