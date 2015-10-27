using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka3
{
    public class ControlSum
    {
        public byte[] MD5SUm(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return md5.ComputeHash(stream);
                }
            }
        }

        public byte[] SHASUM(string filePath)
        {
            using (var sha = SHA1.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return sha.ComputeHash(stream);
                }
            }
        }
    }
}
