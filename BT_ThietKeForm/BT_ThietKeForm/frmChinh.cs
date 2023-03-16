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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsmBai1_Click(object sender, EventArgs e)
        {
            var frm1 = new frmBai1();
            frm1.ShowDialog();
        }

        private void tsmBai2_Click(object sender, EventArgs e)
        {
            var frm2 = new frmBai2();
            frm2.ShowDialog();
        }

        private void tsmBai3_Click(object sender, EventArgs e)
        {
            var frm3 = new frmBai3();
            frm3.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm4 = new frmBai4();
            frm4.ShowDialog();
        }
    }
}
