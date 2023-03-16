using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai4
{
    internal class Bai4_Cau3
    {
        public static void ChaoHoi(string hoTen, string gioiTinh, ref string kq)
        {
            if (gioiTinh == "Nam" || gioiTinh == "nam")
                kq = "Chào ông " + hoTen;
            else
                kq = "Chào bà " + hoTen;
        }

        public static int UCLN(int m, int n)
        {
            if (n == 0)
                return m;
            else
                return UCLN(n, m % n);
        }

    }
}
