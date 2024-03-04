using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        [Category("Data"), Description("User Name")]
        public string UserName
        {
            get { return textBox1.Text;  }
            set { textBox1.Text = value; }
        }
        [Category("Data"), Description("Password")]
        public string Password {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }


    }
}
