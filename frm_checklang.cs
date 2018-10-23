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

            stt_label.Visible = true;
            Excel.Application ex = new Excel.Application();
            Excel.Workbook wb = ex.Workbooks.Open(ctrl.Text);
            Excel.Worksheet atws = wb.ActiveSheet;
            stt_label.Visible = false;
            progress1.Visible = true;

            for (int i = 1; i <= wb.Worksheets.Count; i++)
            {
                //try
                //{
                    f = (float)(i * 100 / wb.Worksheets.Count);
                    progress1.Value = (int)f;
                    atws = wb.Worksheets[i];
                    atws.Activate();

                    Excel.Range range = atws.Range[atws.PageSetup.PrintArea];
                    




                //Excel.Range currentFind = null;
                //Excel.Range firstFind = null;


<<<<<<< HEAD
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
=======
                    //currentFind = range.Find("v", "",
                    //Excel.XlFindLookIn.xlValues, Excel.XlLookAt.xlPart,
                    //Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlNext, false,
                    //"", "");
                    foreach (char c in lang_char)
                    {
                        currentFind = range.Find(c.ToString(), LookAt: Excel.XlLookAt.xlPart);

                        while (currentFind != null)
                        {
                            // Keep track of the first range you find. 
                            if (firstFind == null)
                            {
                                firstFind = currentFind;
                            }

                            // If you didn't move to a new range, you are done.
                            else if (currentFind.get_Address(Excel.XlReferenceStyle.xlA1)
                                  == firstFind.get_Address(Excel.XlReferenceStyle.xlA1))
                            {
                                break;
                            }

                            currentFind.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                            currentFind.Font.Bold = true;

                            gv_text.Rows.Add(no, atws.Name, currentFind.Row, currentFind.Column, currentFind.Text, c.ToString());
                            no++;

                            currentFind = range.FindNext(currentFind);
                        }
                    }
>>>>>>> d5d034bfcfcf9f2bab20c659a23a922f99baba6f










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




                for (int j = 1; j <= range.Rows.Count; j++)
                {
                    for (int k = 1; k <= range.Columns.Count; k++)
                    {
                        Excel.Range range2 = range.Cells[j, k];

                        string value = (string)(range.Cells[j, k] as Excel.Range).Value;

                        string nonjptext = "";
                        string rg = "";
                        if (value == null)
                        {
                            continue;
                        }

                        rg += @"[";
                        rg += @"\p{Lo}"; //Remove japanese
                        rg += @"\p{N}"; //any kind of numeric character in any script.
                                        //rg += @"\p{S}"; //Remove math symbols, currency signs, dingbats, box-drawing characters, etc.
                                        //rg += @"【】『』「」＜＞＝―←→：。・ー　、（）※";
                                        // rg += @".,:;_()<=>";
                        rg += @"]";
                        nonjptext = Regex.Replace(value, rg, string.Empty);
                        nonjptext.Trim();
                        if (nonjptext != "" && nonjptext != " ")
                        {
                            string col = ColumnIndexToColumnLetter(k);
                            gv_text.Rows.Add(no, atws.Name, j, col, value, nonjptext);
                            no++;
                        }
                    }
                }



                //}
                //catch (Exception)
                //{
                //}

            }


            stt_label.Text = "Done";
            wb.Close(SaveChanges: true);
            progress1.Visible = false;
            stt_label.Visible = true;
            MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        

















        public bool ContainsUnicodeCharacter(string input)
        {
            const int MaxAnsiCode = 255;

            return input.Any(c => c > MaxAnsiCode);
        }
        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };
        public static string RemoveSign4VietnameseString(string str)
        {
            for (int e = 1; e < VietnameseSigns.Length; e++)
            {
                for (int f = 0; f < VietnameseSigns[e].Length; f++)
                    str = str.Replace(VietnameseSigns[e][f], VietnameseSigns[0][e - 1]);
            }
            return str;
        }

        private void cb_special_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_special.Checked)
            {
                txt_special.Enabled = true;
            }
            else
            {
                txt_special.Enabled = false;
            }
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
