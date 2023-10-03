using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MethodDelegate();


namespace GoiStaticMethodTuLopKhac_MethodDelegate
{
    class Person
    {
        public void Hello(MethodDelegate mDelegate)
        {
            Console.WriteLine("Hello Delegate");
            //Gọi Method được truyền vào
            if (mDelegate != null)
                mDelegate();
        }
    }

    internal class Program
    {
        private static void priMethod()
        {
            Console.WriteLine("Private Method");
        }

        static void Main(string[] args)
        {
            Person person = new Person();
            //Khai báo delegate trỏ tới privateMethod
            MethodDelegate helloDelegate = new
           MethodDelegate(priMethod);
            //Truyền delegate vào method Hello như một đối số
            person.Hello(helloDelegate);
            Console.ReadKey();
        }
    }
}
