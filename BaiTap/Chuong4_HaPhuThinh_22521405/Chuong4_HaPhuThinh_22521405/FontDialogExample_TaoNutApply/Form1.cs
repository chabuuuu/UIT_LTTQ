using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontDialogExample_TaoNutApply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void ChangeFont(object sender, EventArgs e)
        {
            label1.ForeColor = fontDialog1.Color;
            label1.Font = fontDialog1.Font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Color = label1.ForeColor;
            fontDialog1.Font = label1.Font;
            fontDialog1.ShowApply = true;
            fontDialog1.Apply += new EventHandler(ChangeFont);
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;
            }
        }
    }
}
