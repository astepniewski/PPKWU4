﻿using System;
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

        [TestMethod]
        [ExpectedException(typeof(System.Security.Cryptography.CryptographicException))]
        public void FilePathIsNull_DecryptFile()
        {
            Encryption encryption = new Encryption();
            encryption.DecryptFile("plik.txt", null, "abc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EncryptedFilePathIsNull_DecryptFile()
        {
            Encryption encryption = new Encryption();
            encryption.DecryptFile(null, "plik.txt", "abc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PasswordIsNull_DecryptFile()
        {
            Encryption encryption = new Encryption();
            encryption.DecryptFile("plik.txt", "encrypted.txt", null);
        }
    }
}
