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

namespace OpenFileDialogExample_KhongDungToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenFileDialog OFileDlg = new OpenFileDialog();
            OFileDlg.Multiselect = true;
            OFileDlg.Filter = "C# source code|*.cs";
            DialogResult result;
            result = OFileDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = File.ReadAllText(OFileDlg.FileName);
                textBox1.Text = file;
            }
        }


    }
}
