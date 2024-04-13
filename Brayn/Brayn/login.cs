using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brayn
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayit_ol kayit_Ol = new kayit_ol();

            kayit_Ol.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Kullanıcı adı veya şifre boş ise uyarı ver
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.");
                return;
            }

            // Kullanıcı adı ve şifreyi kontrol et
            bool girisBasarili = KullaniciGirisKontrol(kullaniciAdi, sifre);

            if (girisBasarili)
            {
                main gyap = new main();

                gyap.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }

        private bool KullaniciGirisKontrol(string kullaniciAdi, string sifre)
        {
            // Dosyadan kullanıcı bilgilerini oku ve kontrol et
            string[] satirlar = File.ReadAllLines("kullanicilar.txt");

            foreach (string satir in satirlar)
            {
                string[] bilgiler = satir.Split(',');

                if (bilgiler.Length >= 2 && bilgiler[0] == kullaniciAdi && bilgiler[1] == sifre)
                {
                    return true;
                }
            }

            return false;
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
