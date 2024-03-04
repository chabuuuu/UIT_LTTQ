using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal delegate void TextChanged();

namespace AnonymousMethodExample_TextChanged
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
            /*
            Thay vì khai báo một event như sau
            person.TextChanged += new TextChanged(person_TextChanged);
            Event đó trỏ tới method
            private static void person_TextChanged()
            {
            Console.WriteLine("Event Called");
            }
            Bây giờ với tính năng anonymous method, ta có thể đơn giản hóa như 
            sau
            */
            person.TextChanged += delegate ()
            {
                Console.WriteLine("Event Called");
            };
            person.TextChanged -= delegate ()
            {
                Console.WriteLine("Event Called");
            };
            Console.ReadKey();
        }
        private static void person_TextChanged()
        {
            Console.WriteLine("Event Called");
        }
    }
}
