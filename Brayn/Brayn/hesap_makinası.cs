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
    public partial class hesap_makinası : Form
    {

        private char _islem;
        private bool _ekrantmz;
        private int _ilksayi;

        public hesap_makinası()
        {
            InitializeComponent();
        }

        private void hesap_makinası_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            main asayfa = new main();

            asayfa.Show();

            this.Hide();
        }

        //
        // Hesap Makinası
        //
        private void rakam1BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "3") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void toplamaBTN_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void rakam0BTN_Click(object sender, EventArgs e)
        {
            if (_ekrantmz)
            {
                ekranLabel.Text = "";
                _ekrantmz = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void esitirBTN_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;

                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;

                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;

                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text =   Convert.ToString(sonuc);
        }

        private void cıkarmaBTN_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpıBTN_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void bölmeBTN_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantmz = true;
            _ilksayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void cBTN_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
