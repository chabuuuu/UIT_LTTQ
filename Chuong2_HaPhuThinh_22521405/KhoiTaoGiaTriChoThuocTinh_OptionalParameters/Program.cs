using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoiTaoGiaTriChoThuocTinh_OptionalParameters
{
    class MyClass
    {
        //Optional parameters: y, z
        public MyClass(int x, int y = 5, int z = 9) { 
            this.x = x; this.y = y; this.z = z;
        }
        public void print()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);
        }
        private int x;
        private int y;
        private int z;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass(1, 2, 3);
            myClass1.print();
            MyClass myClass2 = new MyClass(1, 2); //z = 9
            myClass2.print();
            MyClass myClass3 = new MyClass(1); //y = 5, z = 9
            myClass3.print();
            //C# không cho phép để trống các tham số ở giữa, ví dụ:
            //MyClass myClass4 = new MyClass(1, , 2);
            MyClass myClass4 = new MyClass(x: 2, z: 5); //Muốn bỏ các tham số giữa, các tham số phải gán với một cái tên
            myClass4.print();
            //Hoặc
            MyClass myClass5 = new MyClass(z: 5, x: 2);
            myClass5.print();
            System.Console.ReadKey();
        }
    }
}
