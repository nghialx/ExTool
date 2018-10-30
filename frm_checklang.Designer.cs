namespace ExTool
{
    partial class frm_checklang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_checklang));
            this.bt_check = new System.Windows.Forms.Button();
            this.gv_text = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sheet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NonJPText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tResult = new System.Windows.Forms.TabPage();
            this.tConfig = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_special = new System.Windows.Forms.TextBox();
            this.cb_special = new System.Windows.Forms.CheckBox();
            this.cb_number = new System.Windows.Forms.CheckBox();
            this.uc_menu1 = new ExTool.uc_menu();
            this.uc_file1 = new ExTool.uc_file();
            ((System.ComponentModel.ISupportInitialize)(this.gv_text)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tResult.SuspendLayout();
            this.tConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_check
            // 
            this.bt_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_check.Location = new System.Drawing.Point(951, 47);
            this.bt_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(61, 28);
            this.bt_check.TabIndex = 1;
            this.bt_check.Text = "Check";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // gv_text
            // 
            this.gv_text.AllowUserToAddRows = false;
            this.gv_text.AllowUserToDeleteRows = false;
            this.gv_text.AllowUserToOrderColumns = true;
            this.gv_text.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_text.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Sheet,
            this.Cell,
            this.Content,
            this.NonJPText});
            this.gv_text.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gv_text.Location = new System.Drawing.Point(0, 0);
            this.gv_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_text.Name = "gv_text";
            this.gv_text.Size = new System.Drawing.Size(952, 532);
            this.gv_text.TabIndex = 3;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.Width = 40;
            // 
            // Sheet
            // 
            this.Sheet.HeaderText = "Sheet";
            this.Sheet.Name = "Sheet";
            this.Sheet.Width = 120;
            // 
            // Cell
            // 
            this.Cell.HeaderText = "Cell";
            this.Cell.Name = "Cell";
            this.Cell.Width = 50;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.Width = 300;
            // 
            // NonJPText
            // 
            this.NonJPText.HeaderText = "Non JP Text";
            this.NonJPText.Name = "NonJPText";
            this.NonJPText.Width = 150;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 675);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1064, 6);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tResult);
            this.tabControl1.Controls.Add(this.tConfig);
            this.tabControl1.Location = new System.Drawing.Point(49, 101);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 565);
            this.tabControl1.TabIndex = 7;
            // 
            // tResult
            // 
            this.tResult.Controls.Add(this.gv_text);
            this.tResult.Location = new System.Drawing.Point(4, 25);
            this.tResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tResult.Name = "tResult";
            this.tResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tResult.Size = new System.Drawing.Size(955, 536);
            this.tResult.TabIndex = 0;
            this.tResult.Text = "Result";
            this.tResult.UseVisualStyleBackColor = true;
            // 
            // tConfig
            // 
            this.tConfig.Controls.Add(this.groupBox1);
            this.tConfig.Location = new System.Drawing.Point(4, 25);
            this.tConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tConfig.Name = "tConfig";
            this.tConfig.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tConfig.Size = new System.Drawing.Size(955, 536);
            this.tConfig.TabIndex = 1;
            this.tConfig.Text = "Config";
            this.tConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_special);
            this.groupBox1.Controls.Add(this.cb_special);
            this.groupBox1.Controls.Add(this.cb_number);
            this.groupBox1.Location = new System.Drawing.Point(8, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(936, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ignore list";
            // 
            // txt_special
            // 
            this.txt_special.Location = new System.Drawing.Point(295, 33);
            this.txt_special.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_special.Name = "txt_special";
            this.txt_special.Size = new System.Drawing.Size(623, 22);
            this.txt_special.TabIndex = 1;
            this.txt_special.Text = "【】『』「」＜＞＝―←→：。・ー　、（）※.,:;_()<=>";
            // 
            // cb_special
            // 
            this.cb_special.AutoSize = true;
            this.cb_special.Checked = true;
            this.cb_special.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_special.Location = new System.Drawing.Point(140, 33);
            this.cb_special.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_special.Name = "cb_special";
            this.cb_special.Size = new System.Drawing.Size(140, 21);
            this.cb_special.TabIndex = 0;
            this.cb_special.Text = "Special character";
            this.cb_special.UseVisualStyleBackColor = true;
            // 
            // cb_number
            // 
            this.cb_number.AutoSize = true;
            this.cb_number.Checked = true;
            this.cb_number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_number.Location = new System.Drawing.Point(17, 33);
            this.cb_number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_number.Name = "cb_number";
            this.cb_number.Size = new System.Drawing.Size(80, 21);
            this.cb_number.TabIndex = 0;
            this.cb_number.Text = "Number";
            this.cb_number.UseVisualStyleBackColor = true;
            // 
            // uc_menu1
            // 
            this.uc_menu1.Location = new System.Drawing.Point(1, 1);
            this.uc_menu1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uc_menu1.Name = "uc_menu1";
            this.uc_menu1.Size = new System.Drawing.Size(776, 43);
            this.uc_menu1.TabIndex = 2;
            // 
            // uc_file1
            // 
            this.uc_file1.Location = new System.Drawing.Point(13, 33);
            this.uc_file1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.uc_file1.Name = "uc_file1";
            this.uc_file1.Size = new System.Drawing.Size(1036, 59);
            this.uc_file1.TabIndex = 0;
            // 
            // frm_checklang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.uc_menu1);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.uc_file1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1082, 728);
            this.MinimumSize = new System.Drawing.Size(1082, 728);
            this.Name = "frm_checklang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check EN/VI on JP file";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_checklang_FormClosing);
            this.Load += new System.EventHandler(this.frm_checklang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_text)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tResult.ResumeLayout(false);
            this.tConfig.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private uc_file uc_file1;
        private System.Windows.Forms.Button bt_check;
        private uc_menu uc_menu1;
        private System.Windows.Forms.DataGridView gv_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn NonJPText;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tResult;
        private System.Windows.Forms.TabPage tConfig;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_special;
        private System.Windows.Forms.CheckBox cb_special;
        private System.Windows.Forms.CheckBox cb_number;
    }
}