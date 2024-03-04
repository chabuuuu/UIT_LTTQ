using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    public class MySprite
    {
        private Bitmap[] bMP;
        private int nBMP;
        private int iBMP;
        private int left;
        private int top;
        private int width;
        private int height;

        public Bitmap[] BMP
        {
            get => bMP;
            set
            {
                bMP = value;
                
            }
        }
        public int NBMP { get => nBMP; set => nBMP = value; }
        public int IBMP { get => iBMP; set => iBMP = value; }
        public int Left { get => left; set => left = value; }
        public int Top { get => top; set => top = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public MySprite(Bitmap[] bmp, int left, int top)
        {
            bMP = bmp;
            this.left = left;
            this.top = top;
            nBMP = bMP.Length;
            iBMP = 0;
            width = bMP[0].Width;
            height = bMP[0].Height;
        }
        public void Update()
        {
            iBMP = (iBMP + 1) % nBMP;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(bMP[iBMP], left, top);
        }
    }
}
