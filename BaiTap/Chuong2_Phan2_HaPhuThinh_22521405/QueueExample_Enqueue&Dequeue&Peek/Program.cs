using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample_Enqueue_Dequeue_Peek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue intQueue = new Queue();
            // đưa vào trong mảng 
            for (int i = 0; i < 5; i++)
            {
                intQueue.Enqueue(i * 5);
            }
            // hiển thị hàng đợi 
            Console.Write("intQueue values: "); PrintValues(
           intQueue);
            // xóa thành phần ra khỏi hàng đợi
            Console.WriteLine("\nDequeue: {0}", intQueue.Dequeue());
            // hiển thị hàng đợi 
            Console.Write("intQueue values: "); PrintValues(intQueue);
            // xóa thành phần khỏi hàng đợi
            Console.WriteLine("\nDequeue: {0}", intQueue.Dequeue());
            // hiển thị hàng đợi 
            Console.Write("intQueue values: "); PrintValues(intQueue);
            // Xem thành phần đầu tiên trong hàng đợi. 
            Console.WriteLine("\nPeek: {0}", intQueue.Peek());
            // hiển thị hàng đợi 
            Console.Write("intQueue values: "); PrintValues(intQueue);
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
