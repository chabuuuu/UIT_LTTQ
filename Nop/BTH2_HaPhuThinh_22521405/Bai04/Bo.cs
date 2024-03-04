using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class Bo : GiaSuc
    {
        public Bo(int ammount) : base(ammount) {
            Random random = new Random();
            this.milk = random.Next(0, 20);
        }
        public override void keu()
        {
            if (this.ammount > 0)
            {
                Console.WriteLine("Um bo...");
            }
        }
    }
}
