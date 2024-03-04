using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhongTaiNguyen__IDisposable
{
    public class MyResource : IDisposable
    {
        private bool disposed = false;

        // Constructor
        public MyResource()
        {
            Console.WriteLine("MyResource duoc khoi tao");
        }

        // Phương thức để giải phóng tài nguyên
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Giải phóng các tài nguyên quản lý
                    Console.WriteLine("Giai phong cac tai nguyen quan ly");
                }

                // Giải phóng tài nguyên không quản lý (nếu cần)
                Console.WriteLine("Giai phong tai nguyen khong quan ly");

                disposed = true;
            }
        }

        // Phương thức Dispose để triển khai giao diện IDisposable
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Destructor (được sử dụng cho việc giải phóng tài nguyên không quản lý)
        ~MyResource()
        {
            Dispose(false);
            Console.WriteLine("Destructor duoc goi.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            using (MyResource resource = new MyResource())
            {
                Console.WriteLine("Su dung MyResource.");
                // Sử dụng tài nguyên ở đây

                // Khi kết thúc phạm vi using, Dispose() sẽ tự động được gọi để giải phóng tài nguyên.
            }
            System.Console.ReadKey();
        }
    }
}
