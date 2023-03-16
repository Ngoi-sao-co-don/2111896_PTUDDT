namespace BaiTapWindowsForm_Bai4
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
            this.txtTraCuuMaSP = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtNgaySX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbTinhTrangThem = new System.Windows.Forms.Label();
            this.lbKQT = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã sản phầm: ";
            // 
            // txtTraCuuMaSP
            // 
            this.txtTraCuuMaSP.Location = new System.Drawing.Point(192, 264);
            this.txtTraCuuMaSP.Name = "txtTraCuuMaSP";
            this.txtTraCuuMaSP.Size = new System.Drawing.Size(190, 22);
            this.txtTraCuuMaSP.TabIndex = 1;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(388, 264);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(89, 32);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả:";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(54, 355);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(18, 26);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = ".";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMaSP, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTenSP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLoaiSP, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNgaySX, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(264, 79);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 59);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã SP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên SP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "LoaiSP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngay SX";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(4, 33);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(69, 22);
            this.txtMaSP.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(80, 33);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(145, 22);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(232, 33);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(107, 22);
            this.txtLoaiSP.TabIndex = 1;
            // 
            // txtNgaySX
            // 
            this.txtNgaySX.Location = new System.Drawing.Point(346, 33);
            this.txtNgaySX.Name = "txtNgaySX";
            this.txtNgaySX.Size = new System.Drawing.Size(110, 22);
            this.txtNgaySX.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thêm thông tin sản phẩm";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(610, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 37);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbTinhTrangThem
            // 
            this.lbTinhTrangThem.AutoSize = true;
            this.lbTinhTrangThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhTrangThem.Location = new System.Drawing.Point(54, 209);
            this.lbTinhTrangThem.Name = "lbTinhTrangThem";
            this.lbTinhTrangThem.Size = new System.Drawing.Size(204, 29);
            this.lbTinhTrangThem.TabIndex = 0;
            this.lbTinhTrangThem.Text = "Tình trạng thêm: ";
            // 
            // lbKQT
            // 
            this.lbKQT.AutoSize = true;
            this.lbKQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQT.ForeColor = System.Drawing.Color.Red;
            this.lbKQT.Location = new System.Drawing.Point(271, 209);
            this.lbKQT.Name = "lbKQT";
            this.lbKQT.Size = new System.Drawing.Size(20, 29);
            this.lbKQT.TabIndex = 0;
            this.lbKQT.Text = ".";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtTraCuuMaSP);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbKQT);
            this.Controls.Add(this.lbTinhTrangThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraCuuMaSP;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtNgaySX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbTinhTrangThem;
        private System.Windows.Forms.Label lbKQT;
    }
}