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
using TextureBrush_Example.Properties;

namespace TextureBrush_Example
{
    public partial class Form1 : Form
    {
        private TextureBrush brush = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            Image img = new Bitmap(TextureBrush_Example.Properties.Resources.gradient);
            brush = new TextureBrush(img);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(10, 10, 400, 300);
            g.FillRectangle(brush, rect);
        }
    }
    
}
