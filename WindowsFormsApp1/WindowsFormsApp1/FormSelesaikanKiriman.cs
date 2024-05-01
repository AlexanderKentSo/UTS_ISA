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
    public partial class FormSelesaikanKiriman : Form
    {
        public byte[] message;
        User currentUser;
        public FormSelesaikanKiriman()
        {
            InitializeComponent();
        }

        private void FormSelesaikanKiriman_Load(object sender, EventArgs e)
        {
            string idUser = AES.DecryptStringFromBytes(message);
            currentUser = User.getUser(int.Parse(idUser));
            dataGridView1.Rows.Clear();
            foreach(Kiriman k in Kiriman.daftarKirimanDiantar(currentUser.Id))
            {
                dataGridView1.Rows.Add(k.Id,k.Barang,User.getUser(k.IdPengirim).Alamat,User.getUser(k.IdPenerima).Alamat);
            }
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.Name = "Selesaika";
            bcol.HeaderText = "Selesaikan";
            bcol.Text = "Selesaikan";
            bcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bcol);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kode = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Kiriman.selesaikanKiriman(kode);
            MessageBox.Show("Kiriman sudah diselesaikan");
            FormSelesaikanKiriman_Load(this, e);
        }
    }
}
