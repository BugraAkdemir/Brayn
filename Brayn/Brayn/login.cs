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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_BTN_Click(object sender, EventArgs e)
        {
            if (ka_TBOX.Text == "s1r.bugra") // Şifre Ve Kullanıcı Adı
            {
                if (pass_TBOX.Text == "bugra2005")
                {
                    main anafrm = new main();

                    anafrm.Show();

                    this.Hide();
                }

                else
                {
                    if (ka_Bilgi.ForeColor == Color.Red)
                    {
                        ka_Bilgi.ForeColor = Color.White;
                    }

                    pass_bilgi.ForeColor = Color.Red;

                    hata_msg.ForeColor = Color.Red;
                    hata_msg.Text = "Şifre Hatalı";
                }
            }

            else
            {
                ka_Bilgi.ForeColor = Color.Red;

                hata_msg.ForeColor = Color.Red;
                hata_msg.Text = "Kullanıcı Adı Hatalı";
            }
        }
    }
}
