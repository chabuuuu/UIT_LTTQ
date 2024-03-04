using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public class DownloadTask
        {
            public string Filename { get; set; }
            public string Size { get; set; }
            public string Progress { get; set; }
            public string Speed { get; set; }


            public string Url { get; set; }

            public string Status { get; set; }
            public long LastBytesReceived { get; set; }
            public WebClient Client { get; set; }

            public DownloadTask(string URL, string FileName)
            {
                Url = URL;
                Filename = FileName;
                Size = "";
                Progress = "";
                Speed = "";
                Status = "";
                Client = new WebClient(); 
            }
        }
        public static string FormatSize(double bytes)
        {
            string[] sizes = { "B", "Kb"};
            int order = 0;
            while (bytes >= 1024 && order < sizes.Length - 1)
            {

                
                
                order++;
                
                
                bytes /= 1024;
            }
            return $"{bytes:0.##} {sizes[order]}";
        }

        private List<DownloadTask> downloadTasks = new List<DownloadTask>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addNewDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                string url = form2.url;
                string filename = form2.filename;
                Task.Run(() => AddDownloadTask(url, filename));
            }
        }

        private void stopDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                DownloadTask selectedTask = downloadTasks[selectedIndex];

                if (selectedTask.Status == "Downloading")
                {
                    selectedTask.Status = "Cancelled";
                    selectedTask.Client.CancelAsync(); 
                }
            }
        }

        private void AddDownloadTask(string URL, string FileName)
        {
            DownloadTask downloadTask = new DownloadTask(URL, FileName);
            downloadTasks.Add(downloadTask);

            ListViewItem item = new ListViewItem(downloadTask.Filename);
            item.SubItems.Add(downloadTask.Size);
            item.SubItems.Add(downloadTask.Progress);
            item.SubItems.Add(downloadTask.Speed);
            item.SubItems.Add(downloadTask.Status);
            item.SubItems.Add(downloadTask.Url);

            listView1.Items.Add(item);

            Task.Run(() => StartDownload(downloadTask));
        }

        private void StartDownload(DownloadTask downloadTask)
        {
            downloadTask.Status = "Downloading";
            using (downloadTask.Client)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                downloadTask.Client.DownloadProgressChanged += (sender, e) =>
                {
                    downloadTask.Size = $"{e.BytesReceived.ToString()}/{e.TotalBytesToReceive.ToString()}";
                    downloadTask.Progress = $"{e.ProgressPercentage}%";
                    downloadTask.Speed = $"{FormatSize(e.BytesReceived / stopwatch.Elapsed.TotalSeconds)}/s";
                    UpdateListView(downloadTask);
                };

                downloadTask.Client.DownloadFileCompleted += (sender, e) =>
                {
                    stopwatch.Stop();
                    downloadTask.Status = e.Cancelled ? "Cancelled" : "Completed";
                    UpdateListView(downloadTask);
                };

                downloadTask.Client.DownloadFileAsync(new Uri(downloadTask.Url), downloadTask.Filename);
            }
        }

        public void UpdateListView(DownloadTask downloadTask)
        {
            if (listView1.InvokeRequired)
            {
                listView1.Invoke(new Action(() =>
                {
                    listView1.BeginUpdate();
                    UpdateListView(downloadTask);
                    listView1.EndUpdate();
                }));
            }
            else
            {
                int rowIndex = downloadTasks.IndexOf(downloadTask);
                listView1.Items[rowIndex].SubItems[1].Text = downloadTask.Size;
                listView1.Items[rowIndex].SubItems[2].Text = downloadTask.Progress;
                listView1.Items[rowIndex].SubItems[3].Text = downloadTask.Speed;
                listView1.Items[rowIndex].SubItems[4].Text = downloadTask.Status;
            }
        }   
    }
}
