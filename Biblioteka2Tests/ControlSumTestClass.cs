using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteka3;

namespace Biblioteka2Tests
{
    [TestClass]
    public class ControlSumTestClass
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FilePathIsNull_MD5sum()
        {
            ControlSum controlSum = new ControlSum();
            controlSum.MD5SUm(null);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void FileIsNotFound_MD5sum()
        {
            ControlSum controlSum = new ControlSum();
            controlSum.MD5SUm("asd.txt");
        }  

    }
}
