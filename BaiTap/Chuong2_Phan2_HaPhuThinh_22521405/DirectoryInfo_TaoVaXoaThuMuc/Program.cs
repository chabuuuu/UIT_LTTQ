using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfo_TaoVaXoaThuMuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the directories you want to manipulate.
            DirectoryInfo di = new DirectoryInfo(@"c:\MyDir");
            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    // Indicate that the directory already exists.
                    Console.WriteLine("That path exists already.");
                    return;
                }
                // Try to create the directory.
                di.Create();
                Console.WriteLine("The directory was created successfully.");
                // Delete the directory.
                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}",
               e.ToString());
            }
            finally { }
            Console.ReadKey();
        }
    }
}
