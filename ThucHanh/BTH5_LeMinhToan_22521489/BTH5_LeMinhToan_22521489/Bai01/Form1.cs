using System.Reflection;
using System.Runtime.Versioning;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<MySprite> sprites;
        int nSprites;

        private void Form1_Load(object sender, EventArgs e)
        {
            sprites = new List<MySprite>();
            nSprites = 1;
            Bitmap[] bmp;
            bmp = new Bitmap[8];
            bmp[0] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-1.png");
            bmp[1] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-2.png");
            bmp[2] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-3.png");
            bmp[3] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-4.png");
            bmp[4] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-5.png");
            bmp[5] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-6.png");
            bmp[6] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-7.png");
            bmp[7] = new Bitmap("D:\\Workspace\\UIT\\UIT_LTTQ\\Sprites\\Sprites\\frame-8.png");
            for (int i = 0; i < nSprites; i++)
            {
                sprites.Add(new MySprite(bmp, 9 * 30, 2 * 50));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < nSprites; i++)
            {
                sprites[i].Update();
            }
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < nSprites; i++)
            {
                sprites[i].Draw(g);
            }
        }


    }
}