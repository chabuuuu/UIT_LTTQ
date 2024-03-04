using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleDocumentInterfaceExample_PixViewXemAnh
{
    public partial class Form2 : Form
    {
        public Form2(string imageFile)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(imageFile);
            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1);
        }
        public Form2()
        {
            InitializeComponent();
        }
    }
}
