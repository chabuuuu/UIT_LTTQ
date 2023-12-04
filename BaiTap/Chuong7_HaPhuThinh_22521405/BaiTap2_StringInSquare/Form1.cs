using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2_StringInSquare
{
    public partial class Form1 : Form
    {
        private int currentIndex = 0;
        private string[] stringsToDisplay = { "test1", "test2", "test3", "test4" };
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string text = "Hà Phú Thịnh";
            Font myFont = new Font("Time New Roman", 20, FontStyle.Regular);



            /* string text = "Hà Phú Thịnh";
             Graphics graphics = e.Graphics;
             Font font = new Font("Time News Roman", 15, FontStyle.Regular);

             StringFormat stringFormat = new StringFormat();
             stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
             stringFormat.Alignment = StringAlignment.Center;
             stringFormat.LineAlignment = StringAlignment.Center;

             graphics.Clear(Color.White);
             graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

             graphics.DrawString(text, font, Brushes.Black, new RectangleF(0, 0, ClientRectangle.Width, ClientRectangle.Height), stringFormat);
         */


            Rectangle displayRectangle = new Rectangle(new Point(40, 40), new Size(300, 300));
            StringFormat stringFormat1 = new StringFormat(StringFormatFlags.NoClip);
            StringFormat stringFormat2 = new StringFormat();


            StringFormat stringFormat3 = new StringFormat();
            StringFormat stringFormat4 = new StringFormat();

            stringFormat1.LineAlignment = StringAlignment.Near;
            stringFormat1.Alignment = StringAlignment.Center;
            stringFormat2.LineAlignment = StringAlignment.Far;
            stringFormat2.Alignment = StringAlignment.Center;
            stringFormat2.FormatFlags = StringFormatFlags.DirectionVertical;
            stringFormat3.LineAlignment = StringAlignment.Near;
            /*
            float textX = x;
            float textY = y;
            float angle = 0;

            if (textSize.Width > textSize.Height)  // Nếu chiều ngang lớn hơn chiều dọc
            {
                textY += (squareSize - textSize.Height) / 2;
                angle = -90;
            }
            else  // Nếu chiều dọc lớn hơn chiều ngang hoặc bằng nhau
            {
                textX += (squareSize - textSize.Width) / 2;
            }
            */

            stringFormat3.Alignment = StringAlignment.Center;
            stringFormat3.FormatFlags = StringFormatFlags.DirectionVertical;
            stringFormat4.LineAlignment = StringAlignment.Far;
            stringFormat4.Alignment = StringAlignment.Center;


            e.Graphics.DrawRectangle(Pens.Black, displayRectangle);
            e.Graphics.DrawString(text, myFont, Brushes.Black, (RectangleF)displayRectangle, stringFormat1);
           
            
            
            
            e.Graphics.DrawString(text, myFont, Brushes.Black, (RectangleF)displayRectangle, stringFormat2);
            e.Graphics.DrawString(text, myFont, Brushes.Black, (RectangleF)displayRectangle, stringFormat3);
            e.Graphics.DrawString(text, myFont, Brushes.Black, (RectangleF)displayRectangle, stringFormat4);
            myFont.Dispose();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
