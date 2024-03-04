using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarExample_IncreaseOnButtonClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label1.Text = progressBar1.Value.ToString() + "%";
        }
    }
}
