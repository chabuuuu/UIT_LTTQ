using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MethodDelegate();


/*
 * Không những đại diện cho một method, delegate còn có khả năng trỏ 
tới nhiều method cùng lúc.
*/
namespace MulticastDelegatesExample_Hello_Swim
{
    class Person
    {
        public void Hello()
        {
            Console.WriteLine("Hello Delegate");
        }
        public void Swim()
        {
            Console.WriteLine("Person is swimming");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            MethodDelegate multicastDelegate = null;
            //Multicasting delegate
            multicastDelegate += new
           MethodDelegate(person.Hello);
            multicastDelegate += new
           MethodDelegate(person.Swim);
            //Lúc này, multicastDelegate đã trỏ tới cùng lúc 2 method là person.Hello và person.Swim
            multicastDelegate();
            //Lệnh trên sẽ thực hiện tất cả các method mà multicastDelegate đang trỏ tới
            Console.ReadKey();
        }
    }
}
