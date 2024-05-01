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

        public byte[] message;
        User currentUser;
        public FormUtama()
        {
            InitializeComponent();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kirimBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKirim form = new FormKirim();
            form.message = message;
            form.Owner = this;
            form.ShowDialog();
        }

        private void ambilBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAmbilKiriman form = new FormAmbilKiriman();
            form.message = message;
            form.Owner = this;
            form.ShowDialog();
        }

        private void cekBarangKirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCekKiriman form = new FormCekKiriman();
            form.message = message;
            form.Owner = this;
            form.ShowDialog();
        }

        private void selesaikanPengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelesaikanKiriman form = new FormSelesaikanKiriman();
            form.message = message;
            form.Owner = this;
            form.ShowDialog();
        }

        private void dekripsiSteganoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDekripsi form = new FormDekripsi();
            form.Owner = this;
            form.ShowDialog();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Owner = this;
            form.ShowDialog();
            this.Visible = false;
            string idUser = AES.DecryptStringFromBytes(message);
            currentUser = User.getUser(int.Parse(idUser));
            if (currentUser.Role == "pengguna") { antarToolStripMenuItem.Enabled = false; antarToolStripMenuItem.Visible = false; }
            else if (currentUser.Role == "kurir") { kirimToolStripMenuItem.Enabled = false; kirimToolStripMenuItem.Visible = false; }
            else { this.Close(); }
        }
    }
}
