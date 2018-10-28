using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Diagnostics;
using System.Linq.Expressions;

using System.Text.RegularExpressions;

using System.Data.OleDb;

namespace ExTool
{
    public partial class frm_checklang : Form
    {
        //public string lang_char = "abcdefghijklmnopqrstuvwxyzáàạảãâấầậẩẫăắằặẳẵéèẹẻẽêếềệểễóòọỏõôốồộổỗơớờợởỡúùụủũưứừựửữíìịỉĩđýỳỵỷỹ";
        public frm_checklang()
        {
            InitializeComponent();
        }

        private void frm_checklang_Load(object sender, EventArgs e)
        {
            //gv_text.Columns[0].Visible = false;
        }

        private void frm_checklang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            double f;
            int ind = 0;

            var ctrl = uc_file1.Controls.Cast<Control>().Where(n => n.Name == "txt_filepath").FirstOrDefault();
            if (ctrl.Text == "")
            {
                MessageBox.Show("There is no file to execute", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var connectionString = String.Format(@"
            Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source={0};
            Extended Properties=""Excel 12.0 Xml;HDR=YES""", ctrl.Text);

            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            String[] sheetNames = new String[dt.Rows.Count];
            int x = 0;
            foreach (DataRow row in dt.Rows)
            {
                string tmp = row["TABLE_NAME"].ToString();
                if (tmp.Length >= 5 && tmp.Substring(0, 5) == "_xlnm")
                {
                    continue;
                }
                sheetNames[x] = row["TABLE_NAME"].ToString();

                x++;

            }

            List<string> sheetnotnull = sheetNames.ToList<string>();
            sheetnotnull.RemoveAll(p => string.IsNullOrEmpty(p));
            sheetNames = sheetnotnull.ToArray();


            string rg = "";
            string value = "";
            string nonjptext = "";
            rg += @"[";
            rg += @"\p{Lo}"; //Remove japanese
            rg += @"\p{N}"; //any kind of numeric character in any script.

            //rg += @"\p{s}"; //remove math symbols, currency signs, dingbats, box-drawing characters, etc.
            rg += txt_special.Text;
            rg += @"]";
            // Loop through all of the sheets if you want too...
            gv_text.DataSource = null;
            gv_text.DataBindings.Clear();

            //stt_label.Visible = true;

            progressBar1.Visible = true;

            for (int j = 0; j < sheetNames.Length; j++)
            {
                f = (float)( (j+1)* 100 / sheetNames.Length);
                progressBar1.Value = (int)f;

                if (sheetNames[j] == null)
                {
                    continue;
                }
                //stt_label.Text = sheetNames[j].Replace("$", "");
                //stt_label.Text = sheetNames[j].Replace("'", "");
                string sql = "select * from [" + sheetNames[j] + "]";
                OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
                conn.Close();

                DataSet excelDataSet = new DataSet();
                objDA.Fill(excelDataSet);
                DataTable tbdata = excelDataSet.Tables[0];

                int erow = 2;
                foreach (DataRow dtr in tbdata.Rows)
                {
                    erow++;
                    
                    object[] values = dtr.ItemArray;
                    int ecol = 0;
                    foreach (var item in values)
                    {
                        ecol++;
                        if (item.ToString() == "")
                        {
                            continue;
                        }
                        value = item.ToString();
                        nonjptext = Regex.Replace(value, rg, string.Empty);
                        if (nonjptext == value || nonjptext.ToUpper() == nonjptext || nonjptext+"." == value || value == "hh:mm")
                        {
                            continue;
                        }

                        if (nonjptext.Trim() != "")
                        {
                            ind++;
                            gv_text.Rows.Add(ind, sheetNames[j].Replace("$", "").Replace("'", ""), ColumnIndexToColumnLetter(ecol) + erow.ToString(), value, nonjptext);
                        }
                    }
                }
                

            }
            progressBar1.Visible = false;
            //stt_label.Text = "Done";
            MessageBox.Show("Done");
        }

        static string ColumnIndexToColumnLetter(int colIndex)
        {
            int div = colIndex;
            string colLetter = String.Empty;
            int mod = 0;

            while (div > 0)
            {
                mod = (div - 1) % 26;
                colLetter = (char)(65 + mod) + colLetter;
                div = (int)((div - mod) / 26);
            }
            return colLetter;
        }
    }
}





















    //public bool ContainsUnicodeCharacter(string input)
    //{
    //    const int MaxAnsiCode = 255;

    //    return input.Any(c => c > MaxAnsiCode);
    //}
    //private static readonly string[] VietnameseSigns = new string[]
    //{

    //    "aAeEoOuUiIdDyY",
    //    "áàạảãâấầậẩẫăắằặẳẵ",
    //    "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
    //    "éèẹẻẽêếềệểễ",
    //    "ÉÈẸẺẼÊẾỀỆỂỄ",
    //    "óòọỏõôốồộổỗơớờợởỡ",
    //    "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
    //    "úùụủũưứừựửữ",
    //    "ÚÙỤỦŨƯỨỪỰỬỮ",
    //    "íìịỉĩ",
    //    "ÍÌỊỈĨ",
    //    "đ",
    //    "Đ",
    //    "ýỳỵỷỹ",
    //    "ÝỲỴỶỸ"
    //};
    //public static string RemoveSign4VietnameseString(string str)
    //{
    //    for (int e = 1; e < VietnameseSigns.Length; e++)
    //    {
    //        for (int f = 0; f < VietnameseSigns[e].Length; f++)
    //            str = str.Replace(VietnameseSigns[e][f], VietnameseSigns[0][e - 1]);
    //    }
    //    return str;
    //}

    //private void cb_special_CheckedChanged(object sender, EventArgs e)
    //{
    //    if (cb_special.Checked)
    //    {
    //        txt_special.Enabled = true;
    //    }
    //    else
    //    {
    //        txt_special.Enabled = false;
    //    }
    //}

    //static string ColumnIndexToColumnLetter(int colIndex)
    //{
    //    int div = colIndex;
    //    string colLetter = String.Empty;
    //    int mod = 0;

    //    while (div > 0)
    //    {
    //        mod = (div - 1) % 26;
    //        colLetter = (char)(65 + mod) + colLetter;
    //        div = (int)((div - mod) / 26);
    //    }
    //    return colLetter;
    //}
