using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Biblioteka3
{
    public class FileFormatRecognizer
    {
        protected Image image;

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
                PictureBox pb = new PictureBox();
                pb.Image = System.Drawing.Image.FromFile(filename);
            }
            else if(soundFileFormats.Contains(fileFormat))
            {
                System.Console.Write("Plik dzwiekowy");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(filename);
                player.Play();
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
