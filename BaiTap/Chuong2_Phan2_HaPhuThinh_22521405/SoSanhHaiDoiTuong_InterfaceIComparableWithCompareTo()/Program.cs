using SoSanhHaiDoiTuong_InterfaceIComparableWithCompareTo__;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
     Vai trò của IComparable là cung cấp một 
     phương pháp ComparteTo() dùng để so sánh hai 
     đối tượng.
 */
namespace SoSanhHaiDoiTuong_InterfaceIComparableWithCompareTo__
{
    public class Employee : IComparable
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
                this.empID = value;
            }
        }
        public int CompareTo(Object o)
        {
            Employee r = (Employee)o;
            return this.empID.CompareTo(r.empID);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList empArray = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(r.Next(10) + 100));
            }
            // In tất cả nội dung của mảng
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
            // Sắp xếp lại mảng Employee dựa theo phương thức CompareTo()
            empArray.Sort();
            // Hiển thị tất cả nội dung của mảng Employee 
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
