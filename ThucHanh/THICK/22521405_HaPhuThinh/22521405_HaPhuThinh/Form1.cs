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
    public partial class Form1 : Form
    {   
        public FormGioiThieu frm1 { get; set; }
        public FormThem frm { get; set; }
        private int count = 5;
        private bool IsSubItemsExists(ListViewItem item, string itemText)
        {
            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
            {
                if (subItem.Text == itemText)
                {
                    return true;
                }
            }
            return false;
        }
        public void updateItem()
        {
            string tensach = frm.value[0];
            string tacgia = frm.value[1];
            string theloai = frm.value[2];
            string soluong = frm.value[3];
            if (frm.Check())
            {
                bool flag = false;
                ListViewItem.ListViewSubItem tenkh;
                ListViewItem.ListViewSubItem diachi;
                ListViewItem.ListViewSubItem tien;
                foreach (ListViewItem items in listView1.Items)
                {
                    if (IsSubItemsExists(items, tensach))
                    {

                        items.SubItems[2].Text = tacgia;
                        items.SubItems[3].Text = theloai;
                        items.SubItems[4].Text = soluong;
                        flag = true;
                        MessageBox.Show("Cập nhật thành công!");
                        break;
                    }
                }
                if (!flag)
                {
                    ListViewItem item = new ListViewItem((++count).ToString());
                    ListViewItem.ListViewSubItem matk = new ListViewItem.ListViewSubItem(item, tensach);



                    tenkh = new ListViewItem.ListViewSubItem(item, tacgia);
                    diachi = new ListViewItem.ListViewSubItem(item, theloai);
                    tien = new ListViewItem.ListViewSubItem(item, soluong);



                    item.SubItems.Add(matk);
                    item.SubItems.Add(tenkh);
                    item.SubItems.Add(diachi);
                    item.SubItems.Add(tien);
                    listView1.Items.Add(item);
                    MessageBox.Show("Thêm sách thành công!");
                }
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Hãy nhập thông tin hoàn chỉnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Form1()
        {
            InitializeComponent();
            frm = new FormThem();
            frm.Form2BiAn += Form2_Form2BiAn;
        }
        private void Form2_Form2BiAn(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi Form 2 chuyển sang không còn là visible
            updateItem();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            frm1 = new FormGioiThieu();
            frm1.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frm1 = new FormGioiThieu();
            frm1.Visible = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addNew();
        }
        public void addNew()
        {
            frm.enableForm2();

        }
    }
}
