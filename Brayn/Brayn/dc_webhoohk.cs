using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brayn
{
    public partial class dc_webhoohk : Form
    {
        public dc_webhoohk()
        {
            InitializeComponent();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            // TextBox'lardan değerleri al
            string webhookUrl = link.Text;
            string messageContent = mesaj.Text;

            // Webhook URL'si boşsa veya mesaj boşsa işlem yapma
            if (string.IsNullOrWhiteSpace(webhookUrl) || string.IsNullOrWhiteSpace(messageContent))
            {
                MessageBox.Show("Lütfen webhook URL'si ve mesajı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // JSON mesaj oluşturma
                string json = $"{{ \"content\": \"{messageContent}\" }}";

                // HttpClient oluşturma
                using (HttpClient httpClient = new HttpClient())
                {
                    // İstek ayarları
                    StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                    // Mesajı webhook üzerinden gönderme
                    HttpResponseMessage response = await httpClient.PostAsync(webhookUrl, content);

                    // Başarılı cevap kontrolü
                    if (response.IsSuccessStatusCode)
                    {
                        bilgi.ForeColor = Color.Green;

                        bilgi.Text = "Mesaj Başarıyla Gönderildi";
                    }
                    else
                    {
                        bilgi.ForeColor = Color.Red;
                        bilgi.Text = "Mesaj Göderilirken Bir Hata Oluştu";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main asayfa = new main();
            asayfa.Show();
            this.Hide();
        }

        private void dc_webhoohk_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
    
}
