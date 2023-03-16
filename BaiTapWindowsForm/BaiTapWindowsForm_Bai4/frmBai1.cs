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
    public partial class frmBai1 : Form
    {
        List<SanPham> listSP = new List<SanPham>();
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
        }

        private SanPham ThemSP(string maSP, string tenSP, string loaiSP, DateTime ngaySX)
        {
            SanPham sp = new SanPham();
            sp.MaSP = maSP;
            sp.TenSP = tenSP;
            sp.LoaiSP = loaiSP;
            sp.NgaySX = ngaySX;
            return sp;
        }

        private bool KT_List(string maSP)
        {
            foreach(var item in listSP)
            {
                if(item.MaSP == maSP)
                {
                    return false;
                    break;
                }    
            }    
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KT_List(txtMaSP.Text))
            {
                listSP.Add(ThemSP(txtMaSP.Text, txtTenSP.Text, txtLoaiSP.Text, DateTime.Parse(txtNgaySX.Text)));
                lbKQT.Text = "Thêm sản phẩm " + txtMaSP.Text + " thành công!";
            }
            else
            {
                lbKQT.Text = "Thêm sản phẩm " + txtMaSP.Text + " thất bại!";
            }
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtLoaiSP.Text = "";
            txtNgaySX.Text = "";
        }



        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            foreach(var item in listSP)
            {
                if(item.MaSP == txtTraCuuMaSP.Text)
                {
                    lbKQ.Text = item.HienThi() +"\t NamHH: "+ item.NamHetHan();
                    break;
                }
                else
                {
                    lbKQ.Text = "Không tìm thấy sản phẩm có mã: <empty>";
                }
            }
        }
    }
}
