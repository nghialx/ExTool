namespace ExTool
{
    partial class uc_file
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_choose = new System.Windows.Forms.Button();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.oFD1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_choose
            // 
            this.bt_choose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_choose.Location = new System.Drawing.Point(635, 11);
            this.bt_choose.Name = "bt_choose";
            this.bt_choose.Size = new System.Drawing.Size(67, 23);
            this.bt_choose.TabIndex = 4;
            this.bt_choose.Text = "Choose file";
            this.bt_choose.UseVisualStyleBackColor = true;
            this.bt_choose.Click += new System.EventHandler(this.bt_choose_Click);
            // 
            // txt_filepath
            // 
            this.txt_filepath.Location = new System.Drawing.Point(26, 13);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(603, 20);
            this.txt_filepath.TabIndex = 3;
            // 
            // oFD1
            // 
            this.oFD1.FileName = "openFileDialog1";
            // 
            // btOpen
            // 
            this.btOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpen.Location = new System.Drawing.Point(708, 11);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(42, 23);
            this.btOpen.TabIndex = 4;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // uc_file
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.bt_choose);
            this.Controls.Add(this.txt_filepath);
            this.Name = "uc_file";
            this.Size = new System.Drawing.Size(779, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_choose;
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.OpenFileDialog oFD1;
        private System.Windows.Forms.Button btOpen;
    }
}
