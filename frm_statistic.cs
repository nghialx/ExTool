using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
