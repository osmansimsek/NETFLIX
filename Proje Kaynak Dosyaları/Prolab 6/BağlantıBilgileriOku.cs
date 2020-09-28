using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prolab_6
{
    public class BağlantıBilgileriOku
    {
        public string datasource { get; set; }
        public string port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string DosyaYolu { get; set; }

        public BağlantıBilgileriOku()
        {
            DosyaYolu = "..\\..\\..\\BağlantıBilgileri.txt";
            DosyaOku();
        }

        private void DosyaOku()
        {
            FileStream fileStream = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            string read = streamReader.ReadToEnd();
            List<string> readList = read.Split(',').ToList();

            datasource = readList[0];
            port = readList[1];
            username = readList[2];
            password = readList[3];

            streamReader.Close();
            fileStream.Close();
        }
    }
}
