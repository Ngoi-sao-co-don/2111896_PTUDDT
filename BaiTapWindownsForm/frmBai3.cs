using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindownsForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapA.Text);
            int b = int.Parse(txtNhapb.Text);
            int n = int.Parse(txtNhapN.Text);
            int s = 0;
            if(rdAVaB.Checked)
            {
                TinhToan.CongHaiSo(a, b, ref s);
                lbKetQua.Text = s.ToString();
            }
            if (rd1ToiN.Checked)
                lbKetQua.Text = TinhToan.TongDaySo(n).ToString();   

        }

    }
}
