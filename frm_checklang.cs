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

        }

        private void frm_checklang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            double f;
            int no = 1;

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

            string rg = "";
            string value = "";
            string nonjptext = "";
            rg += @"[";
            rg += @"\p{Lo}"; //Remove japanese
            rg += @"\p{N}"; //any kind of numeric character in any script.

            //rg += @"\p{s}"; //remove math symbols, currency signs, dingbats, box-drawing characters, etc.
            //rg += @"【】『』「」＜＞＝―←→：。・ー　、（）※";
            //rg += @".,:;_()<=>";
            rg += txt_special.Text;

            rg += @"]";
            //        nonjptext = Regex.Replace(value, rg, string.Empty);
            //        nonjptext.Trim();


            //DataTable tbdata = new DataTable();
            // Loop through all of the sheets if you want too...
            gv_text.DataSource = null;
            stt_label.Visible = true;
            
            for (int j = 0; j < sheetNames.Length; j++)
            {
                progress1.Visible = true;
                progress1.Value = 0;
                if (sheetNames[j] == null)
                {
                    continue;
                }
                stt_label.Text = sheetNames[j].Replace("$", "");
                string sql = "select * from [" + sheetNames[j] + "]";
                OleDbDataAdapter objDA = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
                conn.Close();

                DataSet excelDataSet = new DataSet();
                objDA.Fill(excelDataSet);
                DataTable tbdata = excelDataSet.Tables[0];

                //tbdata = tbdata.Rows
                //.Cast<DataRow>()
                //.Where(row => !row.ItemArray.All(field => field is DBNull ||
                //                                 string.IsNullOrWhiteSpace(field as string)))
                //.CopyToDataTable();

                //foreach (var column in tbdata.Columns.Cast<DataColumn>().ToArray())
                //{
                //    if (tbdata.AsEnumerable().All(dr => dr.IsNull(column)))
                //        tbdata.Columns.Remove(column);
                //}
                
                int erow = 2;
                foreach (DataRow dtr in tbdata.Rows)
                {
                    erow++;
                     f = (float)((erow-2) * 100 / tbdata.Rows.Count);
                    progress1.Value = (int)f;
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
                        if (nonjptext == value || nonjptext.ToUpper() == nonjptext)
                        {
                            continue;
                        }

                        if (nonjptext.Trim() != "")
                        {
                            gv_text.Rows.Add("1", sheetNames[j].Replace("$",""), ColumnIndexToColumnLetter(ecol)+ erow.ToString(), value, nonjptext);
                        }
                    }
                }
                progress1.Visible = false;

            }
            stt_label.Text = "Done";
            MessageBox.Show("Done");


































            //for (int i = 1; i <= wb.Worksheets.Count; i++)
            //{
            //    //try
            //    //{
            //        f = (float)(i * 100 / wb.Worksheets.Count);
            //        progress1.Value = (int)f;
            //        atws = wb.Worksheets[i];
            //        atws.Activate();

            //        Excel.Range range = atws.Range[atws.PageSetup.PrintArea];





            //Excel.Range currentFind = null;
            //Excel.Range firstFind = null;


            ////currentFind = range.Find("v", "",
            ////Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
            ////Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
            ////"", "");

            //currentFind = range.Find("v", LookAt:Excel.XlLookAt.xlPart);

            //while (currentFind != null)
            //{
            //    // Keep track of the first range you find. 
            //    if (firstFind == null)
            //    {
            //        firstFind = currentFind;
            //    }

            //    // If you didn't move to a new range, you are done.
            //    else if (currentFind.get_Address(Excel.XlReferenceStyle.xlA1)
            //          == firstFind.get_Address(Excel.XlReferenceStyle.xlA1))
            //    {
            //        break;
            //    }

            //    currentFind.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            //    currentFind.Font.Bold = true;

            //    gv_text.Rows.Add(no, atws.Name, currentFind.Row, currentFind.Column, currentFind.Text, "");
            //    no++;

            //    currentFind = range.FindNext(currentFind);
            //}
            //currentFind = range.Find("v", "",
            //Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
            //Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
            //"", "");
            //foreach (char c in lang_char)
            //{
            //    currentFind = range.Find(c.ToString(), LookAt: Excel.XlLookAt.xlPart);

            //    while (currentFind != null)
            //    {
            //        // Keep track of the first range you find. 
            //        if (firstFind == null)
            //        {
            //            firstFind = currentFind;
            //        }

            //        // If you didn't move to a new range, you are done.
            //        else if (currentFind.get_Address(Excel.XlReferenceStyle.xlA1)
            //              == firstFind.get_Address(Excel.XlReferenceStyle.xlA1))
            //        {
            //            break;
            //        }

            //        currentFind.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
            //        currentFind.Font.Bold = true;

            //        gv_text.Rows.Add(no, atws.Name, currentFind.Row, currentFind.Column, currentFind.Text, c.ToString());
            //        no++;

            //        currentFind = range.FindNext(currentFind);
            //    }
            //}










            //for (int j = 1; j <= range.Rows.Count; j++)
            //{
            //    for (int k = 1; k <= range.Columns.Count; k++)
            //    {
            //        Excel.Range range2 = range.Cells[j, k];
            //        string tmp;
            //        string tmp_en = "";
            //        string value = (string)(range.Cells[j, k] as Excel.Range).Value;
            //        string nonjptext = "";
            //        if (value == null)
            //        {
            //            continue;
            //        }
            //        foreach (char c in value)
            //        {
            //            tmp = c.ToString();
            //            //Check number
            //            if (cb_number.Checked)
            //            {
            //                double myNum = 0;
            //                if (Double.TryParse(tmp, out myNum))
            //                {
            //                    continue;
            //                }
            //            }

            //            //Check special charater
            //            if (cb_special.Checked)
            //            {
            //                if (txt_special.Text.Contains(tmp))
            //                {
            //                    continue;
            //                }
            //            }

            //            //tmp_en = RemoveSign4VietnameseString(tmp);
            //            if (!ContainsUnicodeCharacter(tmp))
            //            {
            //                nonjptext += tmp;
            //            }
            //        }
            //        nonjptext.Trim();
            //        if (nonjptext != "" && nonjptext != " ")
            //        {
            //            string col = ColumnIndexToColumnLetter(k);
            //            gv_text.Rows.Add(no, atws.Name, j, col, value, nonjptext);
            //            no++;
            //        }
            //    }
            //}




            //for (int j = 1; j <= range.Rows.Count; j++)
            //{
            //    for (int k = 1; k <= range.Columns.Count; k++)
            //    {
            //        Excel.Range range2 = range.Cells[j, k];

            //        string value = (string)(range.Cells[j, k] as Excel.Range).Value;

            //        string nonjptext = "";
            //        string rg = "";
            //        if (value == null)
            //        {
            //            continue;
            //        }

            //        rg += @"[";
            //        rg += @"\p{Lo}"; //Remove japanese
            //        rg += @"\p{N}"; //any kind of numeric character in any script.
            //                        //rg += @"\p{S}"; //Remove math symbols, currency signs, dingbats, box-drawing characters, etc.
            //                        //rg += @"【】『』「」＜＞＝―←→：。・ー　、（）※";
            //                        // rg += @".,:;_()<=>";
            //        rg += @"]";
            //        nonjptext = Regex.Replace(value, rg, string.Empty);
            //        nonjptext.Trim();
            //        if (nonjptext != "" && nonjptext != " ")
            //        {
            //            string col = ColumnIndexToColumnLetter(k);
            //            gv_text.Rows.Add(no, atws.Name, j, col, value, nonjptext);
            //            no++;
            //        }
            //    }
            //}



            //}
            //catch (Exception)
            //{
            //}

        }


        //stt_label.Text = "Done";
        //wb.Close(SaveChanges: true);
        //progress1.Visible = false;
        //stt_label.Visible = true;
        //MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
