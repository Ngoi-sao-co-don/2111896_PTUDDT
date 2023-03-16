namespace BaiTapWindowsForm_Bai3
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
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTachChuoi = new System.Windows.Forms.RadioButton();
            this.rdSoLienTiep = new System.Windows.Forms.RadioButton();
            this.btnKT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập họ và tên: ";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(291, 75);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(209, 22);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số thứ nhất: ";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(291, 111);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(209, 22);
            this.txtN1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập số thứ hai:  ";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(291, 145);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(209, 22);
            this.txtN2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSoLienTiep);
            this.groupBox1.Controls.Add(this.rdTachChuoi);
            this.groupBox1.Location = new System.Drawing.Point(160, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phương thức";
            // 
            // rdTachChuoi
            // 
            this.rdTachChuoi.AutoSize = true;
            this.rdTachChuoi.Location = new System.Drawing.Point(7, 22);
            this.rdTachChuoi.Name = "rdTachChuoi";
            this.rdTachChuoi.Size = new System.Drawing.Size(116, 20);
            this.rdTachChuoi.TabIndex = 0;
            this.rdTachChuoi.TabStop = true;
            this.rdTachChuoi.Text = "Tách họ và tên";
            this.rdTachChuoi.UseVisualStyleBackColor = true;
            // 
            // rdSoLienTiep
            // 
            this.rdSoLienTiep.AutoSize = true;
            this.rdSoLienTiep.Location = new System.Drawing.Point(6, 48);
            this.rdSoLienTiep.Name = "rdSoLienTiep";
            this.rdSoLienTiep.Size = new System.Drawing.Size(143, 20);
            this.rdSoLienTiep.TabIndex = 0;
            this.rdSoLienTiep.TabStop = true;
            this.rdSoLienTiep.Text = "Kiểm tra số liên tiếp";
            this.rdSoLienTiep.UseVisualStyleBackColor = true;
            // 
            // btnKT
            // 
            this.btnKT.Location = new System.Drawing.Point(387, 211);
            this.btnKT.Name = "btnKT";
            this.btnKT.Size = new System.Drawing.Size(113, 77);
            this.btnKT.TabIndex = 3;
            this.btnKT.Text = "Kiểm tra";
            this.btnKT.UseVisualStyleBackColor = true;
            this.btnKT.Click += new System.EventHandler(this.btnKT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả: ";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(286, 315);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(20, 29);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.lbKQ);
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
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTachChuoi;
        private System.Windows.Forms.RadioButton rdSoLienTiep;
        private System.Windows.Forms.Button btnKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKQ;
    }
}