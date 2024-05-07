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

namespace Brayn
{
    public partial class kayit_ol : Form
    {
        public kayit_ol()
        {
            InitializeComponent();
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
            bool kullaniciVarMi = KullaniciKontrolEt(kullaniciAdi, sifre);

            if (kullaniciVarMi)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor.");
                return;
            }

            // Kullanıcıyı dosyaya kaydet
            Kaydet(kullaniciAdi, sifre);
            MessageBox.Show("Kayıt başarıyla yapıldı.");

            login b = new login();

            b.Show();

            this.Hide();
        }

        private bool KullaniciKontrolEt(string kullaniciAdi, string sifre)
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

        private void Kaydet(string kullaniciAdi, string sifre)
        {
            // Kullanıcı bilgilerini dosyaya ekle
            using (StreamWriter writer = new StreamWriter("kullanicilar.txt", true))
            {
                writer.WriteLine(kullaniciAdi + "," + sifre);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login a = new login();

            a.Show();

            this.Hide();
        }

        private void kayit_ol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
