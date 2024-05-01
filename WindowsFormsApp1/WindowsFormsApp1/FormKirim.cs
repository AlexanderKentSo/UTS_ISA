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
    public partial class FormKirim : Form
    {
        public byte[] message;
        User currentUser;
        public FormKirim()
        {
            InitializeComponent();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            try
            {
                User kirim = (User)comboBox1.SelectedItem;
                Kiriman.buatKiriman(textBoxBarang.Text, currentUser.Id, kirim.Id);
                MessageBox.Show("kiriman sudah dibuat");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormKirim_Load(object sender, EventArgs e)
        {
            string idUser = AES.DecryptStringFromBytes(message);
            currentUser = User.getUser(int.Parse(idUser));
            comboBox1.DataSource = currentUser.daftarUser();
            comboBox1.DisplayMember = "Username";
        }
    }
}
