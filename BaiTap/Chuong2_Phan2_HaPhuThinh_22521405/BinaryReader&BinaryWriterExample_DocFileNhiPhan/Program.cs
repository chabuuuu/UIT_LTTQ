using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryReader_BinaryWriterExample_DocFileNhiPhan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory() + "/test.bin";
            Console.WriteLine(directory);
            FileStream theFile =File.Open(directory, FileMode.Open);
            BinaryReader reader = new BinaryReader(theFile);
            long number = reader.ReadInt64(); byte[] bytes =
            reader.ReadBytes(4); string s = reader.ReadString();
            reader.Close();
            FileStream theFile2 = File.Open(@"c:\somefile.bin",
            FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(theFile2);
            number = 100;
            byte[] bytes2 = new byte[] { 10, 20, 50, 100 };
            string s2 = "Toi di hoc";
writer.Write(number); writer.Write(bytes2);
            writer.Write(s2);
        }
    }
}
