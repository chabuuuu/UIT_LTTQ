using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample_Employee
{
    public class Employee
    {
        private int empID;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList empArray = new ArrayList();
            ArrayList intArray = new ArrayList();
            // đưa vào mảng
            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(i + 100));
                intArray.Add(i * 5);
            }
            // in tất cả nội dung
            for (int i = 0; i < intArray.Count; i++)
            {
                Console.Write("{0} ", intArray[i].ToString());
            }
            Console.WriteLine("\n");
            // in tất cả nội dung của mảng
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("empArray.Count: {0}", empArray.Count);
            Console.WriteLine("empArray.Capacity: {0}",empArray.Capacity);
            Console.ReadKey();
        }
    }
}
