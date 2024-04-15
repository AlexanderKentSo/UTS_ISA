using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lib
{
    public class User
    {
        private int id;
        private string username;
        private string alamat;
        private string role;

        //constructor
        public User(int id, string username, string password, string alamat, string role)
        {
            this.Id = id;
            this.Username = username;
            this.Alamat = alamat;
            this.Role = role;
        }
        public User()
        {
            this.Id = 0;
            this.Username = "";
            this.Alamat = "";
            this.Role = "";
        }

        //properties
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Role { get => role; set => role = value; }

        #region method
        //yang dienkripsi password agar admin yang mengururs data base tidak bisa melihat password user
        public static void registerKurir(String us, String pw)
        {
            String perintah = "SELECT * FROM  `uts_isa`.`user` WHERE `username`='"+us+"'";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            if (msdr.Read()) { throw new Exception("username sudah terpakai"); }
            else
            {
                String perintah2 = "INSERT INTO `uts_isa`.`user` (`username`, `password`, `alamat`, `role`) VALUES ('" + us + "', SHA('" + pw + "'), '', 'kurir');";
                Koneksi.jalankanPerintah(perintah2);
            }
        }

        public static void registerUser(String us, String pw, String alm)
        {
            String perintah = "SELECT * FROM  `uts_isa`.`user` WHERE `username`='" + us + "'";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            if (msdr.Read()) { throw new Exception("username sudah terpakai"); }
            else
            {
                String perintah2 = "INSERT INTO `uts_isa`.`user` (`username`, `password`, `alamat`, `role`) VALUES ('" + us + "', SHA('" + pw + "'), '" + alm + "', 'pengguna');";
                Koneksi.jalankanPerintah(perintah2);
            }
        }

        public static User login(String us, String pw)
        {
            User user = new User();
            String perintah = "SELECT * FROM `uts_isa`.`user` WHERE `username`='"+us+"' AND `password`=SHA('"+pw+"')";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                user.Id = int.Parse(msdr.GetValue(0).ToString());
                user.Username = msdr.GetValue(1).ToString();
                user.Role = msdr.GetValue(4).ToString();
                if(user.Role == "pengguna") {  user.Alamat = msdr.GetValue(3).ToString(); }
                else { user.Alamat = ""; }
            }
            else { throw new Exception("username atau password salah"); }
            return user;
        }
        public static User getUser(int userId)
        {
            User user = new User();
            String perintah = "SELECT * FROM `uts_isa`.`user` WHERE `id`=" + userId + ";";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            if (msdr.Read())
            {
                user.Id = int.Parse(msdr.GetValue(0).ToString());
                user.Username = msdr.GetValue(1).ToString();
                user.Role = msdr.GetValue(4).ToString();
                if (user.Role == "pengguna") { user.Alamat = msdr.GetValue(3).ToString(); }
                else { user.Alamat = ""; }
            }
            else { throw new Exception("username atau password salah"+userId); }
            return user;
        }

        public List<User> daftarUser()
        {
            List<User> users = new List<User>();
            String perintah = "SELECT * FROM `uts_isa`.`user` WHERE `username`!='" + this.Username + "' AND `role`='pengguna'";
            MySqlDataReader msdr = Koneksi.jalankanPerintahSelect(perintah);
            while (msdr.Read())
            {
                User u = new User();
                u.Id = int.Parse(msdr.GetValue(0).ToString());
                u.Username = msdr.GetValue(1).ToString();
                users.Add(u);
            }
            return users;
        }
        #endregion
    }
}