using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyNgoaiLeBangTryCatch_Func1_Func2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Main...");
            Program test = new Program();
            test.Func1();
            //Sử dụng khối try catch để handle error khi thực hiện lệnh Func3, tránh chương trình bị chết
            try
            {
                test.Func3();
            }
            //Biến ex ở đây chính là lỗi được ném ra từ Func3. Ta catch lỗi đó để xử lý.
            catch (Exception ex) { 
                //In ra nội dung của lỗi
                Console.WriteLine(ex.ToString());
            }

            /*
            !! Khi thực hiện code dưới đây mà không có khối try catch, chương trình ngay lệnh tức chết (bị dừng đột ngột) vì error không được handle.
            Trong thực tế ta không bao giờ nên để điều này xảy ra vì có thể gây ra nhiều ảnh hưởng nghiêm trọng.
            */

            //test.Func3();
            
            Console.WriteLine("Exit Main");
            Console.ReadKey();

        }
        //Tự thêm Func3 để tìm hiểu vì sao phải dùng khối try catch
        public void Func3()
        {
            Console.WriteLine("Enter Func3...");
            /*
            Trong trường hợp này, error với nội dung "Error in func3!!!
            sẽ được ném ra ngoài cho khối catch mà chứa lệnh gọi tới Func3 này
            */
            throw new Exception("Error in func3!!!");
            //Vì đã bị ném lỗi nên dòng bên dưới này sẽ không bao giờ được chạy
            Console.WriteLine("Dong nay se khong bao gio duoc xuat ra man hinh!");
        }
        public void Func2()
        {
            Console.WriteLine("Enter Func2...");
            try
            {
                Console.WriteLine("Entering try block...");
                throw new System.Exception();
                Console.WriteLine("Exiting try block...");
                }
            /*
            Các lỗi được ném ra sẽ được đưa vào catch,
            cụ thể ở đây là lỗi được ném ra bởi lệnh throw new System.Exception();
            */
            catch
            {
                    Console.WriteLine("Exception caught and handled.");
                }
                Console.WriteLine("Exit Func2...");
        }
        public void Func1()
        {
            Console.WriteLine("Enter Func1...");
            //Thực hiện try để thử chạy lệnh bên dưới
            try
            {
                Console.WriteLine("Entering try block...");
                Func2();
                Console.WriteLine("Exiting try block...");
                }
            //Các lỗi được ném ra sẽ được đưa vào catch
                catch
                {
                    Console.WriteLine("Exception caught and handled.");
                }
                Console.WriteLine("Exit Func1...");
                }
    }
}
