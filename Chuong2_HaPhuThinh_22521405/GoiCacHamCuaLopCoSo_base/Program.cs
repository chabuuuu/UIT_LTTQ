using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoiCacHamCuaLopCoSo_base
{
    class CustomerAccount
    {
        public virtual decimal CalculatePrice()
        {
            // implementation
            Console.WriteLine("Calculate Price...");
            return 10;
        }
    }
    class GoldAccount : CustomerAccount
    {
        public override decimal CalculatePrice()
        {
            return base.CalculatePrice() * 0.9M;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerAccount goldAccount = new GoldAccount();
            Console.WriteLine(goldAccount.CalculatePrice());
            Console.ReadLine();
        }
    }
}
