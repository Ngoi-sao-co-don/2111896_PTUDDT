namespace BT_ThietKeForm
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.btnThemTu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTraTu = new System.Windows.Forms.ListBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới: ";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nghĩa của từ: ";
            this.label2.UseWaitCursor = true;
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(168, 32);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(201, 22);
            this.txtTuMoi.TabIndex = 0;
            this.txtTuMoi.UseWaitCursor = true;
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(169, 66);
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(201, 22);
            this.txtNghiaCuaTu.TabIndex = 1;
            this.txtNghiaCuaTu.UseWaitCursor = true;
            // 
            // btnThemTu
            // 
            this.btnThemTu.Location = new System.Drawing.Point(169, 106);
            this.btnThemTu.Name = "btnThemTu";
            this.btnThemTu.Size = new System.Drawing.Size(101, 37);
            this.btnThemTu.TabIndex = 2;
            this.btnThemTu.Text = "Thêm từ";
            this.btnThemTu.UseVisualStyleBackColor = true;
            this.btnThemTu.UseWaitCursor = true;
            this.btnThemTu.Click += new System.EventHandler(this.btnThemTu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách từ mới";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nghĩa của từ";
            this.label4.UseWaitCursor = true;
            // 
            // lbTraTu
            // 
            this.lbTraTu.FormattingEnabled = true;
            this.lbTraTu.ItemHeight = 16;
            this.lbTraTu.Location = new System.Drawing.Point(185, 210);
            this.lbTraTu.Name = "lbTraTu";
            this.lbTraTu.Size = new System.Drawing.Size(166, 212);
            this.lbTraTu.TabIndex = 3;
            this.lbTraTu.UseWaitCursor = true;
            this.lbTraTu.SelectedIndexChanged += new System.EventHandler(this.lbTraTu_SelectedIndexChanged);
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(420, 210);
            this.txtNghia.Multiline = true;
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(164, 212);
            this.txtNghia.TabIndex = 4;
            this.txtNghia.UseWaitCursor = true;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.lbTraTu);
            this.Controls.Add(this.btnThemTu);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh-Việt";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
        private System.Windows.Forms.Button btnThemTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbTraTu;
        private System.Windows.Forms.TextBox txtNghia;
    }
}