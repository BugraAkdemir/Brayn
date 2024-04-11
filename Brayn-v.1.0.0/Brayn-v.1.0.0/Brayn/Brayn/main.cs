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
        public main()
        {
            InitializeComponent();
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
    }
}
