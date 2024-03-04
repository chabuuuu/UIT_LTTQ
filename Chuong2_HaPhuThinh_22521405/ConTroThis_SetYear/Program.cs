using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConTroThis_SetYear
{
    public class ThoiGian
    {

        public void setYear(int Nam)
        {
            this.Nam = Nam;
            
            /*Tham chiếu this này được xem là con trỏ ẩn
            đến tất các phương thức không có thuộc tính
            tĩnh trong một lớp*/

        }
        public int getYear()
        {
            return this.Nam;
        }
            private int Nam;
            private int Thang;
            private int Ngay;
            private int Gio;
            private int Phut;
            private int Giay;
    

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ThoiGian t = new ThoiGian();
            t.setYear(2023);
            System.Console.WriteLine(t.getYear());
            System.Console.ReadKey();
        }
    }
}
