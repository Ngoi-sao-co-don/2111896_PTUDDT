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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtHoVaTen.Text;
            string s1 = "";
            string s2 = "";
            Bai3_Cau3.TachChuoi(hoVaTen, ref s1, ref s2);
            if (rdTachChuoi.Checked)
                lbKQ.Text = "Họ: " + s1.PadRight(20) + "Tên: " + s2;
            if (rdSoLienTiep.Checked)
                lbKQ.Text = KT_SoLienTiep(int.Parse(txtN1.Text), int.Parse(txtN2.Text));
        }

        private string KT_SoLienTiep(int n1, int n2)
        {
            bool kq = Bai3_Cau3.ThuTu(n1, n2);
            if (kq)
                return n1 + " và " + n2 + " là hai số liên tiếp";
            else
                return n1 + " và " + n2 + " không phải là hai số liên tiếp";
        }
    }
}
