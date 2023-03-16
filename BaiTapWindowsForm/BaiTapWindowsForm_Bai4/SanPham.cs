using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai4
{
    internal class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string LoaiSP { get; set; }
        public DateTime NgaySX { get; set; }

        public SanPham()
        {

        }

        public int NamHetHan()
        {
            int namHH = NgaySX.Year + 3;
            return namHH;
        }

        public string HienThi()
        {
            return string.Format("MaSP: {0} TenSP: {1} LoaiSP: {2} NgaySX: {3}", MaSP.PadRight(20), TenSP.PadRight(20), LoaiSP.PadRight(20), NgaySX);
        }
    }
}
