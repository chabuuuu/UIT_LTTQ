using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaHinhTrongC__SuDungTuKhoaVirtualVaOverride
{
    internal class Program
    {
        public class Window
        {
            // Hàm khởi dựng lấy hai số nguyên chỉ đến vị trí của cửa sổ trên console
            public Window(int top, int left)
            {
                this.top = top;
                this.left = left;
            }

            /* Để tạo một phương thức hỗ tính đa hình:
            khai báo khóa virtual trong phương thức của lớp cơ sở
            */
            public virtual void DrawWindow() 
            {
                Console.WriteLine("Drawing Window at {0}, {1}", top, left);
            }
            // Có hai biến thành viên private do đó hai biến này sẽ không thấy bên trong lớp dẫn xuất.
            private int top;
            private int left;
        }
        public class ListBox : Window
        {
            // Khởi dựng có tham số
            public ListBox(int top, int left, string theContents) : base(top, left)
            //gọi khởi dựng của lớp cơ sở
            {
                mListBoxContents = theContents;
            }
            // Để định nghĩa lại các hàm virtual, hàm tương ứng lớp dẫn xuất phải có từ khóa Override
            public override void DrawWindow()
            {
                base.DrawWindow();
                Console.WriteLine(" ListBox write: {0}", mListBoxContents);
            }
            // biến thành viên private
            private string mListBoxContents;
        }


        static void Main(string[] args)
        {   
            //Su dung da hinh:
            Window window = new ListBox(5, 10, "Hello world");
            window.DrawWindow();
            Console.ReadLine();
        }
    }
}
