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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string gioiTinh = txtGioiTinh.Text;
            int soThuNhat = int.Parse(txtSoThuNhat.Text);
            int soThuHai = int.Parse(txtSoThuHai.Text);
            string cauChao = "";
            Bai4_Cau3.ChaoHoi(ten, gioiTinh, ref cauChao);
            MessageBox.Show(cauChao);
            lbKQ.Text = Bai4_Cau3.UCLN(soThuNhat, soThuHai).ToString();
        }
    }
}
