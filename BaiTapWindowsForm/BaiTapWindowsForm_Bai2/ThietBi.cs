using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }


        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, float donGia, int soLuong)
        {
            this.MaThietBi = maThietBi;
            this.TenThietBi = tenThietBi;
            this.NuocSanXuat = nuocSanXuat;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public float ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            string s;
            s = MaThietBi.PadRight(30) + TenThietBi.PadRight(30) + NuocSanXuat.PadRight(30) + string.Format("{0:N0}", DonGia).PadRight(30) + SoLuong;
            return s;
        }
    }
}
