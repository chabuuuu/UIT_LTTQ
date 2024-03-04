using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so loai gia suc: ");
            int count = int.Parse(Console.ReadLine());
            if (count > 3) { return; }
            GiaSuc[] listGiaSuc = new GiaSuc[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Nhap loai gia suc: 1.Bo 2.De 3.Cuu");
                int type = int.Parse(Console.ReadLine());
                int ammount;
                switch (type)
                {
                    case 1:
                        Console.WriteLine("Nhap so luong bo: ");
                        ammount = int.Parse(Console.ReadLine());
                        listGiaSuc[i] = new Bo(ammount);
                        break;
                    case 2:
                        Console.WriteLine("Nhap so luong de: ");
                        ammount = int.Parse(Console.ReadLine());
                        listGiaSuc[i] = new De(ammount);
                        break;
                    case 3:
                        Console.WriteLine("Nhap so luong cuu: ");
                        ammount = int.Parse(Console.ReadLine());
                        listGiaSuc[i] = new Cuu(ammount);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("Nhung tieng gia suc keu: ");
            for (int i = 0; i < count; i++)
            {
                listGiaSuc[i].keu();
            }
            Console.WriteLine("Tong luong sua thu duoc: ");
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += listGiaSuc[i].milk;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
