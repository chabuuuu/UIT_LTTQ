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

namespace SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream myStream = saveFileDialog1.OpenFile();
                StreamWriter writer = new StreamWriter(myStream);
                writer.Write(textBox1.Text);
                writer.Close();
                myStream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file|*.txt";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                Stream myStream = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(myStream);
                textBox1.Text = reader.ReadToEnd();
                myStream.Close() ;
                reader.Close();
            }
        }
    }
}
