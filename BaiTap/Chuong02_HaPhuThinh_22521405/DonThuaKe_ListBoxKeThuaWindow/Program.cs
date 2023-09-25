using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonThuaKe_ListBoxKeThuaWindow
{
    public class Window
    {
        // Hàm khởi dựng lấy hai số nguyên chỉ đến vị trí của cửa sổ trên console
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public void DrawWindow() // mô phỏng vẽ cửa sổ
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
        // Tạo một phiên bản mới cho phương thức DrawWindow
        // vì trong lớp dẫn xuất muốn thay đổi hành vi thực hiện
        // bên trong phương thức này
        public new void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine(" ListBox write: {0}", mListBoxContents);
        }
        // biến thành viên private
        private string mListBoxContents;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo đối tượng cho lớp cơ sở
            Window w = new Window(5, 10);
            w.DrawWindow();
            // tạo đối tượng cho lớp dẫn xuất
            ListBox lb = new ListBox(20, 10, "Hello world!");
            lb.DrawWindow();
            Console.ReadLine();
        }
    }
}
