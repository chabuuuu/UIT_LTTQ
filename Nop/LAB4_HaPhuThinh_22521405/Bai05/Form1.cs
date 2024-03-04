using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form2 frm { get; set; }
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            frm = new Form2();
            frm.Form2BiAn += Form2_Form2BiAn;
        }
        public void addNew()
        {
            frm.enableForm2();
            
        }
        private void Form2_Form2BiAn(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi Form 2 chuyển sang không còn là visible
            updateItem();
        }
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
            string mssv = frm.value[0];
            string name = frm.value[1];
            string khoa = frm.value[2];
            string diemtb = frm.value[3];
            if (frm.Check())
            {
                bool flag = false;
                ListViewItem.ListViewSubItem tenkh;
                ListViewItem.ListViewSubItem diachi;
                ListViewItem.ListViewSubItem tien;
                foreach (ListViewItem items in listView1.Items)
                {
                    if (IsSubItemsExists(items, mssv))
                    {
                 
                        items.SubItems[2].Text = name;
                        items.SubItems[3].Text = khoa;
                        items.SubItems[4].Text = diemtb;
                        flag = true;
                        MessageBox.Show("Cập nhật thành công!");
                        break;
                    }
                }
                if (!flag)
                {
                    ListViewItem item = new ListViewItem((++count).ToString());
                    ListViewItem.ListViewSubItem matk = new ListViewItem.ListViewSubItem(item, mssv);



                    tenkh = new ListViewItem.ListViewSubItem(item, name);
                    diachi = new ListViewItem.ListViewSubItem(item, khoa);
                    tien = new ListViewItem.ListViewSubItem(item, diemtb);



                    item.SubItems.Add(matk);
                    item.SubItems.Add(tenkh);
                    item.SubItems.Add(diachi);
                    item.SubItems.Add(tien);
                    listView1.Items.Add(item); 
                    MessageBox.Show("Thêm tài khoản thành công!");
                }
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("Hãy nhập thông tin hoàn chỉnh!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNew();   
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = toolStripTextBox1.Text.ToLower(); // Chuyển đổi thành chữ thường

            // Sử dụng LINQ để tìm kiếm chỉ trong cột "Name"
            var query = from ListViewItem item in listView1.Items
                        where item.SubItems[2].Text.ToLower() == searchText
                        select item;

            // Bỏ chọn tất cả các items trong ListView
            foreach (ListViewItem item in listView1.Items)
            {
                item.Selected = false;
            }

            // Nếu có ít nhất một item được tìm thấy, chọn item đầu tiên
            if (query.Any())
            {
                ListViewItem foundItem = query.First();
                foundItem.Selected = true;
                foundItem.EnsureVisible(); // Đảm bảo item được chọn hiển thị trên ListView
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addNew();
        }
    }
}
