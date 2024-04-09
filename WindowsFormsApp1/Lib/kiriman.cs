using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JualBeli_LIB
{
    public class kiriman
    {
        private int id;
        private string barang;
        private int harga;
        private int idPengirim;
        private int idPenerima;
        private int idKurir;

        //constructors
        public kiriman(int id, string barang, int harga, int idPengirim, int idPenerima, int idKurir)
        {
            this.Id = id;
            this.Barang = barang;
            this.Harga = harga;
            this.IdPengirim = idPengirim;
            this.IdPenerima = idPenerima;
            this.IdKurir = idKurir;
        }

        //propeties
        public int Id { get => id; set => id = value; }
        public string Barang { get => barang; set => barang = value; }
        public int Harga { get => harga; set => harga = value; }
        public int IdPengirim { get => idPengirim; set => idPengirim = value; }
        public int IdPenerima { get => idPenerima; set => idPenerima = value; }
        public int IdKurir { get => idKurir; set => idKurir = value; }
    }
}
