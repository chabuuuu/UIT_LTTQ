using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FilterValue_Property
{
    public class Student
    {
        private DateTime _Birthday;
        private string foreName;

        public DateTime Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                // Kiểm tra giá trị trước khi gán (ví dụ: kiểm tra ngày sinh phải nằm trong khoảng từ năm 1900 đến năm hiện tại)
                if (value.Year < 1900 || value.Year > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Birthday", "Ngày sinh không hợp lệ.");
                }

                _Birthday = value;
            }
        }
        public string ForeName // ForeName là một Property
        {
            get
            {
                return foreName;
            }
            set
            {
                if (value.Length > 20)
                {
                    // Xử lý lỗi khi giá trị dài hơn 20 ký tự (ví dụ: ném một ngoại lệ)
                    throw new ArgumentException("Tên quá dài, không được vượt quá 20 ký tự.", "ForeName");
                }
                else
                {
                    foreName = value;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student chau = new Student();

            try
            {
                // Gán ngày sinh mới
                chau.Birthday = new DateTime(2007, 9, 23);

                // Hiển thị ngày sinh
                Console.WriteLine("Birthday: {0}", chau.Birthday);

                //Gán forename
                chau.ForeName = "haphuthinh";
                Console.WriteLine("Forename: {0}", chau.ForeName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
