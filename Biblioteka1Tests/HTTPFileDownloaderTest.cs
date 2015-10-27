﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteka1;
using System.IO;
using System.Diagnostics;

namespace Biblioteka1Tests
{
    [TestClass]
    public class HTTPFileDownloaderTest
    {
        [TestMethod]
        public void TestDownloadedFileExists()
        {
            string fileName = "fileName.txt";
            HTTPFileDownloader fileDownloader = new HTTPFileDownloader();
            fileDownloader.DownloadFile("https://wordpress.org/plugins/about/readme.txt", fileName);

            Assert.IsTrue(File.Exists(fileName));

            File.Delete(fileName);
        }
    }
}
