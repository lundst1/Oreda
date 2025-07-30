using OredaDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredaBL.Models
{
    /// <summary>
    /// Class for passing scan results of a file system scan.
    /// </summary>
    internal class FileSystemScanResults
    {
        public FileSystemItem FileSystemItem { get; set; }
        public Dictionary<string, FileSystemItem> Index { get; set; }
    }
}
