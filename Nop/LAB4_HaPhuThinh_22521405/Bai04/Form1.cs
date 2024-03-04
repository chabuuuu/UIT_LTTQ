using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2_ChuongTrinhSoanVanBan
{
    public partial class Form1 : Form
    {
        private string selectedFont;
        private string selectedSize;
        public Form1()
        {
            InitializeComponent();
            string[] sizeValues = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            for (int i = 0; i < sizeValues.Length; i++)
            {
                comboBox2.Items.Add(sizeValues[i]);
            }
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBox1.Items.Add(font.Name);
            }
            comboBox1.SelectedItem = "Tahoma";
            comboBox2.SelectedItem = "14";
            this.selectedFont = "Tahoma";
            this.selectedSize = "14";
            updateFont();
            updateSize();
        }
        public void ChangeFont(object sender, EventArgs e)
        {
            richTextBox1.Font = fontDialog1.Font;            
        }
        public void updateFont()
        {
            // Lấy font hiện tại của RichTextBox
            Font currentFont = richTextBox1.SelectionFont;

            // Nếu không có văn bản được chọn, sử dụng font mặc định của RichTextBox
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            // Tạo một font mới với font đang được chọn và các thuộc tính còn lại giữ nguyên
            Font newFont = new Font(selectedFont, currentFont.Size, currentFont.Style);

            // Đặt font mới cho văn bản được chọn trong RichTextBox
            richTextBox1.Font = newFont;
            richTextBox1.SelectionFont = newFont;
            comboBox1.SelectedItem = selectedFont;


        }
        public void updateSize()
        {

            // Lấy font hiện tại của RichTextBox
            Font currentFont = richTextBox1.SelectionFont;

            // Nếu không có văn bản được chọn, sử dụng font mặc định của RichTextBox
            if (currentFont == null)
            {
                currentFont = richTextBox1.Font;
            }

            // Tạo một font mới với kích thước được chọn và các thuộc tính còn lại giữ nguyên
            Font newFont = new Font(currentFont.FontFamily, int.Parse(this.selectedSize), currentFont.Style);

            // Đặt font mới cho văn bản được chọn trong RichTextBox
            richTextBox1.Font = newFont;
            richTextBox1.SelectionFont = newFont;
            comboBox2.SelectedItem = this.selectedSize;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Color selectedColor = colorDialog1.Color;
                richTextBox1.ForeColor = selectedColor;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.ShowApply = true;
            fontDialog1.ShowColor = true;
            fontDialog1.Apply += new EventHandler(ChangeFont);
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Tag != null)
            {
                richTextBox1.SaveFile(richTextBox1.Tag.ToString(), RichTextBoxStreamType.RichText);
                MessageBox.Show("File saved successfully.");
            }
            else
            {
                // Nếu không, hiển thị hộp thoại lưu tập tin mới
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        richTextBox1.Tag = saveFileDialog.FileName;
                        MessageBox.Show("File saved successfully.");
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = comboBox1.SelectedItem.ToString();

            this.selectedFont = selectedFont;
            updateFont();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSize = comboBox2.SelectedItem.ToString();
            this.selectedSize = selectedSize;
            updateSize();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại mở tập tin
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mở tập tin và đọc nội dung
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void ApplyFormatting(FontStyle style)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = new System.Drawing.Font(
                    richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style ^ style
                );
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ApplyFormatting(FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplyFormatting(FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyFormatting(FontStyle.Underline);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                // Xử lý sự kiện Ctrl + S
                if (richTextBox1.Tag != null)
                {
                    richTextBox1.SaveFile(richTextBox1.Tag.ToString(), RichTextBoxStreamType.RichText);
                    MessageBox.Show("File saved successfully.");
                }
                else
                {
                    // Nếu không, hiển thị hộp thoại lưu tập tin mới
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                            richTextBox1.Tag = saveFileDialog.FileName;
                            MessageBox.Show("File saved successfully.");
                        }
                    }

                }

                // Ngăn chặn sự kiện được chuyển đến các controls khác (ví dụ: TextBox)
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                richTextBox1.Clear();
                this.selectedFont = "Tahoma";
                this.selectedSize = "14";
                updateFont();
                updateSize();
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.selectedFont = "Tahoma";
            this.selectedSize = "14";
            updateFont();
            updateSize();
        }
    }
}
