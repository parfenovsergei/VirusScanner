using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusScanner.Model;
using System.IO;

namespace VirusScanner.Controller
{
    public class ScanFileController
    {
        public ScanFileController()
        {

        }
        public string HexToString(string hex)
        {
            var bytes = new byte[hex.Length / 2];
            for (int i = 0, j = 0; i < hex.Length; i += 2, j++)
                bytes[j] = Convert.ToByte(hex.Substring(i, 2), 16);
            return Encoding.Default.GetString(bytes);
        }
        public async Task<bool> scanFiles(string path)
        {
            string bytes = HexToString(Model.Path.SelectedBytesSuqence);
            try
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    byte[] buffer = new byte[fstream.Length];
                    await fstream.ReadAsync(buffer, 0, buffer.Length);
                    string textFromFile = Encoding.Default.GetString(buffer, 0, buffer.Length);
                    return textFromFile.Contains(bytes);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
