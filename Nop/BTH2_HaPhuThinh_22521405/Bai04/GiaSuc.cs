using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    internal class GiaSuc
    {
        public int ammount { get; protected set; }
        public int milk { get; protected set; }
        public GiaSuc()
        {   
            this.ammount = 0;
        }
        public GiaSuc(int ammount)
        {
            this.ammount = ammount;
        }
        public virtual void keu()
        {
        }
    }
}
