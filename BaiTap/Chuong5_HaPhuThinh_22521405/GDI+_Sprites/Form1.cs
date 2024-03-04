using System.Collections.Generic;

namespace GDI__Sprites
{
    public partial class Form1 : Form
    {
        Image player;
        List<string> playerMovements = new List<string>();
        int steps = 0;
        int slowDownFrameRate = 0;
        bool goLeft, goRight, goUp, goDown;
        int playerX;
        int playerY;
        int playerHeight = 100;
        int playerWidth = 100;
        int playerSpeed = 8;
        public Form1()
        {
            InitializeComponent();
            SetUp();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(player, playerX, playerY, playerWidth, playerHeight);
        }
        private void TimerEvent(object sender, EventArgs e)
        {
            if (goLeft && playerX > 0)
            {
                playerX -= playerSpeed;
                AnimatePlayer(4, 7);
            }
            else if (goRight && playerX + playerWidth < this.ClientSize.Width)
            {
                playerX += playerSpeed;
                AnimatePlayer(8, 11);
            }
            else if (goUp && playerY > 0)
            {
                playerY -= playerSpeed;
                AnimatePlayer(12, 15);
            }
            else if (goDown && playerY + playerHeight < this.ClientSize.Height)
            {
                playerY += playerSpeed; AnimatePlayer(0, 3);
            }
            else
            {
                AnimatePlayer(0, 0);
            }
            this.Invalidate();
            label1.Text = "Movements: " + steps;
        }
        private void SetUp()
        {
            this.BackgroundImage = Image.FromFile("bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
            // load the player files to the list 
            playerMovements = Directory.GetFiles("player", "*.png").ToList();
            player = Image.FromFile(playerMovements[0]);
        }
        private void AnimatePlayer(int start, int end)
        {
            slowDownFrameRate += 1;
            if (slowDownFrameRate == 4)
            {
                steps++;
                slowDownFrameRate = 0;
            }
            if (steps > end || steps < start)
            {
                steps = start;
            }
            player = Image.FromFile(playerMovements[steps]);
        }
    }
}