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
    public partial class frmBai1 : Form
    {
        List<NhanVien> listNV = new List<NhanVien>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            listNV.Add(new NhanVien("N001", "Nguyễn Tân Tiến", DateTime.Parse("08/20/2003"), 2, 3));
            listNV.Add(new NhanVien("N002", "Nguyễn Bảo Khanh", DateTime.Parse("04/22/2002"), 2, 3));
            listNV.Add(new NhanVien("N003", "Nguyễn Xuân Tường An", DateTime.Parse("02/20/2003"), 2, 3));
            listNV.Add(new NhanVien("N004", "Trần Phương Thái", DateTime.Parse("09/20/2002"), 3, 3));
            listNV.Add(new NhanVien("N005", "Nguyễn Minh Thành", DateTime.Parse("08/05/2000"), 3, 4));
            listNV.Add(new NhanVien("N006", "Nguyễn Công Anh Tú", DateTime.Parse("03/16/2002"), 2, 3));
            listNV.Add(new NhanVien("N007", "Nguyễn Quốc Thắng", DateTime.Parse("05/16/2000"), 2, 3));
            listNV.Add(new NhanVien("N008", "Nguyễn Hoàng Bảo Long", DateTime.Parse("01/16/2003"), 2, 3));
        }

        private void XuatTTNV(string maNV)
        {
            foreach (var item in listNV)
            {
                if(item.MaNV == maNV)
                lbTTNV.Text = item.HienThi();
            }    
        }

        private void XuatLuong(string maNV)
        {
            foreach(var item in listNV)
            {
                if(item.MaNV == maNV)
                {
                    lbTTNV.Text = item.HienThi() + string.Format("{0:N0}", item.TongLuong());
                    break;
                }
            }    
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if(rdTTNV.Checked)
                   XuatTTNV(txtMaNV.Text); 
            if(rdLuong.Checked)
                   XuatLuong(txtMaNV.Text);
        }


    }
}
