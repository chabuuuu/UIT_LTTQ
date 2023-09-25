using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhongTaiNguyen_GC.Collect__
{
    internal class Program
    {
        public class MyClass
        {
            private string message;

            // Constructor
            public MyClass(string msg)
            {
                message = msg;
                Console.WriteLine("Constructor: " + message);
            }

            // Destructor
            ~MyClass()
            {
                Console.WriteLine("Destructor: " + message);
            }
        }

        static void Main(string[] args)
        {
            MyClass obj1 = new MyClass("Object 1");
            MyClass obj2 = new MyClass("Object 2");

            // Đối tượng obj1 và obj2 sẽ bị hủy bỏ sau khi ra khỏi phạm vi này

            // Đặt đối tượng null để gợi nhớ garbage collector hủy bỏ đối tượng
            obj1 = null;
            obj2 = null;

            // Gọi garbage collector để kiểm tra và hủy bỏ đối tượng
            GC.Collect();

            // Chờ một chút để xem phương thức hủy bỏ được gọi
            System.Console.ReadKey();
        }
    }
}
