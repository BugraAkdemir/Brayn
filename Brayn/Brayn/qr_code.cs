using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace Brayn
{
    public partial class qr_code : Form
    {
        public qr_code()
        {
            InitializeComponent();
        }

        private void olusturBTN_Click(object sender, EventArgs e)
        {
            QRCodeEncoder enc = new QRCodeEncoder();
            qrBox.Image = enc.Encode(linkText.Text);

            sunucLBL.Text = "Qr Oluştu";
            sunucLBL.ForeColor = Color.Green;

            sunucLBL.Text = "QR Code Oluşturuldu";
        }

        private void qr_code_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cıkısBTn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfaBtN_Click(object sender, EventArgs e)
        {
            main anasyf = new main();

            anasyf.Show();

            this.Hide();        
        }

        private void qr_code_Load(object sender, EventArgs e)
        {

        }
    }
}
