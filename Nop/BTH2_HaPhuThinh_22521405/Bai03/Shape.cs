using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal abstract class Shape
    {
        protected float Area { get; set; }
        protected float Perimeter { get;  set; }

        public abstract float CalculateArea();

        public abstract float CalculatePerimeter();

    }
}
