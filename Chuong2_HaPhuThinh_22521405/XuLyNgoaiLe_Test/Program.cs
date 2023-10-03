using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace XuLyNgoaiLe_Test
{
    internal class Program
    {
        public static void Main()
{
Console.WriteLine("Enter Main....");
Program t = new Program();
t.Func1();
Console.WriteLine("Exit Main...");
}
public void Func1()
{
Console.WriteLine("Enter Func1...");
Func2();
Console.WriteLine("Exit Func1...");
}
public void Func2()
{
    Console.WriteLine("Enter Func2...");
    throw new System.Exception();
    Console.WriteLine("Exit Func2...");
    }
    }
}
