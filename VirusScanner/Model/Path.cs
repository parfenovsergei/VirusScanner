using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusScanner.Model
{
    public class Path
    {
        public static List<string> DirsPath { get; set; } = new List<string>();
        public static List<string> FilesPath { get; set; } = new List<string>();
        public static List<string> PeFilesPath { get; set; } = new List<string>();
        public static string SelectedBytesSuqence { get; set; }
        public static List<string> VirusFiles { get; set; } = new List<string>();
        public static string MainPath { get; set; }
    }
}
