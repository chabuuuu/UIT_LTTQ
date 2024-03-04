using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample_Push_Pop_Peek_CopyTo_ToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack intStack = new Stack();
            // đưa vào ngăn xếp
            for (int i = 0; i < 8; i++)
            {
                intStack.Push(i * 5);
            }
            // hiển thị stack 
            Console.Write("intStack values: "); PrintValues(intStack
           );
            // xóa phần tử đầu tiên
            Console.WriteLine("\nPop: {0}", intStack.Pop());
            // hiển thị stack 
            Console.Write("intStack values: "); PrintValues(intStack
           );
            // xóa tiếp phần tử khác
            Console.WriteLine("\nPop: {0}", intStack.Pop());
            // hiển thị stack 
            Console.Write("intStack values: "); PrintValues(intStack
           );
            // xem thành phần đầu tiên stack
            Console.WriteLine("\nPeek: {0}", intStack.Peek());
            // hiển thị stack 
            Console.Write("intStack values: "); PrintValues(intStack);
            // khai báo mảng với 12 phần tử
            Array targetArray = Array.CreateInstance(typeof(int), 12);
            for (int i = 0; i <= 8; i++)
            {
                targetArray.SetValue(100 * i, i);
            }
            // hiển thị giá trị của mảng 
            Console.WriteLine("\nTarget array: "); PrintValues(
           targetArray);
            // chép toàn bộ stack vào mảng tại vị trí 6 
            intStack.CopyTo(targetArray, 6);
            // hiển thị giá trị của mảng sau copy 
            Console.WriteLine("\nTarget array after copy: ");
            PrintValues(targetArray);
            // chép toàn bộ stack vào mảng mới
            Object[] myArray = intStack.ToArray();
            // hiển thị giá trị của mảng mới 
            Console.WriteLine("\nThe new array: "); PrintValues(myArray);   
            Console.ReadKey();
    }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("{0} ", obj);
            Console.WriteLine();
        }

    }
}
