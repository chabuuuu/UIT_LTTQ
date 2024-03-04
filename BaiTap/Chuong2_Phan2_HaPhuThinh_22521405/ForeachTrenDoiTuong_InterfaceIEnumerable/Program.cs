using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForeachTrenDoiTuong_InterfaceIEnumerable
{
    public class Person
    {
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
        public string firstName;
        public string lastName;
    }
    public class People : IEnumerable
    {
        private Person[] _people;
        // Khởi tạo
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;
        int position = -1;
        // Khởi tạo
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        // Tăng vị trí
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                 new Person("John", "Smith"),
                 new Person("Jim", "Johnson"),
                 new Person("Sue", "Rabon"),
            };
            People peopleList = new People(peopleArray);
            // liệt kê danh sách dùng foreach
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);
            PeopleEnum peopleEnum = peopleList.GetEnumerator();
            peopleEnum.Reset();
            // lấy người đầu tiên trong danh sách
            peopleEnum.MoveNext();
            Person firstPerson = peopleEnum.Current;
            Console.WriteLine("First Person: {0} {1}",
           firstPerson.firstName, firstPerson.lastName);
            Console.ReadKey();
        }

    }
}
