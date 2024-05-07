using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brayn
{
    public partial class main : Form
    {
        private string vrsion = "v6.1"; 

        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {
            instagramLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            

            versionLabel.Text = vrsion;
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Uygulamadan Çıkışı Sağlıyor
        }

        private void hspBTN_Click(object sender, EventArgs e)
        {
            hesap_makinası hspm = new hesap_makinası();

            hspm.Show();

            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            qr_code qrpage = new qr_code();

            qrpage.Show();

            this.Hide();
        }

        //
        // İnstagram Link Label
        //
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //google choromun yolu
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            string link = "https://www.instagram.com/s1r.bugra/";

            string browserPath = chromePath; 
            

            // Belirtilen linki tarayıcıyla aç
            System.Diagnostics.Process.Start(browserPath, link);
        }

        //
        //Git Hub LinkLabel
        //
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //google choromun yolu
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            //Microsoft edgenin yolu
            string edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";


            string link = "https://github.com/Zylles";

            string browserPath = chromePath;
            string browserPath2 = edgePath;

            // Belirtilen linki tarayıcıyla aç
            System.Diagnostics.Process.Start(browserPath, link);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dosya_dow dosya_Dow = new dosya_dow();

            dosya_Dow.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dc_webhoohk dc_Webhoohk = new dc_webhoohk();

            dc_Webhoohk.Show();

            this.Hide();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //google choromun yolu
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            string link = "https://www.instagram.com/duhan.bc/";

            string browserPath = chromePath;


            // Belirtilen linki tarayıcıyla aç
            System.Diagnostics.Process.Start(browserPath, link);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void sifre_kaydedici_Click(object sender, EventArgs e)
        {
            şifre_kaydedici sfr = new şifre_kaydedici();
            sfr.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            hakkında hakkında = new hakkında();
            hakkında.Show();

            this.Hide();
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diliniz Türkçe Olarak Ayarlandı");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        //
        //Git Hub LinkLabel
        //

    }
    
}
