using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBindingExample_Operator
{
    internal class Program
    {
        static dynamic Sum(dynamic obj1, dynamic obj2)
        {
            return obj1 + obj2;
        }
        static void Main(string[] args)
        {
            //Dynamic hỗ trợ tốt các Operator +, -, *, /
            Console.WriteLine(Sum(5, 10));
            Console.WriteLine(Sum(5.2, 10.2));
            Console.ReadKey();
        }
    }
}
