using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoListBox_KiemTraChuoiCoTrongListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (LBMonHoc.Items.IndexOf(txtMonHoc.Text) >= 0)
            {
                LBMonHoc.SelectedItem = txtMonHoc.Text;
            }
            else
            {
                if (txtMonHoc.Text.Length > 0)
                {
                    LBMonHoc.Items.Add(txtMonHoc.Text);
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
