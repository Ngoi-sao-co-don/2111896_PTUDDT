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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = lb1.SelectedItem;
            lb2.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = lb2.SelectedItem;
            lb2.Items.Remove(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (var item in lb2.Items)
            {
                
                soTien += KTHangHoa(item.ToString().Trim());
            }
            lbThanhToan.Text = soTien.ToString() + " Đồng";
        }


        public int KTHangHoa(string hangHoa)
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
                case "USB Kingmax":
                    giaTien = 200000;
                    break;
            }
            return giaTien;
        }

    }
}
