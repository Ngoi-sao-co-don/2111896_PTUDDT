namespace BaiTapWindowsForm_Bai3
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
            this.txtN = new System.Windows.Forms.Label();
            this.txtbxN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhTong = new System.Windows.Forms.RadioButton();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.AutoSize = true;
            this.txtN.Location = new System.Drawing.Point(197, 42);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(190, 16);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "Nhập một số nguyên dương N: ";
            // 
            // txtbxN
            // 
            this.txtbxN.Location = new System.Drawing.Point(394, 42);
            this.txtbxN.Name = "txtbxN";
            this.txtbxN.Size = new System.Drawing.Size(200, 22);
            this.txtbxN.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTong);
            this.groupBox1.Location = new System.Drawing.Point(394, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc";
            // 
            // rdTinhTong
            // 
            this.rdTinhTong.AutoSize = true;
            this.rdTinhTong.Location = new System.Drawing.Point(7, 22);
            this.rdTinhTong.Name = "rdTinhTong";
            this.rdTinhTong.Size = new System.Drawing.Size(140, 20);
            this.rdTinhTong.TabIndex = 0;
            this.rdTinhTong.TabStop = true;
            this.rdTinhTong.Text = "Tính tổng 1+2+...+N";
            this.rdTinhTong.UseVisualStyleBackColor = true;
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(7, 48);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(144, 20);
            this.rdGiaiThua.TabIndex = 0;
            this.rdGiaiThua.TabStop = true;
            this.rdGiaiThua.Text = "Tính N giai thừa (N!)";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(394, 203);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(151, 44);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kết quả là: ";
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(389, 273);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(18, 26);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = ".";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbxN);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtN;
        private System.Windows.Forms.TextBox txtbxN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTinhTong;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbKQ;
    }
}