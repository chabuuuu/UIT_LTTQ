using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoiTaoGiaTrIChoThuocTinh_ObjectIntializer
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "John", Age = 25 };
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
            Console.ReadKey();
        }
    }
}
