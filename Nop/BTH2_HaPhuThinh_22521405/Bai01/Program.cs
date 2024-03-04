using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap duong dan thu muc: ");
            string path = Console.ReadLine();
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                string[] subfolder = Directory.GetDirectories(path);

                if (files.Length != 0 )
                {
                    Console.WriteLine();
                    for (int i = 0; i < files.Length; i++)
                    {
                        Console.WriteLine(files[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Khong co tap tin nao trong thu muc");
                }

                if (subfolder.Length != 0)
                {
                    Console.WriteLine();
                    for (int i = 0; i < subfolder.Length; i++)
                    {
                        Console.WriteLine(subfolder[i]);
                    }
                }

                else
                {

                    Console.WriteLine("Khong co thu muc con nao");

                }
            }
            else
            {
                Console.WriteLine("Khong tim thay thu muc");
            }
            Console.ReadLine();
        }
    }
}
