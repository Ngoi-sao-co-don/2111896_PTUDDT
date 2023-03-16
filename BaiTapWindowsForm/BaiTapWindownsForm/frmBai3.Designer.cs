namespace BaiTapWindownsForm
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
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapb = new System.Windows.Forms.TextBox();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAVaB = new System.Windows.Forms.RadioButton();
            this.rd1ToiN = new System.Windows.Forms.RadioButton();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập b = ";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(276, 78);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(169, 22);
            this.txtNhapA.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập n = ";
            // 
            // txtNhapb
            // 
            this.txtNhapb.Location = new System.Drawing.Point(276, 112);
            this.txtNhapb.Name = "txtNhapb";
            this.txtNhapb.Size = new System.Drawing.Size(169, 22);
            this.txtNhapb.TabIndex = 1;
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(276, 143);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(169, 22);
            this.txtNhapN.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAVaB);
            this.groupBox1.Controls.Add(this.rd1ToiN);
            this.groupBox1.Location = new System.Drawing.Point(276, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý";
            // 
            // rdAVaB
            // 
            this.rdAVaB.AutoSize = true;
            this.rdAVaB.Location = new System.Drawing.Point(6, 34);
            this.rdAVaB.Name = "rdAVaB";
            this.rdAVaB.Size = new System.Drawing.Size(123, 20);
            this.rdAVaB.TabIndex = 0;
            this.rdAVaB.TabStop = true;
            this.rdAVaB.Text = "Tính tổng a và b";
            this.rdAVaB.UseVisualStyleBackColor = true;
            // 
            // rd1ToiN
            // 
            this.rd1ToiN.AutoSize = true;
            this.rd1ToiN.Location = new System.Drawing.Point(6, 60);
            this.rd1ToiN.Name = "rd1ToiN";
            this.rd1ToiN.Size = new System.Drawing.Size(120, 20);
            this.rd1ToiN.TabIndex = 0;
            this.rd1ToiN.TabStop = true;
            this.rd1ToiN.Text = "Tính tổng 1 tới n";
            this.rd1ToiN.UseVisualStyleBackColor = true;
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(332, 307);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(112, 38);
            this.btnTinhToan.TabIndex = 3;
            this.btnTinhToan.Text = "Tính toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả là: ";
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(353, 378);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(21, 29);
            this.lbKetQua.TabIndex = 0;
            this.lbKetQua.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.txtNhapb);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapb;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAVaB;
        private System.Windows.Forms.RadioButton rd1ToiN;
        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKetQua;
    }
}