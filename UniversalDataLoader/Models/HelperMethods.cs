using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversalDataLoader.Models
{
    public class HelperMethods
    {

        public  static bool SaveDataGridToFile(string file, DataGridView dtaGridView)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(file, FileMode.Create)))
            {
                bw.Write(dtaGridView.Columns.Count);
                bw.Write(dtaGridView.Rows.Count);
                foreach (DataGridViewRow dgvR in dtaGridView.Rows)
                {
                    for (int j = 0; j < dtaGridView.Columns.Count; ++j)
                    {
                        object val = dgvR.Cells[j].Value;
                        if (val == null)
                        {
                            bw.Write(false);
                            bw.Write(false);
                        }
                        else
                        {
                            bw.Write(true);
                            bw.Write(val.ToString());
                        }
                    }
                }
                return true;
            }
        }
    }
}
