using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            if(rbDo.Checked)
            {
                pbXe.Image = Properties.Resources.đỏ;
                txtDonGia.Text = "21000";
            }  

        }

        private void rxXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbXanh.Checked)
            {
                pbXe.Image = Properties.Resources.xanh;
                txtDonGia.Text = "22000";
            }
        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrang.Checked)
            {
                pbXe.Image = Properties.Resources.trắng;
                txtDonGia.Text = "20000";
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
            lbTongTien.Text = soTien.ToString();
        }
    }
}
