using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendarExample_AddMonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime date1 = monthCalendar1.SelectionStart;
            DateTime date2 = monthCalendar1.SelectionEnd;
            label1.Text = "Ngày nhận phòng: " + date1.ToString() + "\n Ngày trả phòng: " + date2.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date1 = monthCalendar1.SelectionStart;
            DateTime date2 = monthCalendar1.SelectionEnd;
            label1.Text = "Ngày nhận phòng: " + date1.ToString() + "\n Ngày trả phòng: " + date2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đặt phòng thành công!");
        }
    }
}
