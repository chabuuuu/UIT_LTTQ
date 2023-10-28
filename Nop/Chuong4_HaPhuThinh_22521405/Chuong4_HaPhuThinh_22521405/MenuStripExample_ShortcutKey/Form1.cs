using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStripExample_ShortcutKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut Open");
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut Cascade");
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut TileVertical");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
