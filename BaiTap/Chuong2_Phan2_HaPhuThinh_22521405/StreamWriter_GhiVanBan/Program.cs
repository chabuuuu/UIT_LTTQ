using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriter_GhiVanBan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lấy các thư mục hiện hành trên ổ đĩa
            DirectoryInfo[] cDirs = new
           DirectoryInfo(@"c:\").GetDirectories();
            // Viết tên các thư mục vào file
            using (StreamWriter sw = new
           StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);

                }
            }
            // Đọc và hiển thi tên thư mục từ file
            string line = "";
            using (StreamReader sr = new
           StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    }
}
