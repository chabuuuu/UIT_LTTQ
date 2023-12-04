using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem sizeToolStripMenuItem;
        public Form1()
        {
            InitializeComponent();
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();

            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Text Editor";
            this.Load += new EventHandler(Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontToolStripMenuItem.DropDown.Items.AddRange(GetSystemFonts());

            // Khởi tạo dữ liệu cho ComboBox Size
            sizeToolStripMenuItem.DropDown.Items.AddRange(GetFontSizes());

            // Đặt giá trị mặc định cho Font và Size
            //fontToolStripMenuItem.DropDown.SelectedIndex = fontToolStripMenuItem.DropDown.Items.IndexOf("Tahoma");
           // sizeToolStripMenuItem.DropDown.SelectedIndex = sizeToolStripMenuItem.DropDown.Items.IndexOf("14");

            // Xử lý các sự kiện menu
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            fontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            sizeToolStripMenuItem.Click += SizeToolStripMenuItem_Click;
        
        }
        private ToolStripItem[] GetSystemFonts()
        {
            FontFamily[] fontFamilies = FontFamily.Families;
            ToolStripItem[] fontItems = new ToolStripItem[fontFamilies.Length];

            for (int i = 0; i < fontFamilies.Length; i++)
            {
                fontItems[i] = new ToolStripMenuItem(fontFamilies[i].Name);
            }

            return fontItems;
        }
        private ToolStripItem[] GetFontSizes()
        {
            string[] sizeValues = { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            ToolStripItem[] sizeItems = new ToolStripItem[sizeValues.Length];

            for (int i = 0; i < sizeValues.Length; i++)
            {
                sizeItems[i] = new ToolStripMenuItem(sizeValues[i]);
            }

            return sizeItems;
        }
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Xóa nội dung hiện có và đặt giá trị mặc định
            richTextBox1.Clear();
           // fontToolStripMenuItem.DropDown.SelectedIndex = fontToolStripMenuItem.DropDown.Items.IndexOf("Tahoma");
           // sizeToolStripMenuItem.DropDown.SelectedIndex = sizeToolStripMenuItem.DropDown.Items.IndexOf("14");
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Nếu đã lưu tập tin trước đó, sử dụng đường dẫn đã lưu
            if (richTextBox1.Tag != null)
            {
                richTextBox1.SaveFile(richTextBox1.Tag.ToString(), RichTextBoxStreamType.PlainText);
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
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại FontDialog
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Áp dụng font đã chọn vào RichTextBox
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void SizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại FontDialog để chọn kích thước
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Áp dụng kích thước đã chọn vào RichTextBox
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

    }
}
