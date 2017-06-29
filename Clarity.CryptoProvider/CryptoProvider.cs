using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Clarity.CryptoProvider
{
    public class CryptoProvider
    {
        private const string RandomPassword = "CLARITYO30976554GC9NF9QPZYDH0YE17WEB";
        private const string salt = "CLARITYOZZ75R8R54X8T4488T42XXJG9WEB";

        public string EncryptText(string plainText)
        {
            string encryptedText = null;
            byte[] plainBytes = Encoding.Unicode.GetBytes(plainText);
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(RandomPassword, Encoding.Unicode.GetBytes(salt), 1000);
            byte[] key = pdb.GetBytes(32);
            byte[] IV = pdb.GetBytes(32);

            MemoryStream ms = new MemoryStream();
            Rijndael encAlgo = Rijndael.Create();
            encAlgo.BlockSize = 256;
            encAlgo.Key = key;
            encAlgo.IV = IV;
            CryptoStream cs = new CryptoStream(ms, encAlgo.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(plainBytes, 0, plainBytes.Length);
            cs.Close();
            byte[] encBytes = ms.ToArray();
            encryptedText = Convert.ToBase64String(encBytes);
            return encryptedText;
        }

        public string decryptText(string encText)
        {
            string plainText = null;
            byte[] encBytes = Convert.FromBase64String(encText);
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(RandomPassword, Encoding.Unicode.GetBytes(salt), 1000);
            byte[] key = pdb.GetBytes(32);
            byte[] IV = pdb.GetBytes(32);

            MemoryStream ms = new MemoryStream();
            Rijndael encAlgo = Rijndael.Create();
            encAlgo.BlockSize = 256;
            encAlgo.Key = key;
            encAlgo.IV = IV;
            CryptoStream cs = new CryptoStream(ms, encAlgo.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(encBytes, 0, encBytes.Length);
            cs.Close();
            byte[] plainBytes = ms.ToArray();
            plainText = Encoding.Unicode.GetString(plainBytes);
            return plainText;
        }

        public string ValidateUserToken(string UserToken)
        {
            string NewUserToken = "";
            return NewUserToken;
        }
    }
}
