using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22521405_HaPhuThinh
{
    public partial class FormThem : Form
    {        
        public event EventHandler Form2BiAn;
        public string[] value { get; set; }
        public bool isDone { get; set; }
        private string theloai;
        public FormThem()
        {
            InitializeComponent();
            this.isDone = false;
            this.VisibleChanged += FormThem_VisibleChanged;
        }

        private void FormThem_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                // Kích hoạt sự kiện khi Form 2 không còn là visible
                Form2BiAn?.Invoke(this, EventArgs.Empty);
            }
        }

        public void enableForm2()
        {
            this.Visible = true;
            this.isDone = false;
        }
        public void disableForm2()
        {
            this.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string[] mangChuoi = Array.Empty<string>();
                mangChuoi = mangChuoi.Append(mssv_textbox.Text).ToArray();
                mangChuoi = mangChuoi.Append(name_textbox.Text).ToArray();
                mangChuoi = mangChuoi.Append(theloai).ToArray();
                mangChuoi = mangChuoi.Append(diemtb_textbox.Text).ToArray();
                value = mangChuoi;
                this.isDone = true;
                disableForm2();
            }
        }
        public bool Check()
        {
            if (mssv_textbox.Text == "" || name_textbox.Text == "" || theloai == "" || diemtb_textbox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            disableForm2();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.theloai = comboBox1.SelectedItem.ToString();
        }
    }
}
