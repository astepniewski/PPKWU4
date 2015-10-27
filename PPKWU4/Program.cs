using Biblioteka2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPKWU4
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryption encryption = new Encryption();
            encryption.DecryptFile("plik.txt", null, "abcd");
        }
    }
}
