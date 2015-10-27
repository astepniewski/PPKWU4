using Biblioteka3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka2
{
    public class Encryption
    {
        private AESHelper _aesHelper;
        public Encryption()
        {
            _aesHelper = new AESHelper();
        }
        public void EncryptFile(string filePath, string encryptedFilePath, string password)
        {
            byte[] bytesToBeEncrypted = File.ReadAllBytes(filePath);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = _aesHelper.AES_Encrypt(bytesToBeEncrypted, passwordBytes);
            File.WriteAllBytes(encryptedFilePath, bytesEncrypted);
        }
        public void DecryptFile(string encryptedFilePath, string filePath, string password)
        {
            byte[] bytesToBeDecrypted = File.ReadAllBytes(encryptedFilePath);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = _aesHelper.AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            File.WriteAllBytes(filePath, bytesDecrypted);
        }
    }
}
