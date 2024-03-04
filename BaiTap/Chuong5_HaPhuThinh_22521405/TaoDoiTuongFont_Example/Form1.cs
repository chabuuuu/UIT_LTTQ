using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaoDoiTuongFont_Example
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
            Font fa = new Font("Time New Roman", 14);
            g.DrawString(" DH CNTT ", fa, Brushes.Salmon, 10, 10);

            Font fb = new Font("Arial", 36, FontStyle.Bold);
            g.DrawString(" DH CNTT ", fb, Brushes.Navy, 10, 30);

            Font fc = new Font(fb, FontStyle.Bold | FontStyle.Italic);
            g.DrawString(" DH CNTT ", fc, Brushes.Orchid, 10, 80);

            Font fd = new Font("Impact", 1, GraphicsUnit.Inch);
            g.DrawString(" DH CNTT ", fd, Brushes.HotPink, 10, 120);

        }
    }
}
