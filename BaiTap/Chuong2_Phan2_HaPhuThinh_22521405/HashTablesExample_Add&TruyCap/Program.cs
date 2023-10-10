using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesExample_Add_TruyCap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo và khởi tạo hashtable
            Hashtable hashTable = new Hashtable();
            hashTable.Add("00440123", "Ngoc Thao");
            hashTable.Add("00123001", "My Tien");
            hashTable.Add("00330124", "Thanh Tung");
            // truy cập qua thuộc tính Item
            Console.WriteLine("myHashtable[\"00440123\"]: {0}",
           hashTable["00440123"]);
            Console.ReadKey();
        }
    }
}
