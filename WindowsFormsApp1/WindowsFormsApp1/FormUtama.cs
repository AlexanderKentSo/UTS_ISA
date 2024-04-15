using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib;

namespace WindowsFormsApp1
{
    public partial class FormUtama : Form
    {

        public User currentUser = new User();
        public FormUtama()
        {
            InitializeComponent();
            this.Visible = false;
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.ShowDialog();
            if (currentUser.Role == "pengguna") { antarToolStripMenuItem.Enabled = false; antarToolStripMenuItem.Visible = false; }
            else if (currentUser.Role == "kurir") { kirimToolStripMenuItem.Enabled = false; kirimToolStripMenuItem.Visible = false; }
            else { this.Close(); }
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kirimBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKirim form = new FormKirim();
            form.currentUser = currentUser;
            form.Owner = this;
            form.ShowDialog();
        }

        private void ambilBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAmbilKiriman form = new FormAmbilKiriman();
            form.currentUser = currentUser;
            form.Owner = this;
            form.ShowDialog();
        }

        private void cekBarangKirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCekKiriman form = new FormCekKiriman();
            form.currentUser = currentUser;
            form.Owner = this;
            form.ShowDialog();
        }

        private void selesaikanPengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelesaikanKiriman form = new FormSelesaikanKiriman();
            form.currentUser = currentUser;
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
