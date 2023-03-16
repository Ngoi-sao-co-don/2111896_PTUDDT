namespace BaiTapWindowsForm_Bai3
{
    partial class frmBai1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdLuong = new System.Windows.Forms.RadioButton();
            this.rdTTNV = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTTNV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdLuong);
            this.groupBox1.Controls.Add(this.rdTTNV);
            this.groupBox1.Location = new System.Drawing.Point(110, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các phương thức";
            // 
            // rdLuong
            // 
            this.rdLuong.AutoSize = true;
            this.rdLuong.Location = new System.Drawing.Point(7, 50);
            this.rdLuong.Name = "rdLuong";
            this.rdLuong.Size = new System.Drawing.Size(90, 20);
            this.rdLuong.TabIndex = 0;
            this.rdLuong.TabStop = true;
            this.rdLuong.Text = "Tính lương";
            this.rdLuong.UseVisualStyleBackColor = true;
            // 
            // rdTTNV
            // 
            this.rdTTNV.AutoSize = true;
            this.rdTTNV.Location = new System.Drawing.Point(7, 22);
            this.rdTTNV.Name = "rdTTNV";
            this.rdTTNV.Size = new System.Drawing.Size(184, 20);
            this.rdTTNV.TabIndex = 0;
            this.rdTTNV.TabStop = true;
            this.rdTTNV.Text = "Hiển thị thông tin nhân viên";
            this.rdTTNV.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKetQua.Location = new System.Drawing.Point(450, 101);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(247, 81);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = false;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(12, 217);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(76, 20);
            this.lbKetQua.TabIndex = 4;
            this.lbKetQua.Text = "Kết quả: ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(261, 42);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(183, 22);
            this.txtMaNV.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập mã nhân viên: ";
            // 
            // lbTTNV
            // 
            this.lbTTNV.AutoSize = true;
            this.lbTTNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTTNV.Location = new System.Drawing.Point(12, 262);
            this.lbTTNV.Name = "lbTTNV";
            this.lbTTNV.Size = new System.Drawing.Size(10, 16);
            this.lbTTNV.TabIndex = 4;
            this.lbTTNV.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lbTTNV);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKetQua);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdLuong;
        private System.Windows.Forms.RadioButton rdTTNV;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTTNV;
    }
}