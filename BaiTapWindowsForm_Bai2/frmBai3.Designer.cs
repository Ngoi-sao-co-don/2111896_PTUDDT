namespace BaiTapWindowsForm_Bai2
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
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.RdNoiChuoi = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ: ";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(296, 68);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(170, 22);
            this.txtHo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập tên: ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(296, 102);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(170, 22);
            this.txtTen.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập số n: ";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(296, 137);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(170, 22);
            this.txtSoN.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdNoiChuoi);
            this.groupBox1.Controls.Add(this.rdGiaiThua);
            this.groupBox1.Location = new System.Drawing.Point(214, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(7, 31);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(107, 20);
            this.rdGiaiThua.TabIndex = 0;
            this.rdGiaiThua.TabStop = true;
            this.rdGiaiThua.Text = "Tính giai thừa";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // RdNoiChuoi
            // 
            this.RdNoiChuoi.AutoSize = true;
            this.RdNoiChuoi.Location = new System.Drawing.Point(7, 57);
            this.RdNoiChuoi.Name = "RdNoiChuoi";
            this.RdNoiChuoi.Size = new System.Drawing.Size(84, 20);
            this.RdNoiChuoi.TabIndex = 0;
            this.RdNoiChuoi.TabStop = true;
            this.RdNoiChuoi.Text = "Nối chuỗi";
            this.RdNoiChuoi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả: ";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(352, 312);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(20, 29);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(388, 189);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(78, 100);
            this.btnKetQua.TabIndex = 0;
            this.btnKetQua.Text = "Kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdNoiChuoi;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Button btnKetQua;
    }
}