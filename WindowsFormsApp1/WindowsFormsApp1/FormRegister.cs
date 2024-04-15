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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonUser.Checked)
                {
                    User.registerUser(textBoxUsername.Text, textBoxPassword.Text,textBoxAlamat.Text);
                }
                else
                {
                    User.registerKurir(textBoxUsername.Text, textBoxPassword.Text);
                }
                MessageBox.Show("registrasi berhasil silahkan kembali ke halaman log in");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAlamat.Enabled = true;
        }

        private void radioButtonKurir_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAlamat.Enabled = false;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            radioButtonUser.Checked = true;
        }
    }
}
