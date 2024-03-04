using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image curImage = Image.FromFile("C:/Users/Ha Phu/Pictures/image.jpg");
            Rectangle rect = new Rectangle(20, 20, 100, 100);
            g.DrawImage(curImage, rect);
        }
    }
}
