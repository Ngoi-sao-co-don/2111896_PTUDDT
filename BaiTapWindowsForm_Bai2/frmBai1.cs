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
    public partial class frmBai1 : Form
    {
        List<ThietBi> listThietBi = new List<ThietBi>();
        List<int> danhSachViTriTBMua = new List<int>();//list danh sách thiết bị mà khách hàng mua để tính tổng tiền
        public frmBai1()
        {
            InitializeComponent();
        }


        private void frmBai1_Load(object sender, EventArgs e)
        {
            listThietBi.Add(new ThietBi("CC01", "Chuột", "Việt Nam", 100000, 10));
            listThietBi.Add(new ThietBi("BP02", "Bàn phím 1", "Mỹ", 600000, 10));
            listThietBi.Add(new ThietBi("MH01", "Màn hình", "Nga", 5000000, 10));
            listThietBi.Add(new ThietBi("PC01", "PC", "Trung Quốc", 9000000, 10));
            listThietBi.Add(new ThietBi("BP01", "Bàn phím 2", "Ukraina", 400000, 10));
            listThietBi.Add(new ThietBi("LT01", "LapTop Acer", "NK", 9500000, 10));

            foreach (var item in listThietBi)
            {
                cbbThietBi.Items.Add(item.TenThietBi);
            }
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text == "")
            {
                listThietBi[ViTriTB(cbbThietBi.Text)].SoLuong = 1;
            }
            else
            {
                int sl = int.Parse(txtSoLuong.Text);
                listThietBi[ViTriTB(cbbThietBi.Text)].SoLuong = sl;
            }
            lstbThietBi.Items.Add(listThietBi[ViTriTB(cbbThietBi.Text)].HienThi());
            danhSachViTriTBMua.Add(ViTriTB(cbbThietBi.Text));
        }

        private int ViTriTB(string tenTB)
        {
            int vt = 0;
            for (int i = 0; i < listThietBi.Count(); i++)
            {
                if(listThietBi[i].TenThietBi == tenTB)
                {
                    vt = i;
                    break;
                }
            } 
            return vt;
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            var item = lstbThietBi.SelectedItem;
            int index = lstbThietBi.SelectedIndex;
            lstbThietBi.Items.Remove(item);
            danhSachViTriTBMua.RemoveAt(index);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            float tongTien = 0;
            for(int i = 0; i <= listThietBi.Count(); i++)
            {
                if (danhSachViTriTBMua.Contains(i))
                {
                    tongTien += listThietBi[i].ThanhTien();
                }
            }  
            lbTongTien.Text = string.Format("{0:N0}", tongTien) + " Đồng";
        }
    }
}
