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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OpenFileDialogExample_DungToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "C# source code|*.cs";
            if (result == DialogResult.OK)
            {
                string file = File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = file;
            }
        }
    }
}
