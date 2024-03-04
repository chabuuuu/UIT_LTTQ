using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1_SoNgayCuaThang
{
    internal class Program
    {   
        static public int DayOfMonth(int month, int year)
        {
            int result;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                result = 31;
                return result;
            }
            else
            {
                if (month == 2)
                {
                    if (year % 400 == 0 || (year % 4 == 0 & year % 100 != 0))
                    {
                        result = 29;
                        return result;
                    }
                    result = 28;
                    return result;
                }
                result = 30;
                return result;
            }
        }

        static void Main(string[] args)
        {
            int day, month, year;
            Console.WriteLine("Nhap nam: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("So ngay cua thang: ");
            day = DayOfMonth(month, year);
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}
