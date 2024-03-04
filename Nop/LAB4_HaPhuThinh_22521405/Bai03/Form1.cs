using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Multimedia_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            this.UpdateDateTimeLabel();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Gọi hàm cập nhật ngày giờ
            UpdateDateTimeLabel();
        }
        private void UpdateDateTimeLabel()
        {
            // Lấy ngày giờ hiện tại
            DateTime currentDateTime = DateTime.Now;
            string timeText = "Hôm nay là ngày " + currentDateTime.ToString("dd/MM/yyyy") +
                " - Bây giờ là " + currentDateTime.ToString("HH:mm:ss");
            // Hiển thị ngày giờ trên Label
            toolStripStatusLabel1.Text = timeText;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = dlg.FileName; 
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
