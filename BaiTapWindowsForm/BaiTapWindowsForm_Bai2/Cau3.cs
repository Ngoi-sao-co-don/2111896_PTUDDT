using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai2
{
    internal class Cau3
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaiThua(int n)
        {
            long kq = 1;
            if(n <= 0)
            {
                return 0;
            }    
            for(int i = 1; i<= n; i++)
            {
                kq *= i;
            }
            return kq; 
        }
    }
}
