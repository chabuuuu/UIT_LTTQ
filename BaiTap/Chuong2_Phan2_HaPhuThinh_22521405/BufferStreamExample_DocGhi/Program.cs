using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferStreamExample_DocGhi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream newFile = File.Create(@"c:\test.txt");
            BufferedStream buffered = new BufferedStream(newFile);
            StreamWriter writer = new StreamWriter(buffered);
            writer.WriteLine("Some data");
        }
    }
}
