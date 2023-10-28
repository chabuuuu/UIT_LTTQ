using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxExample_MinhHoaMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Không kết nối CSDL được, bạn có muốn thử lại?",
                "Xác nhận", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else
            {
                while (result != DialogResult.Cancel)
                {
                    result = MessageBox.Show("Không kết nối CSDL được, bạn có muốn thử lại?",
    "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Không truy cập, tập tin không tồn tại!", 
                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tên truy cập, hoặc mật khẩu sai! Nhập lại?",
    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }
    }
}
