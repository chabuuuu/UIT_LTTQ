using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxExample_MicrosoftWordClone
{
    public partial class Form2 : Form
    {
        public Form2(String docFile)
        {
            InitializeComponent();
            richTextBox1.LoadFile(docFile);
            Text = docFile.Substring(docFile.LastIndexOf('/') + 1);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Red":
                    richTextBox1.SelectionColor = Color.Red;
                    break;
                case "Blue":
                    richTextBox1.SelectionColor = Color.Blue;
                    break;
                case "Green":
                    richTextBox1.SelectionColor = Color.Green;
                    break;
                default:
                    break;
            }

        }
    }
}
