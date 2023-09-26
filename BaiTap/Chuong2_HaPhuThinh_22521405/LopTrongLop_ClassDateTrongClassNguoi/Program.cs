using LopTrongLop_ClassDateTrongClassNguoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopTrongLop_ClassDateTrongClassNguoi
{
        class Nguoi
    {
        public class Date
        {
            private int ngay;
            private int thang;
            public Date() { ngay = 1; thang = 1; }
            public void Xuat()
                {
                    Console.WriteLine(ngay + "/" +
            thang);
                }
        }
        private string ten;
        private string ho;
        private Date ns;
        public Nguoi()
        {
            ten = "An"; ho = "Nguyen Van"; ns = new
        Date();
        }
        public void Xuat()
        {
            ns.Xuat(); Console.WriteLine(ho + " " + ten);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Nguoi a = new Nguoi();
            a.Xuat();
            Nguoi.Date ns = new Nguoi.Date();
            ns.Xuat();
            Console.ReadKey();
        }
    }
}
