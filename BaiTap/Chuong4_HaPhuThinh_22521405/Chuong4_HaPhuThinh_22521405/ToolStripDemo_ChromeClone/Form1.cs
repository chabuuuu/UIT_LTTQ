using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStripDemo_ChromeClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://www.google.com/");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        private bool IsValidUrl(string url)
        {
            Uri result;
            return Uri.TryCreate(url, UriKind.Absolute, out result) && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsValidUrl(toolStripTextBox1.Text))
                {
                    webBrowser1.Navigate(toolStripTextBox1.Text);
                }
                else
                {
                    //MessageBox.Show(Uri.EscapeDataString(toolStripTextBox1.Text));
                    webBrowser1.Navigate("https://www.google.com/search?q=" + Uri.EscapeDataString(toolStripTextBox1.Text));
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
        }
    }
}
