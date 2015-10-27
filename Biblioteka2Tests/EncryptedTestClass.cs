using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteka2;

namespace Biblioteka2Tests
{
    [TestClass]
    public class EncryptedTestClass
    {   
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilePathIsNull_EncryptFile()
        {
            Encryption encryption = new Encryption();
            encryption.EncryptFile(null, "encrypted.txt", "password");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EncryptedFilePathIsNull_EncryptFile()
        {
            Encryption encryption = new Encryption();
            encryption.EncryptFile("plik.txt", null, "password");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PasswordIsNull_EncryptFile()
        {
            Encryption encryption = new Encryption();
            encryption.EncryptFile("plik.txt", "encrypted.txt", null);
        }
    }
}
