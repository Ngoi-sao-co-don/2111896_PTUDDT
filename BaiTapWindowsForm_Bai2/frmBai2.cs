using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai2
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(txtSoThuNhat.Text);
            float soThuHai = float.Parse(txtSoThuHai.Text);
            if(rdCong.Checked)
                    lbKetQua.Text = (soThuNhat + soThuHai).ToString();
            if (rdTru.Checked)
                    lbKetQua.Text = (soThuNhat - soThuHai).ToString();
            if (rdNhan.Checked)
                    lbKetQua.Text = (soThuNhat * soThuHai).ToString();
            if (rdChia.Checked)
                    lbKetQua.Text = (soThuNhat / soThuHai).ToString();
        }
    }
}
