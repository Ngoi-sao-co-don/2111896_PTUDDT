using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai3
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        public long CongViecCong(int n)
        {
            int kq = 0;
            for(int i = 1; i <= n; i++)
            {
                kq += i;
            }
            return kq;
        }

        public long CongViecGiaiThua(int n)
        {
            int kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtbxN.Text);
            if (rdTinhTong.Checked)
                lbKQ.Text = CongViecCong(n).ToString();
            if (rdGiaiThua.Checked)
                lbKQ.Text = CongViecGiaiThua(n).ToString();
        }
    }
}
