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
    public partial class FormGioiThieu : Form
    {
        public event EventHandler FormGioiThieuBiAn;
        public bool isDone { get; set; }
        public string[] value { get; set; }


        public FormGioiThieu()
        {
            InitializeComponent();
            this.isDone = false;
            this.VisibleChanged += FormGioiThieu_VisibleChanged;

        }

        private void FormGioiThieu_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                // Kích hoạt sự kiện khi Form 2 không còn là visible
                FormGioiThieuBiAn?.Invoke(this, EventArgs.Empty);
            }
        }

        public void enableFormGioiThieu()
        {
            this.Visible = true;
            this.isDone = false;
        }
        public void disableFormGioiThieu()
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.disableFormGioiThieu();
        }
    }
}
