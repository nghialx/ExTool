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


namespace ExTool
{
    public partial class frm_format : Form
    {
        public frm_format()
        {
            InitializeComponent();
        }

        private void frm_format_Load(object sender, EventArgs e)
        {
            int index = 0;

            InstalledFontCollection fonts = new InstalledFontCollection();
            FontFamily[] font = fonts.Families.ToArray();

            for (int i = 0; i < font.Length; i++)

            {
                cm_font.Items.Add(font[i].Name);
                if (font[i].Name == "Meiryo UI")
                {
                    index = i;
                }

            }
            cm_font.SelectedIndex = index;
        }

        private void cb_Font_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Font.Checked == false)
            {
                nr_size.Enabled = false;
                cm_font.Enabled = false;
            }
            else
            {
                nr_size.Enabled = true;
                cm_font.Enabled = true;
            }
        }

        private void bt_format_Click(object sender, EventArgs e)
        {

            var ctrl = uc_file1.Controls.Cast<Control>().Where(n => n.Name == "txt_filepath").FirstOrDefault();
            if (ctrl.Text == "")
            {
                MessageBox.Show("There is no file to execute", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                format(ctrl.Text);
            }

        }

        private void format(string filename)
        {
            double f;
            sttLabel1.Visible = true;
            Excel.Application ex = new Excel.Application();
            Excel.Workbook wb = ex.Workbooks.Open(filename);
            Excel.Worksheet atws = wb.ActiveSheet;
            sttLabel1.Visible = false;
            progressbar1.Visible = true;
            for (int i = 1; i <= wb.Worksheets.Count; i++)
            {
                try
                {
                    f = (float)(i * 100 / 19);
                    progressbar1.Value = (int)f;
                    atws = wb.Worksheets[i];
                    if (atws.Visible == Excel.XlSheetVisibility.xlSheetHidden)
                    {
                        continue;
                    }
                    atws.Activate();

                    Excel.Range range = atws.Range[atws.PageSetup.PrintArea];
                    if (cb_border.Checked)
                    {
                        range.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);
                    }

                    if (cb_break.Checked)
                    {
                        atws.ResetAllPageBreaks();
                    }

                    if (cb_width.Checked)
                    {
                        atws.PageSetup.Zoom = false;
                        atws.PageSetup.FitToPagesWide = 1;
                        atws.PageSetup.FitToPagesTall = false;
                    }

                    if (cb_home.Checked)
                    {
                        atws.get_Range("a1", "a1").Select();
                    }

                    if (cb_zoom.Checked)
                    {
                        wb.Windows[1].Zoom = nm_percent.Value;
                    }

                    if (cb_Font.Checked)
                    {
                        if (cb_coverpage.Checked && i == 1)
                        {
                            continue;
                        }
                        atws.Rows.Font.Name = cm_font.Text;
                        atws.Rows.Font.Size = nr_size.Value;
                        for (int j = 1; j <= atws.Shapes.Count; j++)
                        {
                            try
                            {
                                atws.Shapes.Item(j).TextFrame2.TextRange.Font.NameComplexScript = cm_font.Text;
                                atws.Shapes.Item(j).TextFrame2.TextRange.Font.NameFarEast = cm_font.Text;
                                atws.Shapes.Item(j).TextFrame2.TextRange.Font.NameAscii = cm_font.Text;
                                atws.Shapes.Item(j).TextFrame2.TextRange.Font.NameOther = cm_font.Text;
                                atws.Shapes.Item(j).TextFrame2.TextRange.Font.Name = cm_font.Text;
                                atws.Shapes.Item(j).TextFrame2.TextRange.Font.Size = (int)nr_size.Value;
                            }


                            catch (Exception)
                            {

                                continue;
                            }

                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }

            }
            atws = wb.Worksheets[1];
            atws.Activate();

            wb.Close(SaveChanges: true);
            progressbar1.Visible = false;
            sttLabel1.Text = "Done";
            sttLabel1.Visible = true;
            MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
