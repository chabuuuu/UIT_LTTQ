using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoiTaoGiaTriThuocTinh_ThoiGian
{
    public class ThoiGian
    {
        public void ThoiGianHienHanh()
        {
            System.DateTime now = System.DateTime.Now;
            System.Console.WriteLine("\n Hien tai: \t {0}/{1}/{2}{3}:{4}:{5}", now.Day, now.Month, now.Year, now.Hour, now.Minute, now.Second);
            System.Console.WriteLine(" Thoi Gian:\t {0}/{1}/{2}{3}:{4}:{5}", Ngay, Thang, Nam, Gio, Phut, Giay);
        }
        public ThoiGian(System.DateTime dt)
        {
            Nam = dt.Year;
            Thang = dt.Month;
            Ngay = dt.Day;
            Gio = dt.Hour;
            Phut = dt.Minute;
            Giay = dt.Second;
        }
        public ThoiGian(int Year, int Month, int Date, int Hour, int Minute)
        {
            Nam = Year;
            Thang = Month;
            Ngay = Date;
            Gio = Hour;
            Phut = Minute;
        }
        private int Nam;
        private int Thang;
        private int Ngay;
        private int Gio;
        private int Phut;
        private int Giay;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = DateTime.Now;
            ThoiGian t1 = new ThoiGian(currentTime);
            t1.ThoiGianHienHanh();
            ThoiGian t2 = new ThoiGian(2001, 7, 3, 10, 5);
            t2.ThoiGianHienHanh();
            System.Console.ReadKey();
        }
    }
}
