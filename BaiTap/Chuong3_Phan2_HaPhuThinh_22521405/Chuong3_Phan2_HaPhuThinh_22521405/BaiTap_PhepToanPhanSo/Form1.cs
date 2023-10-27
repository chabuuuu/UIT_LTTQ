using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap_PhepToanPhanSo
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCong_Click(object sender, EventArgs e)
        {
            try
            {
                PhanSo phanso1 = this.readPhanSo1();
                PhanSo phanso2 = this.readPhanSo2();
                PhanSo ketqua = phanso1 + phanso2;
                this.showKetQua(ketqua);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }
        private PhanSo readPhanSo1()
        {
            int tuPhanSo1 = int.Parse(txtTuPhanSo1.Text);
            int mauPhanSo1 = int.Parse(txtMauPhanSo1.Text);
            if (mauPhanSo1 == 0)
            {
                throw new Exception("Mẫu phân số 1 phải khác 0");
            }
            return new PhanSo(tuPhanSo1, mauPhanSo1);
        }
        private PhanSo readPhanSo2()
        {
            int tuPhanSo2 = int.Parse(txtTuPhanSo2.Text);
            int mauPhanSo2 = int.Parse(txtMauPhanSo2.Text);
            if (mauPhanSo2 == 0)
            {
                throw new Exception("Mẫu phân số 2 phải khác 0");
            }
            return new PhanSo(tuPhanSo2, mauPhanSo2);
        }
        private void showKetQua(PhanSo ketqua)
        {
            txtTuKetQua.Text = ketqua.getTu().ToString();
            txtMauKetQua.Text = ketqua.getMau().ToString();
        }

        private void BtnTru_Click(object sender, EventArgs e)
        {
            try {
                PhanSo phanso1 = this.readPhanSo1();
                PhanSo phanso2 = this.readPhanSo2();
                PhanSo ketqua = phanso1 - phanso2;
                this.showKetQua(ketqua);
            } catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void BtnNhan_Click(object sender, EventArgs e)
        {
            try {
                PhanSo phanso1 = this.readPhanSo1();
                PhanSo phanso2 = this.readPhanSo2();
                PhanSo ketqua = phanso1 * phanso2;
                this.showKetQua(ketqua);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void BtnChia_Click(object sender, EventArgs e)
        {
            try
            {
                PhanSo phanso1 = this.readPhanSo1();
                PhanSo phanso2 = this.readPhanSo2();
                PhanSo ketqua = phanso1 / phanso2;
                this.showKetQua(ketqua);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void txtMauPhanSo1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Length > 0)
            {
                if (int.Parse(control.Text) == 0)
                {
                    this.errorProvider1.SetError(control, "Mẫu phải khác 0");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void txtMauPhanSo2_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            if (control.Text.Length > 0)
            {
                if (int.Parse(control.Text) == 0)
                {
                    this.errorProvider1.SetError(control, "Mẫu phải khác 0");
                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.phepToanBox.Focus();
        }

        private void phepToanBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.phepToanBox.Text = "";
            if (e.KeyChar == '-')
            {
                this.BtnTru_Click(sender, e);
            }
            if (e.KeyChar == '+')
            {
                this.BtnCong_Click(sender, e);
            }
            if (e.KeyChar == '*')
            {
                this.BtnNhan_Click(sender, e);
            }
            if (e.KeyChar == '/')
            {
                this.BtnChia_Click(sender, e);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtTuKetQua.Text = "";
            txtMauKetQua.Text = "";
            txtTuPhanSo1.Text = "";
            txtMauPhanSo1.Text = "";
            txtMauPhanSo2.Text = "";
            txtTuPhanSo2.Text = "";
            phepToanBox.Text = "";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    class PhanSo
    {
        private static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            if (a.mau == b.mau)
            {
                return new PhanSo(a.tu + b.tu, a.mau);
            }
            int tu1 = a.tu * b.mau;
            int tu2 = b.tu * a.mau;
            return new PhanSo(tu1 + tu2, a.mau * b.mau);
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            if (a.mau == b.mau)
            {
                return new PhanSo(a.tu - b.tu, a.mau);
            }
            int tu1 = a.tu * b.mau;
            int tu2 = b.tu * a.mau;
            return new PhanSo(tu1 - tu2, a.mau * b.mau);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int newTu = a.tu * b.tu;
            int newMau = a.mau * b.mau;
            int gcd = GCD(newMau, newTu);
            return new PhanSo(newTu / gcd, newMau / gcd);
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            int newTu = a.tu * b.mau;
            int newMau = a.mau * b.tu;
            int gcd = GCD(newMau, newTu);
            return new PhanSo(newTu / gcd, newMau / gcd);
        }
        public PhanSo(int tu, int mau)
        {
            int gcd = GCD(tu, mau);
            this.tu = tu / gcd;
            this.mau = mau / gcd;
        }
        public void xuat()
        {
            Console.WriteLine("{0}/{1}", this.tu, this.mau);
        }
        public int getTu()
        {
            return this.tu;
        }
        public int getMau()
        {
            return this.mau;
        }

        private int tu;
        private int mau;
    }
}
