using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
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
            CultureInfo englishCulture = new CultureInfo("en-US");
            string formattedDateTime = currentDateTime.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt", englishCulture);
            // Hiển thị ngày giờ trên Label
            label1.Text = formattedDateTime;
        }
    }
}
