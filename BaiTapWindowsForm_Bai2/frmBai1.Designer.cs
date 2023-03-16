namespace BaiTapWindowsForm_Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbThietBi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbThietBi = new System.Windows.Forms.ListBox();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin mua hàng";
            // 
            // cbbThietBi
            // 
            this.cbbThietBi.FormattingEnabled = true;
            this.cbbThietBi.Location = new System.Drawing.Point(152, 93);
            this.cbbThietBi.Name = "cbbThietBi";
            this.cbbThietBi.Size = new System.Drawing.Size(223, 24);
            this.cbbThietBi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền: ";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.Location = new System.Drawing.Point(194, 364);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(21, 29);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = ".";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(152, 138);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(223, 22);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Chọn thiết bị: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số lượng mua: ";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(593, 93);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(75, 67);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nước sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã thiết bị";
            // 
            // lstbThietBi
            // 
            this.lstbThietBi.FormattingEnabled = true;
            this.lstbThietBi.ItemHeight = 16;
            this.lstbThietBi.Location = new System.Drawing.Point(33, 251);
            this.lstbThietBi.Name = "lstbThietBi";
            this.lstbThietBi.Size = new System.Drawing.Size(672, 100);
            this.lstbThietBi.TabIndex = 5;
            // 
            // btnThemHang
            // 
            this.btnThemHang.Location = new System.Drawing.Point(391, 93);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(75, 67);
            this.btnThemHang.TabIndex = 4;
            this.btnThemHang.Text = "Thêm hàng";
            this.btnThemHang.UseVisualStyleBackColor = true;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(491, 93);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(75, 67);
            this.btnBoHang.TabIndex = 4;
            this.btnBoHang.Text = "Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbThietBi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemHang);
            this.Controls.Add(this.btnBoHang);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbbThietBi);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbThietBi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstbThietBi;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Button btnBoHang;
    }
}