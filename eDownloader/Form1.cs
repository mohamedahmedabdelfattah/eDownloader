using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace eDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebClient wc = new WebClient();

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (btnDownload.Text == "Download")
            {
                wc.DownloadFileAsync(new Uri(txtLink.Text), "eDownload");
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wcDownloadProgressChanged);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wcAsyncCompletedEventHandler);
                btnDownload.Text = "Cancel";
            }
            else
            {
                wc.CancelAsync();
                btnDownload.Text = "Download";
            }
        }

        private void wcAsyncCompletedEventHandler(object sender, AsyncCompletedEventArgs e)
        {
            btnDownload.Text = "Download";
            barProgress.Value = 0;
        }

        private void wcDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            barProgress.Value = e.ProgressPercentage;
        }
    }
}