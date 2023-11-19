using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi ho ten: ");
            string text = Console.ReadLine();
            string[] textArray = text.Split(' ');
            for (int i = 0; i < textArray.Length; i++)
            {

                textArray[i] = char.ToUpper(textArray[i][0]) + textArray[i].Substring(1).ToLower();

            }

            foreach (string s  in textArray)
            {
                Console.Write(s);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
        
    }
}
