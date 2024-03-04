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

namespace ColorDialogDemo_ChonMauNenChoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, 
                colorDialog1.Color, 
                Color.White, 
                LinearGradientMode.Horizontal);
            g.FillRectangle(brush, rect);
        }
    }
}
