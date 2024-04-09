using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lib{
  public class user{
    private int id;
    private string username;
    private string password;
    private string alamat;
    private string role;

    //constructor
    public user(int id, string username, string password, string alamat, string role)
    {
        this.Id = id;
        this.Username = username;
        this.Password = password;
        this.Alamat = alamat;
        this.Role = role;
    }

    //properties
    public int Id { get => id; set => id = value; }
    public string Username { get => username; set => username = value; }
    public string Password { get => password; set => password = value; }
    public string Alamat { get => alamat; set => alamat = value; }
    public string Role { get => role; set => role = value; }
  }
}
