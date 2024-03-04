using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTGame_VongTron
{
    public partial class Form1 : Form
    {
        private const int FormWidth = 400;
        private const int FormHeight = 320;
        private const int CircleDiameter = FormHeight / 8;
        private const int GameTimeInSeconds = 15;

        private int score;
        private bool isGameRunning;
        private Random random;
        private Thread gameThread;
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeGame()
        {
            random = new Random();
            isGameRunning = false;
            score = 0;

            this.Size = new Size(FormWidth, FormHeight);
            this.BackColor = Color.White;

            gameThread = new Thread(new ThreadStart(RunGame));
        }

        private void RunGame()
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(GameTimeInSeconds);

            while (DateTime.Now < endTime)
            {
                int circleCount = 5 + score; // Increase circle count based on score

                for (int i = 0; i < circleCount; i++)
                {
                    int x = random.Next(FormWidth - CircleDiameter);
                    int y = random.Next(FormHeight - CircleDiameter);
                    Color circleColor = (i == 0) ? Color.Red : GetRandomCircleColor();

                    DrawCircle(x, y, circleColor);
                }

                Thread.Sleep(500); // Sleep for 500 milliseconds
                ClearForm();
            }

            MessageBox.Show($"Game Over! Your score is: {score}", "Game Over");
            isGameRunning = false;
        }

        private Color GetRandomCircleColor()
        {
            Color[] colors = { Color.Blue, Color.Green, Color.Yellow };
            return colors[random.Next(colors.Length)];
        }

        private void DrawCircle(int x, int y, Color color)
        {
            using (Graphics g = this.CreateGraphics())
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, new Rectangle(x, y, CircleDiameter, CircleDiameter));
            }
        }

        private void ClearForm()
        {
            using (Graphics g = this.CreateGraphics())
            {
                g.Clear(this.BackColor);
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (isGameRunning)
            {
                Color clickedColor = GetPixelColor(e.Location);

                if (clickedColor == Color.Red)
                {
                    score++;
                    label1.Text=score.ToString();
                }
            }
        }

        private Color GetPixelColor(Point location)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            return bitmap.GetPixel(location.X, location.Y);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!isGameRunning)
            {
                isGameRunning = true;
                score = 0;
                gameThread.Start();
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            label1.Text=score.ToString();
        }
    }
}

