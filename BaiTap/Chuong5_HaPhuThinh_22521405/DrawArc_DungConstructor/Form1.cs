using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrawArc_DungConstructor
{
    public partial class Form1 : Form
    {
        private float startAngle = 45.0f;
        private float sweepAngle = 90.0f;
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawArc_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(200, 20, 200, 200);
            g.DrawArc(Pens.Red, rect, startAngle, sweepAngle);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            startAngle = (float)Convert.ToDouble(textBox1.Text);
            sweepAngle = (float)Convert.ToDouble(textBox2.Text);
            Invalidate();
        }
    }
}
