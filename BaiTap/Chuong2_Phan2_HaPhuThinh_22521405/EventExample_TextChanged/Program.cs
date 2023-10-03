using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal delegate void TextChanged();

namespace EventExample_TextChanged
{
    class Person
    {
        public event TextChanged TextChanged
        {
            add { Console.WriteLine("Event added"); }
            remove { Console.WriteLine("Event removed"); }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.TextChanged += new
            TextChanged(person_TextChanged);
            person.TextChanged -= new
            TextChanged(person_TextChanged);
            Console.ReadKey();
        }
        private static void person_TextChanged()
        {
            Console.WriteLine("Event Called");
        }
    }
}
