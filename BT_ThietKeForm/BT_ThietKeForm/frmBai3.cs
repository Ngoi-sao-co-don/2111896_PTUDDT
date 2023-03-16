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
    public partial class frmBai3 : Form
    {
        List<string> listTuMoi = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            var tuMoi = txtTuMoi.Text;
            var nghiaCuaTu = txtNghiaCuaTu.Text;
            lbTraTu.Items.Add(tuMoi);
            listTuMoi.Add(nghiaCuaTu);
            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaCuaTu.Text = "";
            lbTraTu.SelectedIndex = lbTraTu.Items.Count - 1;
        }

        private void lbTraTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = lbTraTu.SelectedIndex;
            txtNghia.Text = listTuMoi[stt];
        }
    }
}
