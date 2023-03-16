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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "CPU03";
            hh.TenHang = "CPU Intel Core i9 12900k";
            hh.DVT = "Cái";
            hh.SoLuong = 2;
            hh.DonGia = 1050;

            lbTTHH.Text = hh.HienThi();
        }
    }
}
