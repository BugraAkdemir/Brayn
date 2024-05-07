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
    public partial class hakkında : Form
    {
        public hakkında()
        {
            InitializeComponent();
        }

        private void hakkında_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main asayfa = new main();

            asayfa.Show();

            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
