using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg
{
    public class LearnCryptography
    {
        private static string IV;
        public static string EncryptSymmetric(string plainText)
        {
            Aes cipher = Aes.Create(); 
            cipher.Key = Encoding.UTF8.GetBytes("AAECAwQFBgcICQoLDA0ODw==");
            cipher.Padding = PaddingMode.ISO10126;
            //cipher.Mode = CipherMode.CBC;
            //cipher.Padding = PaddingMode.PKCS7;
            IV = Convert.ToBase64String(cipher.IV);
            //Create encryptor
            ICryptoTransform cryptoTransform = cipher.CreateEncryptor();
            // convert to bytes
            byte[] plaintextByte = Encoding.UTF8.GetBytes(plainText);
            //encrypt
            byte[] cipherText = cryptoTransform.TransformFinalBlock(plaintextByte,0, plaintextByte.Length);
            return Convert.ToBase64String(cipherText);
        }

        public static string DecryptSymmetric(string plainText)
        {
            Aes cipher = Aes.Create();
            cipher.Key = Encoding.UTF8.GetBytes("AAECAwQFBgcICQoLDA0ODw==");
            cipher.Padding = PaddingMode.ISO10126;
            //cipher.Mode = CipherMode.CBC;
            //cipher.Padding = PaddingMode.PKCS7;
            cipher.IV = Convert.FromBase64String(IV);
            //Create encryptor
            ICryptoTransform cryptoTransform = cipher.CreateDecryptor();
            // convert to bytes
            byte[] plaintextByte = Encoding.UTF8.GetBytes(plainText);
            //encrypt
            byte[] cipherText = cryptoTransform.TransformFinalBlock(plaintextByte, 0, plaintextByte.Length);
            return Encoding.UTF8.GetString(cipherText);
        }
    }
}
