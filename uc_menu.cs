﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExTool
{
    public partial class uc_menu : UserControl
    {
        public uc_menu()
        {
            InitializeComponent();
        }

        private void formatPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.Name!="frm_main")
            {
                this.ParentForm.Close();
            }
            else
            {
                this.ParentForm.Hide();
            }
            frm_format frm = new frm_format();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.ParentForm.Close();
        }

        private void startedWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ParentForm.Name != "frm_main")
            {
                this.ParentForm.Close();
                frm_main frm = new frm_main();
                frm.Show();
            }
        }
    }
}
