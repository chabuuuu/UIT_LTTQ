using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1_FontList
{
    public partial class FontList : Form
    {
        public FontList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các font có sẵn trên hệ thống
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFonts.Families;

            // Liệt kê và vẽ mỗi font
            /*foreach (FontFamily fontFamily in fontFamilies)
            {
                // Tạo font từ FontFamily
                Font font = new Font(fontFamily, 12);

                // Tạo một label để hiển thị font
                Label label = new Label();
                label.Text = font.Name.ToString();
                label.Font = font;

                // Thêm label vào flowLayoutPanel để hiển thị danh sách
                flowLayoutPanel1.Controls.Add(label);
            }*/

            /*
            Font font;
            int k = 0;
            int m = 10;
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {
                font = new Font(FontFamily.Families[i], 10);
                g.DrawString(FontFamily.Families[i].Name, font, Brushes.Black, m, k);
                k = k + 20;
                if (k >= this.Height)
                {
                    k = 0;
                    m = m + 250;
                }
            }*/

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            FontFamily[] fontFamilies = installedFonts.Families;
            Graphics g = e.Graphics;
            Font font;
            int k = 0;
            int m = 10;
            foreach (FontFamily fontFamily in fontFamilies)
            {
                font = new Font(fontFamily, 10);


                /*
                // Tạo font từ FontFamily
                Font font = new Font(fontFamily, 12);

                // Tạo một label để hiển thị font
                Label label = new Label();
                label.Text = font.Name.ToString();
                label.Font = font;
                */

                g.DrawString(fontFamily.Name, font, Brushes.Black, m, k);
                k = k + 20;


                if (k >= this.Height)
                {
                    k = 0;
                    m = m + 250;
                }
            }
        }
    }
}
