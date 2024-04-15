using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace lib
{
    public class Kiriman
    {
        private int id;
        private string barang;
        private string status;
        private int idPengirim;
        private int idPenerima;
        private int idKurir;

        //constructors
        public Kiriman(int id, string barang, int idPengirim, int idPenerima, int idKurir)
        {
            this.Id = id;
            this.Barang = barang;
            this.Status = "menunggu";
            this.IdPengirim = idPengirim;
            this.IdPenerima = idPenerima;
            this.IdKurir = idKurir;
        }
        public Kiriman()
        {
            this.Id = 0;
            this.Barang = "";
            this.Status = "menunggu";
            this.IdPengirim = 0;
            this.IdPenerima = 0;
            this.IdKurir = 0;
        }

        //propeties
        public int Id { get => id; set => id = value; }
        public string Barang { get => barang; set => barang = value; }
        public string Status { get => status; set => status = value; }
        public int IdPengirim { get => idPengirim; set => idPengirim = value; }
        public int IdPenerima { get => idPenerima; set => idPenerima = value; }
        public int IdKurir { get => idKurir; set => idKurir = value; }

        #region method
        public static void buatKiriman(String nama, int kirim, int terima)
        {
            String perintah = "INSERT INTO `uts_isa`.`kiriman` (`barang`,`status`, `pengirim`, `penerima`) VALUES ('"+nama+"','menunggu', '"+kirim+"', '"+terima+"');";
            Koneksi.jalankanPerintah(perintah);
        }

        public static void ambilKiriman(int kirimanId, int kurir)
        {
            String perintah = "UPDATE `uts_isa`.`kiriman` SET `status`='diantar', `kurir`='"+kurir+"' WHERE `id`='"+kirimanId+"';";
            Koneksi.jalankanPerintah(perintah);
        }

        public static void selesaikanKiriman(int kirimanId)
        {
            String perintah = "UPDATE `uts_isa`.`kiriman` SET `status`='sampai' WHERE `id`='" + kirimanId + "';";
            Koneksi.jalankanPerintah(perintah);
        }

        public static List<Kiriman> daftarKirimanMenunggu()
        {
            List<Kiriman> kirimans = new List<Kiriman>();
            String perintah = "SELECT * FROM `uts_isa`.`kiriman` WHERE `status`='menunggu';";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Kiriman k = new Kiriman();
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Barang = msdr.GetValue(1).ToString();
                k.Status = msdr.GetValue(2).ToString();
                k.idPengirim = int.Parse(msdr.GetValue(3).ToString());
                k.idPenerima = int.Parse(msdr.GetValue(4).ToString());
                kirimans.Add(k);
            }
            return kirimans;
        }

        public static List<Kiriman> daftarKirimanDiantar(int kurirId)
        {
            List<Kiriman> kirimans = new List<Kiriman>();
            String perintah = "SELECT * FROM `uts_isa`.`kiriman` WHERE `status`='diantar' AND `kurir`="+kurirId+";";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Kiriman k = new Kiriman();
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Barang = msdr.GetValue(1).ToString();
                k.Status = msdr.GetValue(2).ToString();
                k.idPengirim = int.Parse(msdr.GetValue(3).ToString());
                k.idPenerima = int.Parse(msdr.GetValue(4).ToString());
                kirimans.Add(k);
            }
            return kirimans;
        }

        public static List<Kiriman> daftarKirimanUser(int userId)
        {
            List<Kiriman> kirimans = new List<Kiriman>();
            String perintah = "SELECT * FROM `uts_isa`.`kiriman` WHERE `pengirim`="+userId+";";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                Kiriman k = new Kiriman();
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Barang = msdr.GetValue(1).ToString();
                k.Status = msdr.GetValue(2).ToString();
                k.idPengirim = int.Parse(msdr.GetValue(3).ToString());
                k.idPenerima = int.Parse(msdr.GetValue(4).ToString());
                kirimans.Add(k);
            }
            return kirimans;
        }

        public static Kiriman getKiriman(int kirimanId)
        {
            Kiriman k = new Kiriman();
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect("SELECT * FROM `uts_isa`.`kiriman` WHERE `id`=" + kirimanId + ";");
            if(msdr.Read())
            {
                k.Id = int.Parse(msdr.GetValue(0).ToString());
                k.Barang = msdr.GetValue(1).ToString();
                k.Status = msdr.GetValue(2).ToString();
                k.idPengirim = int.Parse(msdr.GetValue(3).ToString());
                k.idPenerima = int.Parse(msdr.GetValue(4).ToString());
            }
            else { throw new Exception("data kiriman tidk ditemukan"); }
            return k;
        }
        public void printKiriman()
        {
            String nama = "Kiriman_"+this.Barang+"-"+User.getUser(this.idPengirim).Username;
            StreamWriter file = new StreamWriter(nama);
            file.WriteLine("Tanggal Cetak : "+DateTime.Now.ToString("yyyy-MM-dd"));
            file.WriteLine("====================================================");
            file.WriteLine("Nama Barang : "+this.Barang);
            file.WriteLine("Pengirim : "+User.getUser(this.IdPengirim).Username);
            file.WriteLine("Penerima : "+User.getUser(this.IdPenerima).Username);
            file.WriteLine("Status : " + this.Status);
            file.Close();
            Cetak p = new Cetak(new System.Drawing.Font("courier new", 12), nama);
            p.kirimPrinter();
        }
        #endregion
    }
}