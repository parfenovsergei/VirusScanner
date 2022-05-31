using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusScanner.Model;

namespace VirusScanner.Controller
{
    public class DirsController
    {
        CheckFileController _checkFile;
        public DirsController()
        {
            _checkFile = new CheckFileController();
        }
        public async Task<List<string>> GetFiles(string startPath)
        {
            List<string> ls = new List<string>();
            try
            {
                string[] strArray = Directory.GetDirectories(startPath);
                for (int index = 0; index < strArray.Length; ++index)
                {
                    string startPath1 = strArray[index];
                    List<string> stringList = ls;
                    stringList.AddRange((IEnumerable<string>)await this.GetFiles(startPath1));
                    stringList = (List<string>)null;
                }
                strArray = (string[])null;
                foreach (string file in Directory.GetFiles(startPath))
                    ls.Add(file);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<string> files = ls;
            ls = (List<string>)null;
            return files;
        }

        public async Task<bool> CheckFiles(string file)
        {
            byte[] buffer = new byte[64];
            byte[] bufferPE = new byte[4];
            byte[] bufferMZ = new byte[2];
            try
            {
                using (FileStream fstream = File.OpenRead(file))
                {
                    await fstream.ReadAsync(buffer, 0, buffer.Length);
                    Array.Copy((Array)buffer, 0, (Array)bufferMZ, 0, bufferMZ.Length);
                    if (_checkFile.checkMZ(bufferMZ))
                    {
                        Array.Copy((Array)buffer, 60, (Array)bufferPE, 0, bufferPE.Length);
                        if (_checkFile.checkPE(file, bufferPE))
                        {
                            Model.Path.PeFilesPath.Add(file);
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
            }
            return false;
        }
    }
}
