using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusScanner.Controller
{
    public class CheckFileController
    {
        private byte[] MZ_ = { 77, 90 };
        private byte[] PE_ = { 80, 69 };

        public CheckFileController()
        {

        }
        public bool checkMZ(byte[] data)
        {
            return (data[0] == MZ_[0] && data[1] == MZ_[1]);
        }
        public bool checkPE(string path, byte[] data)
        {
            byte[] bufferPE = new byte[2];
            int ptr = BitConverter.ToInt32(data, 0);
            byte[] sourceArray = File.ReadAllBytes(path);
            Array.Copy((Array)sourceArray, ptr, (Array)bufferPE, 0, bufferPE.Length);
            return (bufferPE[0] == PE_[0] && bufferPE[1] == PE_[1]);
        }
    }
}
