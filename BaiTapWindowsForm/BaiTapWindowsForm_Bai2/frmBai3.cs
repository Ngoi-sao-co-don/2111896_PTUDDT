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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            int n = int.Parse(txtSoN.Text);
            string s = "";
            if (rdGiaiThua.Checked)
                 lbKetQua.Text = Cau3.GiaiThua(n).ToString(); ;
            if (RdNoiChuoi.Checked)
            {
                Cau3.NoiChuoi(ho, ten, ref s);
                lbKetQua.Text = s;
            }    

        }
    }
}
