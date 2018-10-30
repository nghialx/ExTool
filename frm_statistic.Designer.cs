namespace ExTool
{
    partial class frm_statistic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_statistic));
            this.uc_menu1 = new ExTool.uc_menu();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_folder = new System.Windows.Forms.TextBox();
            this.bt_choose = new System.Windows.Forms.Button();
            this.bt_Scan = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_menu1
            // 
            this.uc_menu1.Location = new System.Drawing.Point(-1, -1);
            this.uc_menu1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uc_menu1.Name = "uc_menu1";
            this.uc_menu1.Size = new System.Drawing.Size(776, 32);
            this.uc_menu1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.File,
            this.PrintPage,
            this.NumSheet});
            this.dataGridView1.Location = new System.Drawing.Point(49, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 417);
            this.dataGridView1.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // File
            // 
            this.File.HeaderText = "File";
            this.File.Name = "File";
            this.File.Width = 470;
            // 
            // PrintPage
            // 
            this.PrintPage.HeaderText = "Printed pages";
            this.PrintPage.Name = "PrintPage";
            this.PrintPage.Width = 70;
            // 
            // NumSheet
            // 
            this.NumSheet.HeaderText = "Num. Sheet";
            this.NumSheet.Name = "NumSheet";
            this.NumSheet.Width = 70;
            // 
            // txt_folder
            // 
            this.txt_folder.Enabled = false;
            this.txt_folder.Location = new System.Drawing.Point(49, 57);
            this.txt_folder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_folder.Name = "txt_folder";
            this.txt_folder.Size = new System.Drawing.Size(787, 22);
            this.txt_folder.TabIndex = 3;
            // 
            // bt_choose
            // 
            this.bt_choose.Location = new System.Drawing.Point(845, 54);
            this.bt_choose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_choose.Name = "bt_choose";
            this.bt_choose.Size = new System.Drawing.Size(75, 28);
            this.bt_choose.TabIndex = 4;
            this.bt_choose.Text = "Choose";
            this.bt_choose.UseVisualStyleBackColor = true;
            this.bt_choose.Click += new System.EventHandler(this.bt_choose_Click);
            // 
            // bt_Scan
            // 
            this.bt_Scan.Location = new System.Drawing.Point(928, 54);
            this.bt_Scan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Scan.Name = "bt_Scan";
            this.bt_Scan.Size = new System.Drawing.Size(85, 28);
            this.bt_Scan.TabIndex = 5;
            this.bt_Scan.Text = "Scan files";
            this.bt_Scan.UseVisualStyleBackColor = true;
            this.bt_Scan.Click += new System.EventHandler(this.bt_Scan_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 538);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1064, 6);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // frm_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 544);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bt_Scan);
            this.Controls.Add(this.bt_choose);
            this.Controls.Add(this.txt_folder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uc_menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1082, 591);
            this.MinimumSize = new System.Drawing.Size(1082, 591);
            this.Name = "frm_statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_statistic_FormClosing);
            this.Load += new System.EventHandler(this.frm_statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uc_menu uc_menu1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FolderBrowserDialog fdDialog1;
        private System.Windows.Forms.TextBox txt_folder;
        private System.Windows.Forms.Button bt_choose;
        private System.Windows.Forms.Button bt_Scan;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSheet;
    }
}