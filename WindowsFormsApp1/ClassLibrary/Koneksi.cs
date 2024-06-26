﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lib
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string conString = "Server=" + pS + ";Database=" + pD + ";Uid=" + pU + ";Pwd=;" + pP;
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            Connect();
        }

        public Koneksi()
        {
            Configuration myC = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSetting = myC.SectionGroups["userSettings"];
            var sectionSetting = userSetting.Sections["WindowsFormsApp1.db"] as ClientSettingsSection;

            string vServer = sectionSetting.Settings.Get("server").Value.ValueXml.InnerText;
            string vDb = sectionSetting.Settings.Get("dbname").Value.ValueXml.InnerText;
            string vUid = sectionSetting.Settings.Get("username").Value.ValueXml.InnerText;
            string vPwd = sectionSetting.Settings.Get("password").Value.ValueXml.InnerText;

            string conString = "Server=" + vServer + ";Database=" + vDb + ";Uid=" + vUid + ";Pwd=" + vPwd + ";";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            Connect();
        }

        public MySqlConnection KoneksiDB { get => koneksiDB; set => koneksiDB = value; }

        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader jalankanPerintahSelect(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            return cmd.ExecuteReader();
        }

        public static void jalankanPerintah(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            cmd.ExecuteNonQuery();
        }
    }
}
