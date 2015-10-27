using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka3
{
    public class FileFormatRecognizer
    {
        public void FileFormatRecognition(string filename)
        {
            //JPG, PNG, GIF,TGA
            HashSet<string> graphicFileFormats = new HashSet<string>();
            graphicFileFormats.Add("jpg");
            graphicFileFormats.Add("png");
            graphicFileFormats.Add("gif");
            graphicFileFormats.Add("tga");

            HashSet<string> soundFileFormats = new HashSet<string>();
            soundFileFormats.Add("wav");
            soundFileFormats.Add("mp3");
            soundFileFormats.Add("aac");

            String fileFormat = System.IO.Path.GetExtension(filename);

            if (graphicFileFormats.Contains(fileFormat)) 
            {
                System.Console.Write("Plik obrazkowy");

            }
            else if(soundFileFormats.Contains(fileFormat))
            {
                System.Console.Write("Plik dzwiekowy");
            }
            else if (fileFormat.Equals("zip"))
            {
                System.Console.Write("Plik zip");
            }
            else if (fileFormat.Equals("aes"))
            {
                System.Console.Write("Plik zaszyfrowany");
            }
            else
            {
                System.Console.Write("Plik nieobsługiwany");
            }
        }
    }
}
