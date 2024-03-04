using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDuVeLenhFinally_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Đây là ví dụ về sử dụng finally
             * Nhập vào console 1 string rỗng thì khối catch sẽ catch lỗi, và lệnh trong finally vẫn sẽ được chạy
             * Nhập vào 1 string khác rỗng thì finally vẫn chạy
             * => Finally sẽ chạy bất kể có catch được lỗi hay không
            */
            Program test = new Program();
            string a = Console.ReadLine();
            try
            {
                test.Func1(a);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Cau lenh nay se luon duoc chay");
                Console.ReadLine();
            }
        }
        void Func1(string a)
        {
            if (a.Length == 0)
            {
                throw new Exception("Input is invalid!");
                Console.WriteLine("Lenh nay se khong bao gio duoc chay");
            }
        }
    }
}
