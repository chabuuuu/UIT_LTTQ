using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {    
            InitializeComponent();
            InitializeFileListView("C:\\");
            InitializeImageList();
            this.Size = new Size(1180, 700);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            toolStripMenuItem1.Size = new Size(880, 32);
            textBoxPath.Size = new Size(1090, 32);          
            DiskPath.SelectedIndex = 0; 
        }
        private ImageList imageList;

       
        private void InitializeImageList()
        {
            imageList = new ImageList();
            imageList.Images.Add("Disk Cleanup", Properties.Resources.disk_cleanup);
            imageList.Images.Add("Dll", Properties.Resources.dll);
            imageList.Images.Add("Excel", Properties.Resources.excel);
            imageList.Images.Add("Exe", Properties.Resources.exe);
            imageList.Images.Add("Unkown", Properties.Resources.file_unknown);
            imageList.Images.Add("Folder", Properties.Resources.folder);
            imageList.Images.Add("Image", Properties.Resources.gallery_icon);
            imageList.Images.Add("Music", Properties.Resources.music);
            imageList.Images.Add("Pdf", Properties.Resources.pdf);
            imageList.Images.Add("Ppt", Properties.Resources.ppt);
            imageList.Images.Add("Rar", Properties.Resources.rar);
            imageList.Images.Add("Text Document", Properties.Resources.text_document);
            imageList.Images.Add("Video", Properties.Resources.video);
            imageList.Images.Add("Word", Properties.Resources.word);

          
            listViewFiles.SmallImageList = imageList;
        }

        private void InitializeFileListView(string path)
        {
            
            listViewFiles.Items.Clear();
            
            textBoxPath.Text = path;

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (var directory in directories)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(directory);
                ListViewItem item = new ListViewItem(dirInfo.Name, "Folder");
                item.SubItems.Add("<DIR>");
                item.SubItems.Add("");
                item.SubItems.Add(dirInfo.LastWriteTime.ToString());
                listViewFiles.Items.Add(item);
            }

            foreach (var file in files)
            {
                string extension = Path.GetExtension(file)?.ToLower();

                string imageKey;

                switch (extension)
                {
                    case ".lnk":
                        imageKey = "Disk Cleanup";
                        break;
                    
                    case ".dll":
                        imageKey = "Dll";
                        break;
                    
                    case ".xls":
                    case ".xlsm":
                    case ".xml":
                    case ".ods":
                    case ".xlsx":
                        imageKey = "Excel";
                        break;
                    
                    case ".jpeg":
                    case ".png":
                    case ".gif":
                    case ".jpg":
                    case ".svg":
                        imageKey = "Image";
                        break;
                    
                    case ".mp3":
                    case ".wma":
                    case ".wav":
                    case ".flac":
                    case ".aac":
                    case ".ogg":
                    case ".aiff":
                    case ".alac":
                    case ".amr":
                    case ".midi":
                    case ".wma9":
                        imageKey = "Music";
                        break;
                    
                    case ".pdf":
                        imageKey = "Pdf";
                        break;
                    
                    case ".ppt":
                    case ".pptx":
                    case ".pptm":
                        imageKey = "Ppt";
                        break;
                    
                    case ".rar":
                    case ".zip":
                    case ".7z":
                    case ".cab":
                    case ".ace":
                    case ".arj":
                    case ".bz2":
                        imageKey = "Rar";
                        break;
                    
                    case ".txt":
                        imageKey = "Text Document";
                        break;
                    
                    case ".avi":
                    case ".flv":
                    case ".wmv":
                    case ".mov":
                    case ".mp4":
                    case ".avchd":
                    case ".webm":
                    case ".mkv":
                        imageKey = "Video";
                        break;
                    
                    case ".doc":
                    case ".docm":
                    case ".docx":
                        imageKey = "Word";
                        break;
                    default:
                        imageKey = "Unkown"; 
                        break;
                }
                FileInfo fileInfo = new FileInfo(file);
                
                string fileName = Path.GetFileNameWithoutExtension(file);
                
                string type = GetFileType(fileInfo);
                
                string size = FormatBytes(fileInfo.Length);
                ListViewItem item = new ListViewItem(fileName, imageKey);
                item.SubItems.Add(type);
                item.SubItems.Add(size);
                item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                listViewFiles.Items.Add(item);
            }
        }

        private string FormatBytes(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            int index = 0;
            double size = bytes;

            while (size >= 1024 && index < suffixes.Length - 1)
            {
                size /= 1024;
                index++;
            }

            return $"{size:0.##} {suffixes[index]}";
        }

        private string GetFileType(FileInfo fileInfo)
        {
            if ((fileInfo.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                return "<DIR>";
            }
            else
            {
                return fileInfo.Extension.ToString();
            }
        }

        private void listViewFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewFiles.SelectedItems[0];
                string itemName = selectedItem.Text;
                string fullPath = Path.Combine(textBoxPath.Text, itemName);

                if (selectedItem.SubItems[1].Text == "<DIR>")
                {
                    InitializeFileListView(fullPath);
                }
                else
                {
                    System.Diagnostics.Process.Start(fullPath);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aboutScreen = new AboutScreen();
            aboutScreen.ShowDialog();
        }

        private void menuStrip1_SizeChanged(object sender, EventArgs e)
        {
            menuStrip1.Width = this.Width;
        }

        private void menuStrip2_SizeChanged(object sender, EventArgs e)
        {
            menuStrip2.Width = this.Width;
        }

        private void Up_Click(object sender, EventArgs e)
        {
            string currentPath = textBoxPath.Text;

            if (Directory.GetParent(currentPath) != null)
            {
                string parentPath = Directory.GetParent(currentPath).FullName;
                InitializeFileListView(parentPath);
            } 
        }

        private void DiskPath_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedDrive = DiskPath.SelectedItem.ToString();

            InitializeFileListView(selectedDrive);
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewFiles.View = System.Windows.Forms.View.Details;
            this.Invalidate();
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            listViewFiles.View = System.Windows.Forms.View.SmallIcon;
            this.Invalidate();
        }
    }
}
