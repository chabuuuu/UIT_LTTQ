using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private Ball x;
        private Player player;
        public static int score = 0;

        internal Ball X { get => x; set => x = value; }
        public Player Player { get => player; set => player = value; }

        public Form1()
        {
            InitializeComponent();
            x = new Ball(new Point(0,50));
            player = new Player(new Point(this.Width/2,this.Height));
            player.location.Y-=player.bitmap.Height/6;
            timerPlayer.Enabled = true;
            timerBall.Enabled = true;
            label2.Text = "0";
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            x.Draw(g);
            player.Draw(g);
        }

        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            if(left)
            {
                if(player.location.X>= 0)
                {
                    player.location.X -= 10;
                }
            }
            if(right)
            {
                if (player.location.X < this.ClientSize.Width - player.bitmap.Width/10)
                {
                    player.location.X += 10;
                }
            }
            this.Refresh();
        }
        private bool left = false;
        private bool right = false;
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Left)
            {
                left = true;
                right = false;
            }
            if(e.KeyData == Keys.Right)
            {
                left = false;
                right = true;
            }
        }
        private bool gameover = false;
        private void timerBall_Tick(object sender, EventArgs e)
        {
            x.Down();
            if ((x.Location.X - player.location.X >= 0)&& x.Location.X <player.location.X+player.bitmap.Width/10&& x.Location.Y == player.location.Y)
            {
                score += 1;
                label2.Text = score.ToString();
                Restart();
            }
            if(x.Location.Y>= this.ClientSize.Height)
            {

                timerBall.Stop();
                timerPlayer.Stop();
                if (MessageBox.Show("Game Over!") == DialogResult.OK)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.ShowDialog();
                    this.Close();
                };
                
            }
            this.Refresh();
        }
        void Restart()
        {
            Random random = new Random();
            x.Location = new Point(random.Next(0,this.ClientSize.Width-x.bitmap.Width/10),0);
            this.Refresh();
        }
    }
}
