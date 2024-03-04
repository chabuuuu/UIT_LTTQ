using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2_MangSo
{   
    class SoluTion
    {
        public SoluTion()
        {
            n = 0;
            arr = new int[n];
        }
        static bool isPrime(int number)
        {
            for (int i = 2; i * i <= number; i++)
                if (number % i == 0) return false;
            return number > 1;
        }
        static bool isCP(int number)
        {
            int sqrt = (int)Math.Sqrt(number);
            if (sqrt * sqrt == number) return true;
            return false;
        }
        public void nhap()
        {
            Console.WriteLine("Nhap n: ");
            this.n = int.Parse(Console.ReadLine());
            this.arr = new int[n];
            Console.WriteLine("Nhap day so: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void xuat()
        {
            Console.WriteLine("Xuat mang...");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public int tinhTongSoLe()
        {
            int sum = 0;
            foreach(int i in arr)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public int demSoNguyenTo()
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (isPrime(i))
                {
                    count++;
                }
            }
            return count;
        }
        public int soChinhPhuongNhoNhat()
        {
            int[] sortArray = arr;
            Array.Sort(sortArray);
            foreach (int i in sortArray)
            {
                if (isCP(i))
                {
                    return i;
                }
            }
            return -1;

        }
        private int n;
        private int[] arr;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SoluTion solotuion = new SoluTion();
            solotuion.nhap();
            Console.WriteLine("Tong cac so le cua mang: " + solotuion.tinhTongSoLe());
            Console.WriteLine("Dem so nguyen to: " + solotuion.demSoNguyenTo());
            Console.WriteLine("So chinh phuong nho nhat: " + solotuion.soChinhPhuongNhoNhat());
            Console.ReadKey();
        }
    }
}
