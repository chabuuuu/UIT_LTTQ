using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ConsoleApp1
{   
    public class Person
    {
        string _name;
        List<String> _interest;
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public List<String> interest
        {
            get { return this._interest; }
            set
            {
                this._interest = value;

            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {       
            Person person = new Person { name = "Thinh", interest = { "mot", "hai" } };
            Console.WriteLine(person.name);
            Console.WriteLine(person.interest[0]);
            Console.ReadKey();
        }
    }
}
