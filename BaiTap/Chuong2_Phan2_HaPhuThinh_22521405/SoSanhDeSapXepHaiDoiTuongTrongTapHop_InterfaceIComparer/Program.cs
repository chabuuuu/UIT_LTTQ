using SoSanhDeSapXepHaiDoiTuongTrongTapHop_InterfaceIComparer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Interface IComparer cung cấp phương thức Compare(), 
để so sánh hai phần tử trong một tập hợp có thứ tự. 
Phương thức Compare() thường được thực thi bằng 
cách gọi phương thức CompareTo() của một trong 
những đối tượng. 
Nếu chúng ta muốn tạo ra những lớp có thể được sắp 
xếp bên trong một tập hợp thì chúng ta cần thiết phải 
thực thi IComparable.
 */
namespace SoSanhDeSapXepHaiDoiTuongTrongTapHop_InterfaceIComparer
{
    public class Employee : IComparable
    {
        private int empID;
        private int yearsOfSvc = 1;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public Employee(int empID, int yearsOfSvc)
        {
            this.empID = empID;
            this.yearsOfSvc = yearsOfSvc;
        }
        public override string ToString()
        {
            return "ID: " + empID.ToString() + ". Years of Svc: " +
           yearsOfSvc.ToString();
        }
        // Phương thức tĩnh để nhận đối tượng Comparer 
        public static EmployeeComparer GetComparer()
        {
            return new Employee.EmployeeComparer();
        }
        public int CompareTo(Object rhs)
        {
            Employee r = (Employee)rhs;
            return this.empID.CompareTo(r.empID);
        }
        // Thực thi đặc biệt được gọi bởi custom comparer 
        public int CompareTo(Employee rhs,
       Employee.EmployeeComparer.ComparisionType which)
        {
            switch (which)
            {
                case Employee.EmployeeComparer.ComparisionType.EmpID:
                    return this.empID.CompareTo(rhs.empID);
                case Employee.EmployeeComparer.ComparisionType.Yrs:
                    return this.yearsOfSvc.CompareTo(rhs.yearsOfSvc);
            }
            return 0;
        }

        // Lớp bên trong thực thi IComparer
        public class EmployeeComparer : IComparer
        {
            private Employee.EmployeeComparer.ComparisionType
           whichComparision;
            // Định nghĩa kiểu liệt kê 
            public enum ComparisionType
            {
                EmpID, Yrs
            };
            // Yêu cầu những đối tượng Employee tự so sánh với nhau 
            public int Compare(object lhs, object rhs)
            {
                Employee l = (Employee)lhs;
                Employee r = (Employee)rhs;
                return l.CompareTo(r, WhichComparision);
            }
            public Employee.EmployeeComparer.ComparisionType
           WhichComparision
            {
                get
                {
                    return whichComparision;
                }
                set
                {
                    whichComparision = value;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList empArray = new ArrayList(); Random r = new
Random();
            for (int i = 0; i < 5; i++)
            {
                empArray.Add(new Employee(r.Next(10) + 100,
               r.Next(20)));
            }
            // Hiển thị tất cả nội dung của mảng Employee 
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
            // Sắp xếp mảng theo empID
            Employee.EmployeeComparer c = Employee.GetComparer();
            c.WhichComparision =
           Employee.EmployeeComparer.ComparisionType.EmpID;
            empArray.Sort(c);
            // Hiển thị nội dung của mảng
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
            // Sắp xếp mảng theo yearsOfSvc
            c.WhichComparision =
           Employee.EmployeeComparer.ComparisionType.Yrs;
            empArray.Sort(c);
            // Hiển thị nội dung của mảng
            for (int i = 0; i < empArray.Count; i++)
            {
                Console.Write("\n{0} ", empArray[i].ToString());
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
