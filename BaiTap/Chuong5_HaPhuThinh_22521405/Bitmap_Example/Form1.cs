using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Image image = Image.FromFile("C:/Users/Ha Phu/Pictures/test.bitmap");
            // Tạo một bitmap từ một file
            Bitmap bitmap1 = new Bitmap("C:/Users/Ha Phu/Pictures/test.bitmap");
            // Tạo một bitmap từ một đối tượng Image
            Bitmap bitmap2 = new Bitmap(image);
            // Tạo mộ bitmap với size
            Bitmap curBitmap3 = new Bitmap(image, new Size(200, 100));
            // Tạo một bitmap không có dữ liệu ảnh
            Bitmap curBitmap4 = new Bitmap(200, 100);

        }
    }
}
