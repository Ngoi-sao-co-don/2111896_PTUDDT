namespace BaiTapWindowsForm_Bai2
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bàiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.msBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bàiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bàiToolStripMenuItem
            // 
            this.bàiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msBai1,
            this.msBai2,
            this.msBai3});
            this.bàiToolStripMenuItem.Name = "bàiToolStripMenuItem";
            this.bàiToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.bàiToolStripMenuItem.Text = "Bài kiểm tra";
            // 
            // msBai1
            // 
            this.msBai1.Image = ((System.Drawing.Image)(resources.GetObject("msBai1.Image")));
            this.msBai1.Name = "msBai1";
            this.msBai1.Size = new System.Drawing.Size(224, 26);
            this.msBai1.Text = "Bài 1";
            this.msBai1.Click += new System.EventHandler(this.msBai1_Click);
            // 
            // msBai2
            // 
            this.msBai2.Image = ((System.Drawing.Image)(resources.GetObject("msBai2.Image")));
            this.msBai2.Name = "msBai2";
            this.msBai2.Size = new System.Drawing.Size(224, 26);
            this.msBai2.Text = "Bài 2";
            this.msBai2.Click += new System.EventHandler(this.msBai2_Click);
            // 
            // msBai3
            // 
            this.msBai3.Image = ((System.Drawing.Image)(resources.GetObject("msBai3.Image")));
            this.msBai3.Name = "msBai3";
            this.msBai3.Size = new System.Drawing.Size(224, 26);
            this.msBai3.Text = "Bài 3";
            this.msBai3.Click += new System.EventHandler(this.msBai3_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bàiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msBai1;
        private System.Windows.Forms.ToolStripMenuItem msBai2;
        private System.Windows.Forms.ToolStripMenuItem msBai3;
    }
}

