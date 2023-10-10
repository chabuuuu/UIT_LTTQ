﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoExample_TaoDocGhiCopyXoaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.GetTempFileName();
            FileInfo fi1 = new FileInfo(path);
            //Create a file to write to.
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
            //Open the file to read from.
            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            try
            {
                string path2 = Path.GetTempFileName();
                FileInfo fi2 = new FileInfo(path2);
                //Ensure that the target does not exist.
                fi2.Delete();
                //Copy the file.
                fi1.CopyTo(path2);
                Console.WriteLine("{0} was copied to {1}.", path,
               path2);
                //Delete the newly created file.
                fi2.Delete();
                Console.WriteLine("{0} was successfully deleted.",
               path2);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}",
               e.ToString());
            }
            Console.ReadKey();
        }
    }
}
