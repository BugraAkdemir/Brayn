using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Brayn
{
    public partial class dosya_dow : Form
    {
        public dosya_dow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wClient = new WebClient();
            wClient.DownloadFileAsync(new Uri(textBox1.Text), Application.StartupPath + @"\vidio.exe");
            wClient.DownloadFileCompleted += WClient_DownloadFileCompleted;
            wClient.DownloadProgressChanged += WClient_DownloadProgressChanged;
        }

        private void WClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void WClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("İndirme Başaarılı");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main foem1 = new main();

            foem1.Show();

            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dosya_dow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
