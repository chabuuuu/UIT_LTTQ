using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MethodDelegate();

namespace DelegateExample_Person
{
    internal class Program
    {
        class Person
        {
            public void Hello()
            {
                Console.WriteLine("Hello Delegate");
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            //Tạo helloDelegate kiểu delegate để chứa thông tin về method Hello trong object person
            MethodDelegate helloDelegate = new MethodDelegate(person.Hello);
            //Ta có thể gọi hàm person.Hello bằng việc dùng helloDelegate()
            helloDelegate(); //gọi hàm
            Console.ReadKey();
        }
    }
}
