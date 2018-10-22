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
            this.uc_file1 = new ExTool.uc_file();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintPage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_menu1
            // 
            this.uc_menu1.Location = new System.Drawing.Point(-1, -1);
            this.uc_menu1.Name = "uc_menu1";
            this.uc_menu1.Size = new System.Drawing.Size(582, 26);
            this.uc_menu1.TabIndex = 0;
            // 
            // uc_file1
            // 
            this.uc_file1.Location = new System.Drawing.Point(12, 31);
            this.uc_file1.Name = "uc_file1";
            this.uc_file1.Size = new System.Drawing.Size(779, 48);
            this.uc_file1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Sheet,
            this.PrintPage});
            this.dataGridView1.Location = new System.Drawing.Point(37, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Sheet
            // 
            this.Sheet.HeaderText = "Sheet";
            this.Sheet.Name = "Sheet";
            // 
            // PrintPage
            // 
            this.PrintPage.HeaderText = "Print pages";
            this.PrintPage.Name = "PrintPage";
            // 
            // frm_statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uc_file1);
            this.Controls.Add(this.uc_menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frm_statistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_statistic_FormClosing);
            this.Load += new System.EventHandler(this.frm_statistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private uc_menu uc_menu1;
        private uc_file uc_file1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrintPage;
    }
}