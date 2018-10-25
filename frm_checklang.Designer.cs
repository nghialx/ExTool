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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stt_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress1 = new System.Windows.Forms.ToolStripProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_special = new System.Windows.Forms.TextBox();
            this.cb_special = new System.Windows.Forms.CheckBox();
            this.cb_number = new System.Windows.Forms.CheckBox();
            this.uc_menu1 = new ExTool.uc_menu();
            this.uc_file1 = new ExTool.uc_file();
            ((System.ComponentModel.ISupportInitialize)(this.gv_text)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_check
            // 
            this.bt_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_check.Location = new System.Drawing.Point(713, 45);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(46, 23);
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
            this.gv_text.Location = new System.Drawing.Point(37, 182);
            this.gv_text.Name = "gv_text";
            this.gv_text.ReadOnly = true;
            this.gv_text.Size = new System.Drawing.Size(722, 438);
            this.gv_text.TabIndex = 3;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 40;
            // 
            // Sheet
            // 
            this.Sheet.HeaderText = "Sheet";
            this.Sheet.Name = "Sheet";
            this.Sheet.ReadOnly = true;
            this.Sheet.Width = 120;
            // 
            // Cell
            // 
            this.Cell.HeaderText = "Cell";
            this.Cell.Name = "Cell";
            this.Cell.ReadOnly = true;
            this.Cell.Width = 50;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 300;
            // 
            // NonJPText
            // 
            this.NonJPText.HeaderText = "Non JP Text";
            this.NonJPText.Name = "NonJPText";
            this.NonJPText.ReadOnly = true;
            this.NonJPText.Width = 150;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stt_label,
            this.progress1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stt_label
            // 
            this.stt_label.Name = "stt_label";
            this.stt_label.Size = new System.Drawing.Size(78, 17);
            this.stt_label.Text = "Loading file...";
            this.stt_label.Visible = false;
            // 
            // progress1
            // 
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(200, 16);
            this.progress1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progress1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_special);
            this.groupBox1.Controls.Add(this.cb_special);
            this.groupBox1.Controls.Add(this.cb_number);
            this.groupBox1.Location = new System.Drawing.Point(37, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ignore list";
            // 
            // txt_special
            // 
            this.txt_special.Location = new System.Drawing.Point(221, 27);
            this.txt_special.Name = "txt_special";
            this.txt_special.Size = new System.Drawing.Size(479, 20);
            this.txt_special.TabIndex = 1;
            this.txt_special.Text = "【】『』「」＜＞＝―←→：。・ー　、（）※.,:;_()<=>";
            // 
            // cb_special
            // 
            this.cb_special.AutoSize = true;
            this.cb_special.Checked = true;
            this.cb_special.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_special.Location = new System.Drawing.Point(105, 27);
            this.cb_special.Name = "cb_special";
            this.cb_special.Size = new System.Drawing.Size(109, 17);
            this.cb_special.TabIndex = 0;
            this.cb_special.Text = "Special character";
            this.cb_special.UseVisualStyleBackColor = true;
            // 
            // cb_number
            // 
            this.cb_number.AutoSize = true;
            this.cb_number.Checked = true;
            this.cb_number.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_number.Location = new System.Drawing.Point(13, 27);
            this.cb_number.Name = "cb_number";
            this.cb_number.Size = new System.Drawing.Size(63, 17);
            this.cb_number.TabIndex = 0;
            this.cb_number.Text = "Number";
            this.cb_number.UseVisualStyleBackColor = true;
            // 
            // uc_menu1
            // 
            this.uc_menu1.Location = new System.Drawing.Point(1, 1);
            this.uc_menu1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_menu1.Name = "uc_menu1";
            this.uc_menu1.Size = new System.Drawing.Size(582, 35);
            this.uc_menu1.TabIndex = 2;
            // 
            // uc_file1
            // 
            this.uc_file1.Location = new System.Drawing.Point(10, 34);
            this.uc_file1.Margin = new System.Windows.Forms.Padding(4);
            this.uc_file1.Name = "uc_file1";
            this.uc_file1.Size = new System.Drawing.Size(777, 48);
            this.uc_file1.TabIndex = 0;
            // 
            // frm_checklang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gv_text);
            this.Controls.Add(this.uc_menu1);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.uc_file1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 699);
            this.MinimumSize = new System.Drawing.Size(816, 699);
            this.Name = "frm_checklang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check EN/VI on JP file";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_checklang_FormClosing);
            this.Load += new System.EventHandler(this.frm_checklang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_text)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private uc_file uc_file1;
        private System.Windows.Forms.Button bt_check;
        private uc_menu uc_menu1;
        private System.Windows.Forms.DataGridView gv_text;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stt_label;
        private System.Windows.Forms.ToolStripProgressBar progress1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_number;
        private System.Windows.Forms.CheckBox cb_special;
        private System.Windows.Forms.TextBox txt_special;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sheet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn NonJPText;
    }
}