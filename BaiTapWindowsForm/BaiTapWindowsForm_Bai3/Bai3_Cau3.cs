using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai3
{
    internal class Bai3_Cau3
    {
        public static void TachChuoi(string hoten, ref string s1, ref string s2)
        {
            string []mangTen = hoten.Split(' ');
            s1 = mangTen[0];
            s2 = string.Join(" ", mangTen.Skip(1));
        }

        public static bool ThuTu(int n1, int n2)
        {
            if ((n1 - n2 == 1) || (n2 - n1 == 1))
                return true;
            else 
                return false;
        }
    }
}
