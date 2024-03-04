using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderExample_DocVanBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Tạo một StreamReader để đọc file
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;
                    // Đọc từng dòng của File 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Hiển thị thông điệp lỗi
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
