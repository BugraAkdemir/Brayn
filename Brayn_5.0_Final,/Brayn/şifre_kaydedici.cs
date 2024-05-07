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
    public partial class şifre_kaydedici : Form
    {
        public şifre_kaydedici()
        {
            InitializeComponent();
        }

        private void kaydet_button_Click(object sender, EventArgs e)
        {
            string isim = şifreye_isimi_girişi.Text;

            string sifre = şifre_girişi.Text;

            // İsim ve şifreyi virgülle ayrılmış bir formatta birleştir
            string kayit = isim + "," + sifre;

            // Kaydı dosyaya yaz
            Kaydet(kayit);

            // Kullanıcıya bilgi mesajı göster
            hata_mesaj.ForeColor = Color.Green;
            hata_mesaj.Text = "Şifre Başarıyla Kaydedildi";

            // TextBox'ları temizle
            şifreye_isimi_girişi.Clear();
            şifre_girişi.Clear();
        }

        private void Kaydet(string kayit)
        {
            // Dosyayı aç ve yeni bir satır olarak kaydı ekle
            using (StreamWriter writer = new StreamWriter("sifreler.txt", true))
            {
                writer.WriteLine(kayit);
            }
        }

        private void şifre_arama_button_Click(object sender, EventArgs e)
        {
            string arananIsim = şifre_ismi_arama_girişi.Text;

            // Aranan ismi dosyadan ara
            string sifre = SifreBul(arananIsim);

            // Eğer şifre bulunduysa label'a yazdır, bulunamadıysa mesaj göster
            if (!string.IsNullOrEmpty(sifre))
            {
                şifre_cıkısı.ForeColor = Color.Green;
                şifre_cıkısı.Text = "Şifre: " + sifre;
                şifre_ismi_cıkısı.ForeColor= Color.Green;
                şifre_ismi_cıkısı.Text = $"Şifre İsmi: {arananIsim}";
            }
            else
            {
                şifre_ismi_cıkısı.Text = "";
                şifre_cıkısı.ForeColor = Color.Red;
                şifre_cıkısı.Text = "Şifre bulunamadı.";
            }
        }

        private void şifre_listele_button_Click(object sender, EventArgs e)
        {
            TumSifreleriGoster();
        }

        private void TumSifreleriGoster()
        {
            şifre_listele_çıkışı.Text = "";
            şifre_listele_çıkışı.ForeColor = Color.Green;

            // Dosyadan tüm satırları oku ve label'a yaz
            using (StreamReader reader = new StreamReader("sifreler.txt"))
            {
                string satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2)
                    {
                        şifre_listele_çıkışı.ForeColor = Color.Green;
                        şifre_listele_çıkışı.Text += "Şifre Adı: " + parcalar[0] + " Şifre: " + parcalar[1] + "\n";
                    }
                }
            }
        }



        private string SifreBul(string arananIsim)
        {
            string sifre = null;

            // Dosyadan satır satır oku ve aranan ismi ara
            using (StreamReader reader = new StreamReader("sifreler.txt"))
            {
                string satir;
                while ((satir = reader.ReadLine()) != null)
                {
                    string[] parcalar = satir.Split(',');
                    if (parcalar.Length == 2 && parcalar[0] == arananIsim)
                    {
                        sifre = parcalar[1];
                        break;
                    }
                }
            }

            return sifre;
        }




        private void Kaydet2(string kayit)
        {
            // Dosyayı aç ve yeni bir satır olarak kaydı ekle
            using (StreamWriter writer = new StreamWriter("sifreler.txt", true))
            {
                writer.WriteLine(kayit);
            }
        }

        private void şifre_kaydedici_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main main = new main();

            main.Show();

            this.Hide();
        }
    }
}
