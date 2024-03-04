using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemMethodMaKhongLamAnhHuongCauTruc_ExtensionMethods
{
    sealed class Person
    {
        public string Name { get; set; }
    }
    static class Utility
    {
        //Extension method thêm vào lớp Person
        static public void ExMethod(this Person person)
        {
            person.Name = "John";
            Console.WriteLine("Name: " + person.Name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Tạo instance của lớp Person
            var person = new Person();
            //Gọi Extension Method 
            person.ExMethod();
            Console.ReadKey();
        }
    }
}
