using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai: ");
            float chieudai = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            float chieurong = float.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(chieudai, chieurong);
            Console.WriteLine("Dien tich: " + rectangle.CalculateArea());
            Console.WriteLine("Chu vi: " + rectangle.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
