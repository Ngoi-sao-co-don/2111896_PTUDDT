using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm_Bai4
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            float diemLT = float.Parse(txtLyThuyet.Text);
            float diemTH = float.Parse(txtThucHanh.Text);
            if((diemLT<0) ||(diemTH<0) || (diemLT>10) || (diemTH > 10))
            {
                lbKQ.Text = "Thông tin bạn nhập đã bị lỗi!";
                txtLyThuyet.Text = "";
                txtThucHanh.Text = "";
                txtLyThuyet.Focus();
            }    
            else
                lbKQ.Text = XepLoai_HocTap(diemLT, diemTH);
        }

        private string XepLoai_HocTap(float diemLT, float diemTH)
        {
            string xepLoai = "";
            float diemTrungBinh = (diemLT + diemTH) / 2;
            if((diemLT < 5) || (diemTH < 5))
            {
                xepLoai = "Yếu";
            }    
            else if(diemTrungBinh < 7)
            {
                xepLoai = "Trung bình";
            }    
            else if(diemTrungBinh>=7 && diemTrungBinh < 8)
            {
                xepLoai = "Khá";
            }
            else if(diemTrungBinh >= 8 && diemTrungBinh < 9)
            {
                xepLoai = "Giỏi";
            }    
            else if(diemTrungBinh >= 9)
            {
                xepLoai = "Xuất sắc";
            }
            return xepLoai;
        }
    }
}
