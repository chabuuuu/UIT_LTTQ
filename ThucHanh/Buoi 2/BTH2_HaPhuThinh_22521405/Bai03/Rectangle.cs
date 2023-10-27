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
            return this.Height * this.Width;
        }

        public override float CalculatePerimeter()
        {
            return (this.Height + this.Width)*2;
        }
    }
}
