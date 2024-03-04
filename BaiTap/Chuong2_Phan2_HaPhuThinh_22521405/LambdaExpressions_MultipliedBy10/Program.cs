using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
public delegate int MyDelegate(int n);


namespace LambdaExpressions_MultipliedBy10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Anonymous method that returns the argument multiplied by 10:
            MyDelegate Obj1 = new MyDelegate(delegate (int
           n) { return n * 10; });
            // Display the result:
            Console.WriteLine("The value using an anonymous method is: {0}", Obj1(5));
            // Using lambda expression to do the same job:
            MyDelegate Obj2 = (int n) => n * 10;
            // Display the result:
            Console.WriteLine("The value using a lambda expression is: {0}", Obj2(5));
            Console.ReadLine();
        }
    }
}
