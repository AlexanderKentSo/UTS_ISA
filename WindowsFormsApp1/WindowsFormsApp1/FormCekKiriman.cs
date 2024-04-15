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
    public partial class FormCekKiriman : Form
    {
        public User currentUser;
        public FormCekKiriman()
        {
            InitializeComponent();
        }

        private void FormCekKiriman_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach(Kiriman k in Kiriman.daftarKirimanUser(currentUser.Id))
            {
                dataGridView1.Rows.Add(k.Id,k.Barang,User.getUser(k.IdPenerima).Username,k.Status);
            }
            DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            bcol.Name = "Cetak";
            bcol.HeaderText = "Cetak";
            bcol.Text = "Cetak";
            bcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(bcol);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int kode = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            Kiriman k = Kiriman.getKiriman(kode);
            k.printKiriman();
        }
    }
}
