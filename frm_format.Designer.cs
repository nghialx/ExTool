namespace ExTool
{
    partial class frm_format
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_format));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLink = new System.Windows.Forms.CheckBox();
            this.cm_font = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_percent = new System.Windows.Forms.NumericUpDown();
            this.nr_size = new System.Windows.Forms.NumericUpDown();
            this.cb_home = new System.Windows.Forms.CheckBox();
            this.cb_width = new System.Windows.Forms.CheckBox();
            this.cb_break = new System.Windows.Forms.CheckBox();
            this.cb_coverpage = new System.Windows.Forms.CheckBox();
            this.cb_Font = new System.Windows.Forms.CheckBox();
            this.cb_zoom = new System.Windows.Forms.CheckBox();
            this.cb_border = new System.Windows.Forms.CheckBox();
            this.stt1 = new System.Windows.Forms.StatusStrip();
            this.sttLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.bt_format = new System.Windows.Forms.Button();
            this.uc_file1 = new ExTool.uc_file();
            this.uc_menu1 = new ExTool.uc_menu();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_size)).BeginInit();
            this.stt1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLink);
            this.groupBox1.Controls.Add(this.cm_font);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nm_percent);
            this.groupBox1.Controls.Add(this.nr_size);
            this.groupBox1.Controls.Add(this.cb_home);
            this.groupBox1.Controls.Add(this.cb_width);
            this.groupBox1.Controls.Add(this.cb_break);
            this.groupBox1.Controls.Add(this.cb_coverpage);
            this.groupBox1.Controls.Add(this.cb_Font);
            this.groupBox1.Controls.Add(this.cb_zoom);
            this.groupBox1.Controls.Add(this.cb_border);
            this.groupBox1.Location = new System.Drawing.Point(38, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbLink
            // 
            this.cbLink.AutoSize = true;
            this.cbLink.Checked = true;
            this.cbLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLink.Location = new System.Drawing.Point(609, 62);
            this.cbLink.Name = "cbLink";
            this.cbLink.Size = new System.Drawing.Size(85, 17);
            this.cbLink.TabIndex = 8;
            this.cbLink.Text = "Remove link";
            this.cbLink.UseVisualStyleBackColor = true;
            // 
            // cm_font
            // 
            this.cm_font.FormattingEnabled = true;
            this.cm_font.Location = new System.Drawing.Point(263, 60);
            this.cm_font.Name = "cm_font";
            this.cm_font.Size = new System.Drawing.Size(127, 21);
            this.cm_font.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // nm_percent
            // 
            this.nm_percent.Location = new System.Drawing.Point(77, 61);
            this.nm_percent.Name = "nm_percent";
            this.nm_percent.Size = new System.Drawing.Size(72, 20);
            this.nm_percent.TabIndex = 5;
            this.nm_percent.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // nr_size
            // 
            this.nr_size.Location = new System.Drawing.Point(396, 60);
            this.nr_size.Name = "nr_size";
            this.nr_size.Size = new System.Drawing.Size(44, 20);
            this.nr_size.TabIndex = 5;
            this.nr_size.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // cb_home
            // 
            this.cb_home.AutoSize = true;
            this.cb_home.Checked = true;
            this.cb_home.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_home.Location = new System.Drawing.Point(609, 25);
            this.cb_home.Name = "cb_home";
            this.cb_home.Size = new System.Drawing.Size(81, 17);
            this.cb_home.TabIndex = 0;
            this.cb_home.Text = "Ctrl + Home";
            this.cb_home.UseVisualStyleBackColor = true;
            // 
            // cb_width
            // 
            this.cb_width.AutoSize = true;
            this.cb_width.Checked = true;
            this.cb_width.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_width.Location = new System.Drawing.Point(417, 25);
            this.cb_width.Name = "cb_width";
            this.cb_width.Size = new System.Drawing.Size(101, 17);
            this.cb_width.TabIndex = 0;
            this.cb_width.Text = "Width fit 1 page";
            this.cb_width.UseVisualStyleBackColor = true;
            // 
            // cb_break
            // 
            this.cb_break.AutoSize = true;
            this.cb_break.Checked = true;
            this.cb_break.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_break.Location = new System.Drawing.Point(215, 25);
            this.cb_break.Name = "cb_break";
            this.cb_break.Size = new System.Drawing.Size(124, 17);
            this.cb_break.TabIndex = 0;
            this.cb_break.Text = "Reset all break page";
            this.cb_break.UseVisualStyleBackColor = true;
            // 
            // cb_coverpage
            // 
            this.cb_coverpage.AutoSize = true;
            this.cb_coverpage.Checked = true;
            this.cb_coverpage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_coverpage.Enabled = false;
            this.cb_coverpage.Location = new System.Drawing.Point(446, 62);
            this.cb_coverpage.Name = "cb_coverpage";
            this.cb_coverpage.Size = new System.Drawing.Size(113, 17);
            this.cb_coverpage.TabIndex = 0;
            this.cb_coverpage.Text = "Ignore cover page";
            this.cb_coverpage.UseVisualStyleBackColor = true;
            this.cb_coverpage.CheckedChanged += new System.EventHandler(this.cb_Font_CheckedChanged);
            // 
            // cb_Font
            // 
            this.cb_Font.AutoSize = true;
            this.cb_Font.Checked = true;
            this.cb_Font.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Font.Location = new System.Drawing.Point(213, 62);
            this.cb_Font.Name = "cb_Font";
            this.cb_Font.Size = new System.Drawing.Size(47, 17);
            this.cb_Font.TabIndex = 0;
            this.cb_Font.Text = "Font";
            this.cb_Font.UseVisualStyleBackColor = true;
            this.cb_Font.CheckedChanged += new System.EventHandler(this.cb_Font_CheckedChanged);
            // 
            // cb_zoom
            // 
            this.cb_zoom.AutoSize = true;
            this.cb_zoom.Checked = true;
            this.cb_zoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_zoom.Location = new System.Drawing.Point(28, 64);
            this.cb_zoom.Name = "cb_zoom";
            this.cb_zoom.Size = new System.Drawing.Size(53, 17);
            this.cb_zoom.TabIndex = 0;
            this.cb_zoom.Text = "Zoom";
            this.cb_zoom.UseVisualStyleBackColor = true;
            // 
            // cb_border
            // 
            this.cb_border.AutoSize = true;
            this.cb_border.Checked = true;
            this.cb_border.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_border.Location = new System.Drawing.Point(28, 25);
            this.cb_border.Name = "cb_border";
            this.cb_border.Size = new System.Drawing.Size(93, 17);
            this.cb_border.TabIndex = 0;
            this.cb_border.Text = "Correct border";
            this.cb_border.UseVisualStyleBackColor = true;
            // 
            // stt1
            // 
            this.stt1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttLabel1,
            this.progressbar1});
            this.stt1.Location = new System.Drawing.Point(0, 428);
            this.stt1.Name = "stt1";
            this.stt1.Size = new System.Drawing.Size(800, 22);
            this.stt1.TabIndex = 4;
            this.stt1.Text = "statusStrip1";
            // 
            // sttLabel1
            // 
            this.sttLabel1.Name = "sttLabel1";
            this.sttLabel1.Size = new System.Drawing.Size(77, 17);
            this.sttLabel1.Text = "File loading...";
            this.sttLabel1.Visible = false;
            // 
            // progressbar1
            // 
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(200, 16);
            this.progressbar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbar1.Visible = false;
            // 
            // bt_format
            // 
            this.bt_format.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_format.Location = new System.Drawing.Point(353, 196);
            this.bt_format.Name = "bt_format";
            this.bt_format.Size = new System.Drawing.Size(75, 23);
            this.bt_format.TabIndex = 5;
            this.bt_format.Text = "Format";
            this.bt_format.UseVisualStyleBackColor = true;
            this.bt_format.Click += new System.EventHandler(this.bt_format_Click);
            // 
            // uc_file1
            // 
            this.uc_file1.Location = new System.Drawing.Point(13, 36);
            this.uc_file1.Name = "uc_file1";
            this.uc_file1.Size = new System.Drawing.Size(779, 48);
            this.uc_file1.TabIndex = 6;
            // 
            // uc_menu1
            // 
            this.uc_menu1.Location = new System.Drawing.Point(1, 1);
            this.uc_menu1.Name = "uc_menu1";
            this.uc_menu1.Size = new System.Drawing.Size(799, 24);
            this.uc_menu1.TabIndex = 0;
            // 
            // frm_format
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uc_file1);
            this.Controls.Add(this.bt_format);
            this.Controls.Add(this.stt1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uc_menu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frm_format";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit format of excel file";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_format_FormClosing);
            this.Load += new System.EventHandler(this.frm_format_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nr_size)).EndInit();
            this.stt1.ResumeLayout(false);
            this.stt1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private uc_menu uc_menu1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip stt1;
        private System.Windows.Forms.ToolStripProgressBar progressbar1;
        private System.Windows.Forms.CheckBox cb_home;
        private System.Windows.Forms.CheckBox cb_width;
        private System.Windows.Forms.CheckBox cb_break;
        private System.Windows.Forms.CheckBox cb_border;
        private System.Windows.Forms.NumericUpDown nr_size;
        private System.Windows.Forms.CheckBox cb_Font;
        private System.Windows.Forms.CheckBox cb_zoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cm_font;
        private System.Windows.Forms.NumericUpDown nm_percent;
        private System.Windows.Forms.Button bt_format;
        private System.Windows.Forms.CheckBox cb_coverpage;
        private System.Windows.Forms.ToolStripStatusLabel sttLabel1;
        private uc_file uc_file1;
        private System.Windows.Forms.CheckBox cbLink;
    }
}