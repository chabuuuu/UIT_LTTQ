using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4_PhanSo
{
    class PhanSo
    {
        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            if (a.mau == b.mau)
            {
                return new PhanSo(a.tu + b.tu, a.mau);
            }
            int tu1 = a.tu * b.mau;
            int tu2 = b.tu * a.mau;
            return new PhanSo(tu1 + tu2, a.mau * b.mau);
        }
        public static PhanSo operator - (PhanSo a, PhanSo b)
        {
            if (a.mau == b.mau)
            {
                return new PhanSo(a.tu - b.tu, a.mau);
            }
            int tu1 = a.tu * b.mau;
            int tu2 = b.tu * a.mau;
            return new PhanSo(tu1 - tu2, a.mau * b.mau);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int newTu = a.tu * b.tu;
            int newMau = a.mau * b.mau;
            int gcd = GCD(newMau, newTu);
            return new PhanSo(newTu/gcd, newMau/gcd);
        }
        public PhanSo(int tu, int mau) {
            int gcd = GCD(tu, mau);
            this.tu = tu/gcd;
            this.mau = mau/gcd;
        }
        public void xuat()
        {
            Console.WriteLine("{0}/{1}", this.tu, this.mau);
        }
        private int tu;
        private int mau;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int tu, mau;
            Console.WriteLine("Nhap phan so a: ");
            Console.WriteLine("Nhap tu: ");
            tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau: ");
            mau = int.Parse(Console.ReadLine());
            PhanSo a = new PhanSo(tu, mau);
            Console.WriteLine("Phan so a: ");
            a.xuat();
            Console.WriteLine("Nhap phan so b: ");
            Console.WriteLine("Nhap tu: ");
            tu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau: ");
            mau = int.Parse(Console.ReadLine());
            PhanSo b = new PhanSo(tu, mau);
            Console.WriteLine("Phan so b: ");
            b.xuat();
            Console.WriteLine("Tong a + b: ");
            PhanSo sum = a + b;
            sum.xuat();
            Console.WriteLine("Hieu a - b: ");
            PhanSo hieu = a - b;
            hieu.xuat();
            Console.WriteLine("Tich a * b: ");
            PhanSo tich = a * b;
            tich.xuat();
            Console.WriteLine("Thuong a / b: ");
            PhanSo thuong = a - b;
            thuong.xuat();
            Console.ReadKey();
        }
    }
}
