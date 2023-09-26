using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoImplementedProperties_ViDuVoiClassEmployee
{
    class Employee
    {
        public int ID { get; private set; } // read-only
        public string FirstName { get; set; }
        public int age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //vi id la thuoc tinh chỉ đọc nên code sau không thể thực hiện:
            //employee.ID = 5;
            employee.FirstName = "Thinh";
            employee.age = 19;
            Console.WriteLine("ID: {0}, Firstname: {1}, Age: {2}",employee.ID, employee.FirstName, employee.age);
            Console.ReadKey();

        }
    }
}
