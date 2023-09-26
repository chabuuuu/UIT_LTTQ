using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoCacThuocTinhGiongArray_Indexer
{

    public class Database
    {
        // Lớp Database để lưu trữ điểm của sinh viên
        public double GetMark(string studentID, string subjectID)
        {
            // Lấy điểm của sinh viên dựa trên studentID và subjectID
            return 0.0; //Điểm mặc định là 0.0
        }

        public void UpdateMark(string studentID, string subjectID, double mark)
        {
            // Cập nhật điểm của sinh viên dựa trên studentID và subjectID
            // Đây là nơi thực hiện logic cập nhật điểm
        }
    }
    public class Student
    {
        protected string StudentID;
        protected Database MarkDB;

        // Sử dụng một từ điển (Dictionary) để lưu trữ điểm của sinh viên theo môn học
        private readonly Dictionary<string, double> marks = new Dictionary<string, double>();

        public double this[string subjectID]
        {
            get
            {
                return marks.ContainsKey(subjectID) ? marks[subjectID] : 0.0;
            }
            set
            {
                MarkDB.UpdateMark(StudentID, subjectID, value);
                marks[subjectID] = value;
            }
        }

        public Student(string studentID, Database markDB)
        {
            StudentID = studentID;
            MarkDB = markDB;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Database markDB = new Database();

            // Tạo đối tượng Student
            Student chau = new Student("123456", markDB);

            // Gán điểm cho môn học "Physic"
            chau["Physic"] = 85.5;

            // Lấy điểm môn học "Physic"
            Console.WriteLine("Physic mark: {0}", chau["Physic"]);
            Console.ReadLine();
        }
    }
}
