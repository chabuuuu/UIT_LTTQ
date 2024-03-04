using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyNgoaiLe_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Main....");
            Program t = new Program();
            t.Func1();
            Console.WriteLine("Exit Main...");
        }

        public void Func1()
        {
            Console.WriteLine("Enter Func1...");
            Func2();
            Console.WriteLine("Exit Func1...");
        }
        public void Func2()
        {
            Console.WriteLine("Enter Func2...");
            //Test throw
            throw new System.Exception();
            //Dòng này sẽ không bao giờ được chạy vì ta đã dừng chương trình và báo lỗi bằng lệnh throw
            Console.WriteLine("Exit Func2...");
        }
    }
}
