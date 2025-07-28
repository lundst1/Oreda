using OredaDL;


namespace OredaBL
{
    public class OredaManager
    {
        //Private instance of class  FileSystemScanner.
        private FileSystemScanner scanner = new FileSystemScanner();
        //Private instance of class DirectoryItem.
        private DirectoryItem scannedFiles;
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
        /// <param name="path"></param>
        public void Scan(string path) 
        { 
            scannedFiles = scanner.Scan(path);
        }
    }
}
