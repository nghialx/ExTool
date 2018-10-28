using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;

namespace ExTool
{
    public partial class frm_statistic : Form
    {
        public frm_statistic()
        {
            InitializeComponent();
        }

        private void frm_statistic_Load(object sender, EventArgs e)
        {

        }

        private void frm_statistic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_choose_Click(object sender, EventArgs e)
        {
            
            
            //
            // This event handler was created by double-clicking the window in the designer.
            // It runs on the program's startup routine.
            //
            DialogResult result = fdDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_folder.Text = fdDialog1.SelectedPath.ToString();
            }
        }

        private void bt_Scan_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            //Excel.Workbook wb = new Excel.Workbook();
            //Excel.Worksheet ws = new Excel.Worksheet();
            int numSheet = 0, numPrintPage = 0;
            float f;
            //DialogResult result = fdDialog1.ShowDialog();
            if (txt_folder.Text!="")
            {
                string[] files = Directory.GetFiles(fdDialog1.SelectedPath);
                txt_folder.Text = fdDialog1.SelectedPath.ToString();
                //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                progressBar1.Visible = true;
                for (int i = 0; i < files.Length; i++)
                {
                    Excel.Workbook wb = app.Workbooks.Open(files[i], ReadOnly: true, IgnoreReadOnlyRecommended: true, Notify: false);
                    numSheet = wb.Worksheets.Count;

                    f = (float)((i + 1) * 100 / files.Length);
                    progressBar1.Value = (int)f;
                    
                    numPrintPage = 0;
                    for (int j = 1; j <= numSheet; j++)
                    {
                        Excel.Worksheet ws = wb.Worksheets[j];
                        //ws.Activate();
                        numPrintPage += ws.PageSetup.Pages.Count;
                    }
                    dataGridView1.Rows.Add(i+1, files[i].Replace(txt_folder.Text,string.Empty).Replace(@"\",string.Empty), numPrintPage, numSheet);
                    wb.Close(SaveChanges: false);
                }
                progressBar1.Visible = false;
                MessageBox.Show("Done", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please choose execute folder","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
