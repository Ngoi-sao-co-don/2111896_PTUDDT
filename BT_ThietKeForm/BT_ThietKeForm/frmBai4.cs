﻿using System;
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
    public partial class frmBai4 : Form
    {
        public frmBai4()
        {
            InitializeComponent();
        }


        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int so;
            for (int i = 0; i < 10; i++)
            {
                so = rnd.Next(1, 100);
                lbSo.Items.Add(so);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtNhapSo.Text);
            foreach (int item in lbSo.Items)
            {
                if (soCanTim == item)
                {
                    labelKetQua.Text = "Tìm thấy";
                    break;
                }
                else
                {
                    labelKetQua.Text = "Không tìm thấy";
                }
            }

        }




    }
}
