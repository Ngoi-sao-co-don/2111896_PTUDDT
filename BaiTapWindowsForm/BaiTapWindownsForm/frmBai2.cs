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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private int KT_GiaTien(string hangHoa)
        {
            int giaTien = 0;
            switch (hangHoa)
            {
                case "Chuột":
                    giaTien = 100000;
                    break;
                case "Bàn phím":
                    giaTien = 150000;
                    break;
                case "Máy in":
                    giaTien = 2000000;
                    break;
            }
            return giaTien;
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = KT_GiaTien(cbbTenHang.Text).ToString();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            int tongTien = 0;
            if(rdTienMat.Checked)
            {
                tongTien = donGia * soLuong;
            }
            if (rdChuyenKhoan.Checked)
            {
                tongTien = (donGia * soLuong) - ((donGia * soLuong) * 5 / 100);
            }
            lbTongTien.Text = tongTien.ToString() + " Đồng";
        }
    }
}
