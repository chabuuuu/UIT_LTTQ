using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Double ResultValue = 0;            
        String OperationPerformed = "";    
        bool IsOperationPerformed = false; 

        Button number00, number01, number02, number03, number04, number05, number06, number07, number08, number09;
        Button Add, Sub, Mul, Div, Result;
        Button Dos;
        Button C, CE, Backspace, MC, MR, MS, M;
        Button Negative, Percent, Sqrt, Div1;
        Label lbShow;
        TextBox txbShow;
        String temp;
        Label Space;

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Máy tính (tương tự Calculator của Windows) với các chức năng \r\ncơ bản +, -, *, /, căn bậc 2, số nhớ,…\r\n");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void type1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            number07.Location = new Point(60, 140);
            number04.Location = new Point(60, 180);
            number01.Location = new Point(60, 220);
            number00.Location = new Point(60, 260);
            number08.Location = new Point(100, 140);
            number05.Location = new Point(100, 180);
            number02.Location = new Point(100, 220);
            number09.Location = new Point(140, 140);
            number06.Location = new Point(140, 180);
            number03.Location = new Point(140, 220);
            Dos.Location = new Point(140, 260);
            Div.Location = new Point(180, 140);
            Mul.Location = new Point(180, 180);
            Sub.Location = new Point(180, 220);
            Add.Location = new Point(180, 260);
            Result.Location = new Point(220, 260);
            Sqrt.Location = new Point(220, 140);
            Percent.Location = new Point(220, 180);
            Div1.Location = new Point(220, 220);
            Negative.Location = new Point(100, 260);
            Backspace.Location = new Point(60, 100);
            CE.Location = new Point(145, 100);
            C.Location = new Point(202, 100);
            M.Location = new Point(20, 260);
            MS.Location = new Point(20, 220);
            MR.Location = new Point(20, 180);
            MC.Location = new Point(20, 140);
            Space.Location = new Point(20, 100);
            this.Invalidate();
        }

        private void type2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            number07.Location = new Point(20, 100);
            number04.Location = new Point(20, 140);
            number01.Location = new Point(20, 180);
            number00.Location = new Point(20, 220);
            number08.Location = new Point(60, 100);
            number05.Location = new Point(60, 140);
            number02.Location = new Point(60, 180);
            number09.Location = new Point(100, 100);
            number06.Location = new Point(100, 140);
            number03.Location = new Point(100, 180);
            Dos.Location = new Point(100, 220);
            Div.Location = new Point(140, 100);
            Mul.Location = new Point(140, 140);
            Sub.Location = new Point(140, 180);
            Add.Location = new Point(140, 220);
            Result.Location = new Point(180, 220);
            Sqrt.Location = new Point(180, 100);
            Percent.Location = new Point(180, 140);
            Div1.Location = new Point(180, 180);
            Negative.Location = new Point(60, 220);
            Backspace.Location = new Point(60, 260);
            CE.Location = new Point(145, 260);
            C.Location = new Point(202, 260);
            M.Location = new Point(220, 220);
            MS.Location = new Point(220, 180);
            MR.Location = new Point(220, 140);
            MC.Location = new Point(220, 100);
            Space.Location = new Point(20, 260);
            this.Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            Button_Numbers();
            Button_Operation();
            Button_Memories();
            Show();
            this.AcceptButton = Result;
        }

        void Button_Numbers()
        {

            number00 = new Button(); number01 = new Button(); number02 = new Button(); number03 = new Button();
            number04 = new Button(); number05 = new Button(); number06 = new Button(); number07 = new Button();
            number08 = new Button(); number09 = new Button();
            Dos = new Button();




            number07.Location = new Point(60, 140);
            number07.Size = new Size(35, 35);
            number07.Text = "7";
            number07.Parent = this;
            number07.Click += Btnbutton_Click;

            number04.Location = new Point(60, 180);
            number04.Size = new Size(35, 35);
            number04.Text = "4";
            number04.Parent = this;
            number04.Click += Btnbutton_Click;

            number01.Location = new Point(60, 220);
            number01.Size = new Size(35, 35);
            number01.Text = "1";
            number01.Parent = this;
            number01.Click += Btnbutton_Click;

            number00.Location = new Point(60, 260);
            number00.Size = new Size(35, 35);
            number00.Text = "0";
            number00.Parent = this;
            number00.Click += Btnbutton_Click;

            number08.Location = new Point(100, 140);
            number08.Size = new Size(35, 35);
            number08.Text = "8";
            number08.Parent = this;
            number08.Click += Btnbutton_Click;

            number05.Location = new Point(100, 180);
            number05.Size = new Size(35, 35);
            number05.Text = "5";
            number05.Parent = this;
            number05.Click += Btnbutton_Click;

            number02.Location = new Point(100, 220);
            number02.Size = new Size(35, 35);
            number02.Text = "2";
            number02.Parent = this;
            number02.Click += Btnbutton_Click;

            number09.Location = new Point(140, 140);
            number09.Size = new Size(35, 35);
            number09.Text = "9";
            number09.Parent = this;
            number09.Click += Btnbutton_Click;

            number06.Location = new Point(140, 180);
            number06.Size = new Size(35, 35);
            number06.Text = "6";
            number06.Parent = this;
            number06.Click += Btnbutton_Click;

            number03.Location = new Point(140, 220);
            number03.Size = new Size(35, 35);
            number03.Text = "3";
            number03.Parent = this;
            number03.Click += Btnbutton_Click;

            Dos.Location = new Point(140, 260);
            Dos.Size = new Size(35, 35);
            Dos.Text = ".";
            Dos.Parent = this;
            Dos.Click += Btnbutton_Click;
        }

        void Button_Operation()
        {
            Div = new Button(); Mul = new Button(); Add = new Button(); Sub = new Button();
            Result = new Button();

            Negative = new Button();

            Percent = new Button();

            Sqrt = new Button();

            Div1 = new Button();
            C = new Button(); CE = new Button(); Backspace = new Button();



            Div.Location = new Point(180, 140);
            Div.Size = new Size(35, 35);
            Div.Text = "/";
            Div.Parent = this;
            Div.Click += Operator_Click;

            Mul.Location = new Point(180, 180);
            Mul.Size = new Size(35, 35);
            Mul.Text = "*";
            Mul.Parent = this;
            Mul.Click += Operator_Click;


            Sub.Location = new Point(180, 220);
            Sub.Size = new Size(35, 35);
            Sub.Text = "-";
            Sub.Parent = this;
            Sub.Click += Operator_Click;

            Add.Location = new Point(180, 260);
            Add.Size = new Size(35, 35);
            Add.Text = "+";
            Add.Parent = this;
            Add.Click += Operator_Click;

            Result.Location = new Point(220, 260);
            Result.Size = new Size(35, 35);
            Result.Text = "=";
            Result.Parent = this;
            Result.Click += Result_Click;

            Sqrt.Location = new Point(220, 140);
            Sqrt.Size = new Size(35, 35);
            Sqrt.Text = "Sqrt";
            Sqrt.Parent = this;
            Sqrt.Click += Sqrt_Click;

            Percent.Location = new Point(220, 180);
            Percent.Size = new Size(35, 35);
            Percent.Text = "%";
            Percent.Parent = this;
            Percent.Click += Percent_Click;

            Div1.Location = new Point(220, 220);
            Div1.Size = new Size(35, 35);
            Div1.Text = "1/x";
            Div1.Parent = this;
            Div1.Click += Div1_Click;



            Negative.Location = new Point(100, 260);
            Negative.Size = new Size(35, 35);
            Negative.Text = "+/-";
            Negative.Parent = this;
            Negative.Click += Negative_Click;

            Backspace.Location = new Point(60, 100);
            Backspace.Size = new Size(80, 35);
            Backspace.Text = "BackSpace";
            Backspace.Parent = this;
            Backspace.Click += Backspace_Click;

            CE.Location = new Point(145, 100);
            CE.Size = new Size(52, 35);
            CE.Text = "CE";
            CE.Parent = this;
            CE.Click += CE_Click;


            C.Location = new Point(202, 100);
            C.Size = new Size(52, 35);
            C.Text = "C";
            C.Parent = this;
            C.Click += C_Click;
        }


        void Button_Memories()
        {
            M = new Button(); MC = new Button(); MR = new Button(); MS = new Button();
            Space = new Label();

            M.Location = new Point(20, 260);
            M.Size = new Size(35, 35);
            M.Text = "M+";
            M.Parent = this;
            


            MS.Location = new Point(20, 220);
            MS.Size = new Size(35, 35);
            MS.Text = "MS";
            MS.Parent = this;
           



            MR.Location = new Point(20, 180);
            MR.Size = new Size(35, 35);
            MR.Text = "MR";
            MR.Parent = this;
            



            MC.Location = new Point(20, 140);
            MC.Size = new Size(35, 35);
            MC.Text = "MC";
            MC.Parent = this;
           


            Space.Location = new Point(20, 100);
            Space.Size = new Size(35, 35);
            Space.Text = "";
            Space.Parent = this;
            Space.BorderStyle = BorderStyle.Fixed3D;

        }


        void Show()
        {
            lbShow = new Label();
            lbShow.Location = new Point(20, 40);
            lbShow.Size = new Size(230, 20);
            lbShow.Parent = this;
            lbShow.Text = number00.Text;
            lbShow.BorderStyle = BorderStyle.Fixed3D;

            txbShow = new TextBox();
            txbShow.Location = new Point(20, 65);
            txbShow.Size = new Size(230, 55);
            txbShow.Parent = this;
            txbShow.Text = number00.Text;
            txbShow.BorderStyle = BorderStyle.Fixed3D;

            
        }

      
        private void Btnbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (txbShow.Text == "0" || (IsOperationPerformed))
            {
                txbShow.Clear();
            }

            IsOperationPerformed = false;


            if (button.Text == ".")
            {

                if (txbShow.Text == "")
                {
                    txbShow.Text = "0" + button.Text;
                }
                
                if (!txbShow.Text.Contains("."))
                    txbShow.Text = txbShow.Text + button.Text;

            }
            else
            {
                
                if (button.Text == "+/-")
                {
                    txbShow.Text = Convert.ToString(-1 * Convert.ToDouble(txbShow.Text));
                }
                txbShow.Text = txbShow.Text + button.Text;

            }
            //           
        }

        public void Result_Click(object sender, EventArgs e)
        {

            temp = txbShow.Text;
            if (OperationPerformed != "")
            {
                try
                {
                    switch (OperationPerformed)
                    {

                        case "+":

                            txbShow.Text = (ResultValue + Double.Parse(txbShow.Text)).ToString();
                            lbShow.Text += " " + temp;
                            break;
                        case "-":
                            txbShow.Text = (ResultValue - Double.Parse(txbShow.Text)).ToString();
                            lbShow.Text += " " + temp;
                            break;
                        case "*":
                            txbShow.Text = (ResultValue * Double.Parse(txbShow.Text)).ToString();
                            lbShow.Text += " " + temp;
                            break;
                        case "/":
                            txbShow.Text = (ResultValue / Double.Parse(txbShow.Text)).ToString();
                            lbShow.Text += " " + temp;
                            break;

                        default:
                            break;


                    }
                }
                catch
                {

                    MessageBox.Show("Lỗi!", "Error");

                }
               
                OperationPerformed = "";
                IsOperationPerformed = false;
            }



        }

        
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            OperationPerformed = button.Text;


            ResultValue = Convert.ToDouble(txbShow.Text);
            lbShow.Text = ResultValue + " " + OperationPerformed;

            IsOperationPerformed = true;
            txbShow.Clear();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            txbShow.Text = "0";
            ResultValue = 0;
            lbShow.Text = "";
        }

   
        private void C_Click(object sender, EventArgs e)
        {
            txbShow.Text = "0";
        }

        
        private void Backspace_Click(object sender, EventArgs e)
        {
            String str = txbShow.Text;
            int len;
            len = str.Length;
            txbShow.Text = "";
            for (int i = 0; i < len - 1; i++)
            {
                txbShow.Text = txbShow.Text + Convert.ToString(str[i]);
            }
        }

     
        private void Sqrt_Click(object sender, EventArgs e)
        {
            string temp = txbShow.Text;
            try
            {
                txbShow.Text = (Math.Sqrt(Double.Parse(txbShow.Text))).ToString();
            }
            catch
            {
                MessageBox.Show("Phải là một số dương!", "Error");
                txbShow.Text = temp;
            }
        }

      
        private void Div1_Click(object sender, EventArgs e)
        {
            txbShow.Text = (1 / (Double.Parse(txbShow.Text))).ToString();
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            txbShow.Text = (-1.0 * (Double.Parse(txbShow.Text))).ToString();
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            txbShow.Text = (.01 * (Double.Parse(txbShow.Text))).ToString();
        }
    }
}
