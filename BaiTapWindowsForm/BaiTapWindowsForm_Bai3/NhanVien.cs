using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm_Bai3
{
    internal class NhanVien
    {
        /*  1) Khai báo một lớp đối tượng NhanVien gồm:
          - Các thuộc tính: MaNV, HoTen, NgaySinh, HeSoLuong, HeSoPhuCap.
          - Hàm khởi tạo có tham số.
          - Các phương thức:
          + TongLuong: tính tổng lương của nhân viên.
          Hướng dẫn: Tổng lương = (hệ số lương + phụ cấp phụ cấp) x 1.150.000;
          + HienThi: hiển thị tất cả thông tin của một nhân viên.*/
        public string MaNV { get; set; }
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }
        public int HeSoLuong { get; set; }
        public int HeSoPhuCap { get; set; }
        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, int heSoLuong, int heSoPhuCap)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.HeSoLuong = heSoLuong;
            this.HeSoPhuCap = heSoPhuCap;
        }

        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        public string HienThi()
        {
            return string.Format("{0} {1} {2} {3} {4}" ,MaNV.PadRight(25), HoTen.PadRight(25), 
                NgaySinh.ToString().PadRight(25), HeSoLuong.ToString().PadRight(25), 
                HeSoPhuCap.ToString().PadRight(20));
        }
    }
}
