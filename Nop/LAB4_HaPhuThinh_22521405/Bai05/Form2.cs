using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form2 : Form
    {
        // Sự kiện để thông báo khi Form 2 đóng
        public event EventHandler Form2BiAn;
        public string[] value { get; set; }
        public bool isDone { get; set; }
        private string khoa;
        public void enableForm2()
        {
            this.Visible = true;
            this.isDone = false;
        }
        public void disableForm2()
        {
            this.Visible = false;
        }
        public Form2()
        {
            InitializeComponent();
            this.isDone = false;
            this.VisibleChanged += Form2_VisibleChanged;
        }
        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu Visible chuyển sang false
            if (!this.Visible)
            {
                // Kích hoạt sự kiện khi Form 2 không còn là visible
                Form2BiAn?.Invoke(this, EventArgs.Empty);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string[] mangChuoi = Array.Empty<string>();
                mangChuoi = mangChuoi.Append(mssv_textbox.Text).ToArray();
                mangChuoi = mangChuoi.Append(name_textbox.Text).ToArray();
                mangChuoi = mangChuoi.Append(khoa).ToArray();
                mangChuoi = mangChuoi.Append(diemtb_textbox.Text).ToArray();
                value = mangChuoi;
                this.isDone = true;
                disableForm2();
            }
        }
        public bool Check()
        {
            if (mssv_textbox.Text == "" || name_textbox.Text == "" || khoa == "" || diemtb_textbox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            disableForm2();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.khoa = comboBox1.SelectedItem.ToString();
        }
    }
}
