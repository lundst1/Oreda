using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using OredaDL;
using System.ComponentModel.Design.Serialization;

namespace OredaBL
{
    internal class FileSystemScanner
    {
        /// <summary>
        /// Method that traverses and scans a file system.
        /// </summary>
        /// <param name="path">Input - A string specifying the path of the starting points.</param>
        /// <returns>Returns an instance of class DirectoryItem.</returns>
        public DirectoryItem Scan(string path)
        {
            //TODO: Add validation for path.

            DirectoryItem currentDir = new DirectoryItem { Name = Path.GetFileName(path), FullPath = path };

            foreach (var dirPath in Directory.GetFiles(path)) 
            {
                currentDir.Children.Add(Scan(dirPath));
            }
            foreach (var filePath in Directory.GetFiles(path))
            {
                currentDir.Children.Add(new FileItem{ Name = Path.GetFileName(filePath), FullPath = filePath });
            }

            return currentDir;
        }
    }
}
