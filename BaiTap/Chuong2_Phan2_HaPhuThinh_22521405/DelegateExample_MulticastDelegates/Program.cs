using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void FunctionToCall(ref int x);


namespace DelegateExample_MulticastDelegates
{
    internal class Program
    {
        public static void Add2(ref int x)
        {
            x += 2;
        }
        public static void Add3(ref int x)
        {
            x += 3;
        }

        static void Main(string[] args)
        {
            // Khai báo đồng thời gán bằng Add2
            FunctionToCall functionDelegate = Add2;
            functionDelegate += Add3;
            functionDelegate += Add2;
            functionDelegate += Add2;
            //Delegate có thể chứa cùng lúc nhiều method khác nhau (gọi là Multicast Delegates)
            int x = 5;
            //Khi thực hiện lên dưới, delegate sẽ thực hiện tất cả các method mà nó đã lưu
            functionDelegate(ref x); // Gọi delegate
            Console.WriteLine("Value: {0}", x);
            int y = 5;
            functionDelegate = Add2; //5 + 2 = 7
            functionDelegate += Add3; //7 + 3 = 10
            functionDelegate -= Add2; //10 - 2 = 8
            functionDelegate(ref y); // Gọi delegate
            Console.WriteLine("Value: {0}", y);
            Console.ReadLine();
        }
    }
}
