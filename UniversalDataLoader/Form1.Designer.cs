namespace UniversalDataLoader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBatchPercentage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoUseTableInDestinationDatabase = new System.Windows.Forms.RadioButton();
            this.rdoUseSourceTables = new System.Windows.Forms.RadioButton();
            this.cboTables = new System.Windows.Forms.ComboBox();
            this.cboDbServerConnections = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkFileRowIsHeader = new System.Windows.Forms.CheckBox();
            this.btnMultipleFiles = new System.Windows.Forms.Button();
            this.btnSingleFile = new System.Windows.Forms.Button();
            this.lblMultipleFilePath = new System.Windows.Forms.Label();
            this.lblSingleFileName = new System.Windows.Forms.Label();
            this.rdoMultipleFiles = new System.Windows.Forms.RadioButton();
            this.rdoSingleFiles = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoXml = new System.Windows.Forms.RadioButton();
            this.rdoXlsx = new System.Windows.Forms.RadioButton();
            this.rdoXls = new System.Windows.Forms.RadioButton();
            this.rdoCsv = new System.Windows.Forms.RadioButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.logDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchPercentage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.btnLoadData);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Loader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 298);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(834, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(418, 176);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 7;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBatchPercentage);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdoUseTableInDestinationDatabase);
            this.groupBox2.Controls.Add(this.rdoUseSourceTables);
            this.groupBox2.Controls.Add(this.cboTables);
            this.groupBox2.Controls.Add(this.cboDbServerConnections);
            this.groupBox2.Location = new System.Drawing.Point(468, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Destination Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Percentage per Batch Process";
            // 
            // txtBatchPercentage
            // 
            this.txtBatchPercentage.Location = new System.Drawing.Point(189, 116);
            this.txtBatchPercentage.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtBatchPercentage.Name = "txtBatchPercentage";
            this.txtBatchPercentage.Size = new System.Drawing.Size(68, 20);
            this.txtBatchPercentage.TabIndex = 7;
            this.txtBatchPercentage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Connection";
            // 
            // rdoUseTableInDestinationDatabase
            // 
            this.rdoUseTableInDestinationDatabase.AutoSize = true;
            this.rdoUseTableInDestinationDatabase.Location = new System.Drawing.Point(34, 93);
            this.rdoUseTableInDestinationDatabase.Name = "rdoUseTableInDestinationDatabase";
            this.rdoUseTableInDestinationDatabase.Size = new System.Drawing.Size(141, 17);
            this.rdoUseTableInDestinationDatabase.TabIndex = 5;
            this.rdoUseTableInDestinationDatabase.TabStop = true;
            this.rdoUseTableInDestinationDatabase.Text = "Select Destination Table";
            this.rdoUseTableInDestinationDatabase.UseVisualStyleBackColor = true;
            // 
            // rdoUseSourceTables
            // 
            this.rdoUseSourceTables.AutoSize = true;
            this.rdoUseSourceTables.Location = new System.Drawing.Point(34, 59);
            this.rdoUseSourceTables.Name = "rdoUseSourceTables";
            this.rdoUseSourceTables.Size = new System.Drawing.Size(212, 17);
            this.rdoUseSourceTables.TabIndex = 5;
            this.rdoUseSourceTables.TabStop = true;
            this.rdoUseSourceTables.Text = "Use Source Table as Destination Name";
            this.rdoUseSourceTables.UseVisualStyleBackColor = true;
            // 
            // cboTables
            // 
            this.cboTables.FormattingEnabled = true;
            this.cboTables.Location = new System.Drawing.Point(180, 89);
            this.cboTables.Name = "cboTables";
            this.cboTables.Size = new System.Drawing.Size(198, 21);
            this.cboTables.TabIndex = 0;
            // 
            // cboDbServerConnections
            // 
            this.cboDbServerConnections.FormattingEnabled = true;
            this.cboDbServerConnections.Location = new System.Drawing.Point(147, 19);
            this.cboDbServerConnections.Name = "cboDbServerConnections";
            this.cboDbServerConnections.Size = new System.Drawing.Size(224, 21);
            this.cboDbServerConnections.TabIndex = 0;
            this.cboDbServerConnections.SelectedIndexChanged += new System.EventHandler(this.cboDbServerConnections_SelectedIndexChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDelimiter);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rdoOther);
            this.groupBox1.Controls.Add(this.rdoXml);
            this.groupBox1.Controls.Add(this.rdoXlsx);
            this.groupBox1.Controls.Add(this.rdoXls);
            this.groupBox1.Controls.Add(this.rdoCsv);
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delimiter";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(163, 112);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(85, 20);
            this.txtDelimiter.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFileRowIsHeader);
            this.groupBox3.Controls.Add(this.btnMultipleFiles);
            this.groupBox3.Controls.Add(this.btnSingleFile);
            this.groupBox3.Controls.Add(this.lblMultipleFilePath);
            this.groupBox3.Controls.Add(this.lblSingleFileName);
            this.groupBox3.Controls.Add(this.rdoMultipleFiles);
            this.groupBox3.Controls.Add(this.rdoSingleFiles);
            this.groupBox3.Location = new System.Drawing.Point(106, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 94);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Options";
            // 
            // chkFileRowIsHeader
            // 
            this.chkFileRowIsHeader.AutoSize = true;
            this.chkFileRowIsHeader.Location = new System.Drawing.Point(136, 75);
            this.chkFileRowIsHeader.Name = "chkFileRowIsHeader";
            this.chkFileRowIsHeader.Size = new System.Drawing.Size(133, 17);
            this.chkFileRowIsHeader.TabIndex = 6;
            this.chkFileRowIsHeader.Text = "First Row Header Row";
            this.chkFileRowIsHeader.UseVisualStyleBackColor = true;
            // 
            // btnMultipleFiles
            // 
            this.btnMultipleFiles.Enabled = false;
            this.btnMultipleFiles.Location = new System.Drawing.Point(97, 42);
            this.btnMultipleFiles.Name = "btnMultipleFiles";
            this.btnMultipleFiles.Size = new System.Drawing.Size(33, 23);
            this.btnMultipleFiles.TabIndex = 5;
            this.btnMultipleFiles.Text = "...";
            this.btnMultipleFiles.UseVisualStyleBackColor = true;
            this.btnMultipleFiles.Click += new System.EventHandler(this.btnMultipleFiles_Click_1);
            // 
            // btnSingleFile
            // 
            this.btnSingleFile.Location = new System.Drawing.Point(97, 18);
            this.btnSingleFile.Name = "btnSingleFile";
            this.btnSingleFile.Size = new System.Drawing.Size(33, 23);
            this.btnSingleFile.TabIndex = 5;
            this.btnSingleFile.Text = "...";
            this.btnSingleFile.UseVisualStyleBackColor = true;
            this.btnSingleFile.Click += new System.EventHandler(this.btnSingleFile_Click_1);
            // 
            // lblMultipleFilePath
            // 
            this.lblMultipleFilePath.AutoSize = true;
            this.lblMultipleFilePath.Location = new System.Drawing.Point(136, 49);
            this.lblMultipleFilePath.Name = "lblMultipleFilePath";
            this.lblMultipleFilePath.Size = new System.Drawing.Size(10, 13);
            this.lblMultipleFilePath.TabIndex = 4;
            this.lblMultipleFilePath.Text = "-";
            // 
            // lblSingleFileName
            // 
            this.lblSingleFileName.AutoSize = true;
            this.lblSingleFileName.Location = new System.Drawing.Point(136, 23);
            this.lblSingleFileName.Name = "lblSingleFileName";
            this.lblSingleFileName.Size = new System.Drawing.Size(10, 13);
            this.lblSingleFileName.TabIndex = 4;
            this.lblSingleFileName.Text = "-";
            // 
            // rdoMultipleFiles
            // 
            this.rdoMultipleFiles.AutoSize = true;
            this.rdoMultipleFiles.Location = new System.Drawing.Point(6, 45);
            this.rdoMultipleFiles.Name = "rdoMultipleFiles";
            this.rdoMultipleFiles.Size = new System.Drawing.Size(85, 17);
            this.rdoMultipleFiles.TabIndex = 3;
            this.rdoMultipleFiles.Text = "Multiple Files";
            this.rdoMultipleFiles.UseVisualStyleBackColor = true;
            this.rdoMultipleFiles.CheckedChanged += new System.EventHandler(this.rdoMultipleFiles_CheckedChanged);
            // 
            // rdoSingleFiles
            // 
            this.rdoSingleFiles.AutoSize = true;
            this.rdoSingleFiles.Checked = true;
            this.rdoSingleFiles.Location = new System.Drawing.Point(6, 19);
            this.rdoSingleFiles.Name = "rdoSingleFiles";
            this.rdoSingleFiles.Size = new System.Drawing.Size(73, 17);
            this.rdoSingleFiles.TabIndex = 3;
            this.rdoSingleFiles.TabStop = true;
            this.rdoSingleFiles.Text = "Single File";
            this.rdoSingleFiles.UseVisualStyleBackColor = true;
            this.rdoSingleFiles.CheckedChanged += new System.EventHandler(this.rdoSingleFiles_CheckedChanged);
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(16, 107);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(51, 17);
            this.rdoOther.TabIndex = 3;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoXml
            // 
            this.rdoXml.AutoSize = true;
            this.rdoXml.Location = new System.Drawing.Point(16, 84);
            this.rdoXml.Name = "rdoXml";
            this.rdoXml.Size = new System.Drawing.Size(47, 17);
            this.rdoXml.TabIndex = 3;
            this.rdoXml.TabStop = true;
            this.rdoXml.Text = "XML";
            this.rdoXml.UseVisualStyleBackColor = true;
            // 
            // rdoXlsx
            // 
            this.rdoXlsx.AutoSize = true;
            this.rdoXlsx.Location = new System.Drawing.Point(16, 63);
            this.rdoXlsx.Name = "rdoXlsx";
            this.rdoXlsx.Size = new System.Drawing.Size(52, 17);
            this.rdoXlsx.TabIndex = 3;
            this.rdoXlsx.TabStop = true;
            this.rdoXlsx.Text = "XLSX";
            this.rdoXlsx.UseVisualStyleBackColor = true;
            // 
            // rdoXls
            // 
            this.rdoXls.AutoSize = true;
            this.rdoXls.Location = new System.Drawing.Point(16, 40);
            this.rdoXls.Name = "rdoXls";
            this.rdoXls.Size = new System.Drawing.Size(45, 17);
            this.rdoXls.TabIndex = 3;
            this.rdoXls.TabStop = true;
            this.rdoXls.Text = "XLS";
            this.rdoXls.UseVisualStyleBackColor = true;
            // 
            // rdoCsv
            // 
            this.rdoCsv.AutoSize = true;
            this.rdoCsv.Location = new System.Drawing.Point(16, 20);
            this.rdoCsv.Name = "rdoCsv";
            this.rdoCsv.Size = new System.Drawing.Size(46, 17);
            this.rdoCsv.TabIndex = 3;
            this.rdoCsv.TabStop = true;
            this.rdoCsv.Text = "CSV";
            this.rdoCsv.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(18, 205);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(835, 86);
            this.txtLog.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.logDataGridView);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // logDataGridView
            // 
            this.logDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logDataGridView.Location = new System.Drawing.Point(3, 30);
            this.logDataGridView.Name = "logDataGridView";
            this.logDataGridView.Size = new System.Drawing.Size(861, 300);
            this.logDataGridView.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.newToolStripMenuItem.Text = "Clear Log";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exportToolStripMenuItem.Text = "Export Log";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 365);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Universal Data Loader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBatchPercentage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtBatchPercentage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoUseTableInDestinationDatabase;
        private System.Windows.Forms.RadioButton rdoUseSourceTables;
        private System.Windows.Forms.ComboBox cboTables;
        private System.Windows.Forms.ComboBox cboDbServerConnections;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFileRowIsHeader;
        private System.Windows.Forms.Button btnMultipleFiles;
        private System.Windows.Forms.Button btnSingleFile;
        private System.Windows.Forms.Label lblMultipleFilePath;
        private System.Windows.Forms.Label lblSingleFileName;
        private System.Windows.Forms.RadioButton rdoMultipleFiles;
        private System.Windows.Forms.RadioButton rdoSingleFiles;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoXml;
        private System.Windows.Forms.RadioButton rdoXlsx;
        private System.Windows.Forms.RadioButton rdoXls;
        private System.Windows.Forms.RadioButton rdoCsv;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView logDataGridView;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    }
}

