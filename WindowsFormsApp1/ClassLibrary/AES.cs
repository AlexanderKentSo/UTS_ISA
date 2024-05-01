using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace lib
{
    public class AES
    {
        public static void Main()
        {
            string original = "Data rahasia yang perlu dienkripsi";
            string password = "secretpassword";
            byte[] salt = Encoding.UTF8.GetBytes("randomsalt");

            using (System.Security.Cryptography.Aes aesAlg = System.Security.Cryptography.Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, salt);
                aesAlg.Key = keyDerivation.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = keyDerivation.GetBytes(aesAlg.BlockSize / 8);

                // Enkripsi
                byte[] encrypted = EncryptStringToBytes(original);

                // Dekripsi
                string roundtrip = DecryptStringFromBytes(encrypted);

                // Hasil
                Console.WriteLine("Data yang dienkripsi: {0}", original);
                Console.WriteLine("Data yang didekripsi: {0}", roundtrip);
            }
        }

        public static byte[] EncryptStringToBytes(string plainText)
        {
            byte[] encrypted;
            string password = "secretpassword";
            byte[] salt = Encoding.UTF8.GetBytes("randomsalt");

            using (System.Security.Cryptography.Aes aesAlg = System.Security.Cryptography.Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, salt);
                aesAlg.Key = keyDerivation.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = keyDerivation.GetBytes(aesAlg.BlockSize / 8);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        public static string DecryptStringFromBytes(byte[] cipherText)
        {
            string plaintext = null;
            string password = "secretpassword";
            byte[] salt = Encoding.UTF8.GetBytes("randomsalt");

            using (System.Security.Cryptography.Aes aesAlg = System.Security.Cryptography.Aes.Create())
            {
                Rfc2898DeriveBytes keyDerivation = new Rfc2898DeriveBytes(password, salt);
                aesAlg.Key = keyDerivation.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = keyDerivation.GetBytes(aesAlg.BlockSize / 8);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}