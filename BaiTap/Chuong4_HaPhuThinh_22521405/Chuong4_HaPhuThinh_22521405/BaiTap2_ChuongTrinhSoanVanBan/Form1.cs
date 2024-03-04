using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2_ChuongTrinhSoanVanBan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ChangeFont(object sender, EventArgs e)
        {
            textBox1.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK )
            {
                System.Drawing.Color selectedColor = colorDialog1.Color;
                textBox1.ForeColor = selectedColor;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            fontDialog1.ShowApply = true;
            fontDialog1.Apply += new EventHandler(ChangeFont);
            if (fontDialog1.ShowDialog() == DialogResult.OK )
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.FileName = "MyName";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK )
            {
                Stream myStream = saveFileDialog1.OpenFile();
                StreamWriter writer = new StreamWriter( myStream );
                writer.Write(textBox1.Text);
                writer.Close();
                myStream.Close();
                MessageBox.Show("Save done!");
            }
        }
    }
}
