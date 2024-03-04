using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    internal class Rectangle : Shape
    {
        private float Height;
        private float Width;

        public Rectangle(float height, float width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override float CalculateArea()
        {
            base.Area = this.Height * this.Width;
            return base.Area;
        }

        public override float CalculatePerimeter()
        {
            base.Perimeter = (this.Height + this.Width)*2;
            return base.Perimeter;
        }
    }
}
