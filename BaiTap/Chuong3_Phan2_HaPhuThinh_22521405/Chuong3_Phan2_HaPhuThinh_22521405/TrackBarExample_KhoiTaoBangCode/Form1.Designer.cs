using System.Drawing;
using System.Windows.Forms;

namespace TrackBarExample_KhoiTaoBangCode
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

            //Them trackbar bang code:
            TrackBar tb1 = new TrackBar();
            tb1.Location = new Point(10, 10);
            tb1.Size = new Size(250, 50);

            tb1.Minimum = 0;
            tb1.Maximum = 100;

            tb1.SmallChange = 1;
            tb1.LargeChange = 5;
            tb1.TickStyle = TickStyle.BottomRight;

            tb1.TickFrequency = 10;
            tb1.Value = 10;
            Controls.Add(tb1);
        }

        #endregion
    }
}

