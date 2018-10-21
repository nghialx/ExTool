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
    public partial class uc_file : UserControl
    {
        public uc_file()
        {
            InitializeComponent();
        }

        private void bt_choose_Click(object sender, EventArgs e)
        {
            if (oFD1.ShowDialog()==DialogResult.OK)
            {
                txt_filepath.Text = oFD1.FileName;
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            //Excel.Application ex = new Excel.Application();
            if (System.IO.File.Exists(txt_filepath.Text))
            {
                Process.Start(txt_filepath.Text);
            }
            else
            {
                MessageBox.Show("There is no file to open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
