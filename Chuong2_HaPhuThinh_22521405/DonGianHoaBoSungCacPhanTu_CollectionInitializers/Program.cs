using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DonGianHoaBoSungCacPhanTu_CollectionInitializers
{
    public class Person
    {
        string _Name;
        //Sua lai khai bao ro rang Interest la mot List kieu string
        List<string> _Intersets = new List<string>();
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public List<string> Interests
        {
            get { return _Intersets; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Thay vì viết:
                 List PersonList = new List();
                 Person p1 = new Person();
                 p1.Name = "Mony Hamza";
                 p1.Interests.Add("Reading");
                 p1.Interests.Add("Running");
                 PersonList.Add(p1);
                 Person p2 = new Person();
                 p2.Name = "John Luke";
                 p2.Interests.Add("Swimming");
                 PersonList.Add(p2);
            */
            //Ta có thể viết:
            var PersonList = new List<Person>{
                new Person{ Name = "Mony Hamza", Interests = { "Reading", "Running" } },
                new Person { Name = "John Luke", Interests = { "Swimming"}}
            };
            foreach (var Person in PersonList)
            {
                Console.WriteLine(Person.Name);
                foreach (var interest in Person.Interests){
                    Console.Write(interest + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
