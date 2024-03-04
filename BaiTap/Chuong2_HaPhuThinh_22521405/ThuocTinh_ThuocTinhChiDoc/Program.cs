using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuocTinh_ThuocTinhChiDoc
{
    class Student
    {
        protected DateTime _Birthday;

        public int Age //Thuoc tinh chi doc
        {
            get
            {
                return DateTime.Today.Year - _Birthday.Year;
            }
        }
        public void SetBirthday(DateTime birthday)
        {
            this._Birthday = birthday;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            DateTime birthday = new DateTime(2004, 03, 03);
            s.SetBirthday(birthday);
            Console.WriteLine(s.Age);
            Console.ReadLine();
        }
    }
}
