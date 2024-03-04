using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBoxExample_SelectedIndexChanged
{
    public partial class Form1 : Form
    {
        private string selectedList = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = checkedListBox1.CheckedItems;
            string str = "Checked items: \n";
            foreach (object item in items)
            {
                str += item.ToString();
                str += "\n";
            }
            this.selectedList = str;
            MessageBox.Show(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will install: " +  this.selectedList);
        }
    }
}
