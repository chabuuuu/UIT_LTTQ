using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace congtru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int sum = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
                MessageBox.Show("Sum is: " + sum.ToString());

            }catch {
                MessageBox.Show("Error!");
            }
        }
        */
        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            
                if (control.Text.Length > 0)
                {
                    if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                    {
                        this.errorProvider1.SetError(control, "This is not a valid number");
                    }
                    else
                    {
                        this.errorProvider1.Clear();
                    }
                }

            
           
           
        }
        */

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int sum = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
                MessageBox.Show("Sum is: " + sum.ToString());

            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.Text.Length > 0)
            {
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.Text.Length > 0)
            {
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.Text.Length > 0)
            {
                if (!Char.IsDigit(control.Text[control.Text.Length - 1]))
                {
                    this.errorProvider1.SetError(control, "This is not a valid number");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LBMonHoc.Items.IndexOf(AddTextBox.Text) >= 0)
            {
                LBMonHoc.SelectedItem = AddTextBox.Text;
            }
            else
            {
                if (AddTextBox.Text.Length > 0)
                {
                    LBMonHoc.Items.Add(AddTextBox.Text);
                }
            }
        }
        */
    }
}
