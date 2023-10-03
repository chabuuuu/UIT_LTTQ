using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyNgoaiLe_ThrowTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            if (s == null)
            {
                throw (new ArgumentNullException());
            }
            Console.Write("The string s is null");
            // not executed
            Console.ReadKey();
        }
    }
}
