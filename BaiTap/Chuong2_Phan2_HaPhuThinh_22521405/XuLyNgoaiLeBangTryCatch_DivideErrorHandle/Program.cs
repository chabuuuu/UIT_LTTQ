using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace XuLyNgoaiLeBangTryCatch_DivideErrorHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Có chỉnh sửa lại đôi chút (trong hàm TestFunc()) so với ví dụ mẫu để người dùng nhập tùy ý tử và mẫu,
            đồng thời handle trường hợp người dùng nhập vào 1 giá trị null
            */
            Program t = new Program();
            t.TestFunc();
            Console.ReadKey();
        }
        public double DoDivide(double a, double b)
            {
                if (b == 0)
                throw new System.DivideByZeroException();
                if (a == 0)
                throw new System.ArithmeticException();
                return a / b;
            }
        public void TestFunc()
             {
            double a;
            double b;
            string temp;
              try
                 {
                Console.WriteLine("Nhap tu: ");
                temp = Console.ReadLine();
                if (temp.Length == 0)
                {
                    throw new Exception("Input null value!");
                }
                a  = Double.Parse(temp);
                Console.WriteLine("Nhap mau: ");
                temp = Console.ReadLine();
                if (temp.Length == 0)
                {
                    throw new Exception("Input null value!");
                }
                b = Double.Parse(temp);
                Console.WriteLine("{0} / {1} = {2}", a, b, 
                    DoDivide(a, b));
                 }
                     catch (System.DivideByZeroException)
                 {
                     Console.WriteLine("DivideByZeroException caught!");
                 }
              catch (System.ArithmeticException)
                 {
                     Console.WriteLine("ArithmeticException caught!");
                     
                 }
            //Cho lệnh catch 1 tham số đầu vào là ex để ta có thể lấy được thông tin lỗi
              catch(Exception ex)
                 {
                //Console.WriteLine("Unknown exception caught");
                /*
                Ở đây ta có thể xuất ra được thông tin lỗi của những lỗi mà ta chưa xác định
                Hãy thử nhập tử hoặc mẫu là 1 giá trị null, chương trình sẽ catch được lỗi và 
                xuất ra thông tin chi tiết của lỗi
                */
                Console.WriteLine(ex.ToString());
                 }
             }

    }
}
