using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ViDu
{
    interface IStorable
    {
        void Read();
        void Write(object a);
    }
    class Item
    {
        public Item(string fileName, string content)
        {
            this.fileName = fileName;
            this.content = content;
        }
        public string Name { 
            get
            {
                return this.fileName;
            }
          }
        public string Description { get
            {
                return this.content;
            }
        }
        private string fileName;
        private string content;
    }
    public class Document : IStorable
    {
        public void Read()
        {
            Console.WriteLine(this.fileName);
        }
        public void Write(object a)
        {
            var OBJECT = (Item)a;
            this.fileName = OBJECT.Name;
        }
        private string fileName;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            Item item = new Item("TaiLieu", "Hello world!");
            document.Write(item);
            document.Read();
            Console.ReadLine();
        }
    }
}

