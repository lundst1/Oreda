using OredaDL;
using OredaBL.Models;

namespace OredaBL
{
    public class OredaManager
    {
        //Private instance of class  FileSystemScanner.
        private FileSystemScanner scanner = new FileSystemScanner();
        //Private instance of class DirectoryItem.
        private FileSystemItem scannedFiles;
        //Private dictionary containing index of scanned items.
        private Dictionary<string, FileSystemItem> index;
        /// <summary>
        /// Constructor for the class OredaManager
        /// </summary>
        public OredaManager()
        {
        }
        /// <summary>
        /// Method to scan file system.
        /// Calls method scan of same name.
        /// </summary>
        /// <param name="path">Input - An instance of class file, containing a path to be scanned.</param>
        public void Scan(string path) 
        { 
            FileSystemScanResults results = scanner.Scan(path);
            scannedFiles = results.FileSystemItem;
            index = results.Index;
        }
    }
}
