using System.Drawing;
using System.Windows.Forms;
using System;

namespace CodeThemDateTimePicker_AddDateTimePicker
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

            //Code them DateTimePicker
            DateTimePicker DTPicker = new DateTimePicker();
            DTPicker.Location = new Point(40, 80);
            DTPicker.Size = new Size(160, 20);
            DTPicker.DropDownAlign = LeftRightAlignment.Right;
            DTPicker.Value = DateTime.Now;
            DTPicker.Format = DateTimePickerFormat.Custom;
            DTPicker.CustomFormat = "'Ngày' dd 'tháng' MM 'năm' yyyy";
            this.Controls.Add(DTPicker);
        }

        #endregion

    }
}

