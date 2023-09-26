using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoiTaoLop_ThoiGian
{
    public class ThoiGian
    {
        public void ThoiGianHienHanh()
        {
            Console.WriteLine("Hien thi thoi gian hien hanh");
            //Các biến thành viên
            int Nam;
            int Thang;
            int Ngay;
            int Gio;
            int Phut;
            int Giay;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThoiGian t = new ThoiGian();
            t.ThoiGianHienHanh();
            //Press any key to continue
            System.Console.ReadKey();
        }
    }
}
