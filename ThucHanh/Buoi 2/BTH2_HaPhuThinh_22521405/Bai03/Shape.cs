using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal abstract class Shape
    {
        private float Area;
        private float Perimeter;

        public abstract float CalculateArea();

        public abstract float CalculatePerimeter();

    }
}
