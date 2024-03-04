using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxExample_ShopBuy
{
    public partial class Form1 : Form
    {
        private int cost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void increaseCartCount()
        {
            int count = int.Parse(countLabel.Text);
            count++;
            countLabel.Text = count.ToString();
        }

        private void decreaseCartCount()
        {
            int count = int.Parse(countLabel.Text);
            count--;
            countLabel.Text = count.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            int costLabel = int.Parse(label1.Text.Replace(".", "").Replace("VND", ""));
            if (checkBox1.Checked)
            {
                this.increaseCartCount();
                this.cost += costLabel;
            }
            else
            {
                this.decreaseCartCount();
                this.cost -= costLabel;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int costLabel = int.Parse(label3.Text.Replace(".", "").Replace("VND", ""));
            if (checkBox2.Checked)
            {
                this.increaseCartCount();

                this.cost += costLabel;
            }
            else
            {
                this.decreaseCartCount();
                this.cost -= costLabel;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int costLabel = int.Parse(label7.Text.Replace(".", "").Replace("VND", ""));
            if (checkBox4.Checked)
            {
                this.increaseCartCount();

                this.cost += costLabel;
            }
            else
            {
                this.decreaseCartCount();
                this.cost -= costLabel;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int costLabel = int.Parse(label5.Text.Replace(".", "").Replace("VND", ""));
            if (checkBox3.Checked)
            {
                this.increaseCartCount();
                this.cost += costLabel;
            }
            else
            {
                this.decreaseCartCount();
                this.cost -= costLabel;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đặt mua thành công!\n Vui lòng thanh toán số tiền: " + this.cost.ToString() + " VND");
        }
    }
}
