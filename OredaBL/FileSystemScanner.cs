using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using OredaDL;
using OredaBL.Models;
using System.ComponentModel.Design.Serialization;

namespace OredaBL
{
    internal class FileSystemScanner
    {
        private Dictionary<string, FileSystemItem> index = new Dictionary<string, FileSystemItem>();

        public FileSystemScanResults Scan(string path)
        {
            FileSystemItem item = RecursiveScan(path);
            return new FileSystemScanResults { FileSystemItem = item, Index = index };
        }

        /// <summary>
        /// Method that traverses and scans a file system.
        /// </summary>
        /// <param name="path">Input - A string specifying the path of the starting points.</param>
        /// <returns>Returns an instance of class DirectoryItem.</returns>
        private DirectoryItem RecursiveScan(string path)
        {
            //TODO: Add validation for path.

            DirectoryItem currentDir = new DirectoryItem { Name = Path.GetFileName(path), FullPath = path };
            Index(path, currentDir);

            foreach (var dirPath in Directory.GetDirectories(path)) 
            {
                currentDir.Children.Add(RecursiveScan(dirPath));
            }
            foreach (var filePath in Directory.GetFiles(path))
            {
                FileItem item = new FileItem { Name = Path.GetFileName(filePath), FullPath = filePath }; 
                currentDir.Children.Add(item);
                Index(filePath, item);
            }

            return currentDir;
        }
        /// <summary>
        /// Method to index scanned items.
        /// </summary>
        /// <param name="path">Input - The path to the item.</param>
        /// <param name="item">Input - The item to be indexed.</param>
        private void Index(string path, FileSystemItem item)
        {
            index[path] = item;
        }
    }
}
