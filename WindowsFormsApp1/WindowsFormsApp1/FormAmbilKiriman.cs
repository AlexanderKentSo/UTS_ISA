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
    public partial class FormAmbilKiriman : Form
    {
        public byte[] message;
        User currentUser;
        public FormAmbilKiriman()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kode = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Kiriman.ambilKiriman(kode, currentUser.Id);
            MessageBox.Show("Kiriman sudah diambil segera kirimkan barang dari pengirim ke penerima");
            FormAmbilKiriman_Load(this, e);
        }

        private void FormAmbilKiriman_Load(object sender, EventArgs e)
        {
            string idUser = AES.DecryptStringFromBytes(message);
            currentUser = User.getUser(int.Parse(idUser));
            dataGridView1.Rows.Clear();
            foreach (Kiriman k in Kiriman.daftarKirimanMenunggu())
            {
                dataGridView1.Rows.Add(k.Id, k.Barang, User.getUser(k.IdPengirim).Alamat, User.getUser(k.IdPenerima).Alamat);
            }
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.Name = "Ambil";
            bcol.HeaderText = "Ambil";
            bcol.Text = "Ambil";
            bcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bcol);
        }
    }
}
