using System.Drawing;
using System.Windows.Forms;

namespace CodeThemControlNumericUpDown_AddNumericUpDown
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            //Code them Control NumericUpDown
            NumericUpDown numUpDn = new NumericUpDown();
            numUpDn.Location = new Point(50, 50);
            numUpDn.Size = new Size(100, 25);
            numUpDn.Hexadecimal = true;
            numUpDn.Minimum = 0;
            numUpDn.Maximum = 255;
            numUpDn.Value = 0xFF;
            numUpDn.Increment = 1;
            Controls.Add(numUpDn);
            // hiển thị dạng hexa 
            // giá trị nhỏ nhất 
            // giá trị lớn nhất 
            // giá trị khởi tạo 
            // bước tăng/giảm 
            // thêm control vào ds control của form 

        }



        #endregion
    }
}

