namespace BaiTapWindowsForm_Bai4
{
    partial class frmBai2
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
            this.txtLyThuyet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThucHanh = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập điểm lý thuyết: ";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Location = new System.Drawing.Point(343, 73);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(276, 22);
            this.txtLyThuyet.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập điểm thực hành:  ";
            // 
            // txtThucHanh
            // 
            this.txtThucHanh.Location = new System.Drawing.Point(343, 115);
            this.txtThucHanh.Name = "txtThucHanh";
            this.txtThucHanh.Size = new System.Drawing.Size(276, 22);
            this.txtThucHanh.TabIndex = 1;
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(343, 158);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(126, 41);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            this.btnXepLoai.Click += new System.EventHandler(this.btnXepLoai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả xếp loại: ";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.ForeColor = System.Drawing.Color.Red;
            this.lbKQ.Location = new System.Drawing.Point(417, 232);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(21, 29);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtThucHanh);
            this.Controls.Add(this.txtLyThuyet);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLyThuyet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThucHanh;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbKQ;
    }
}