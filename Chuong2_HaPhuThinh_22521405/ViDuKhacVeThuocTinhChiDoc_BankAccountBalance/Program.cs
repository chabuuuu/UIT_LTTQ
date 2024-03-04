using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDuKhacVeThuocTinhChiDoc_BankAccountBalance
{
     public class BankAccount
     {
         protected string ID;
         protected string Owner;
         protected decimal _Balance;
         public BankAccount(string ID, string Owner)
         {
         this.ID = ID;
         this.Owner = Owner;
         this._Balance = 0;
         }
         public void Deposit(decimal Amount)
         {
         _Balance += Amount;
         }
         public void Withdraw(decimal Amount)
         { _Balance -= Amount; // what if Amount > Balance?
          
        }
         public decimal Balance
         {
             get
         {
              return _Balance;
           }
         }
     };
internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcct = new BankAccount("100120023003","Nguyen Van An");
             myAcct.Deposit(1000);
             myAcct.Withdraw(100);
            Console.WriteLine("Balance: {0}", myAcct.Balance);
            //myAcct.Balance = 10000;
            //Khong the gan duoc vi balance la thuoc tinh chi doc
            Console.ReadLine();

        }
    }
}
