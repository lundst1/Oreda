using OredaDL;
using OredaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredaBL.Mappers
{
    /// <summary>
    /// Class that maps FileSystemItem
    /// </summary>
    internal class FileSystemItemMapper
    {
        /// <summary>
        /// Internal method to map FileSystemItem to FileSystemItemDTO
        /// </summary>
        /// <param name="item">Input - An implementation of abstract class FileSystemItem.</param>
        /// <returns>An instance of class FileSystemItemDTO.</returns>
        /// <exception cref="NotSupportedException"></exception>
        internal static FileSystemItemDTO ToFileSystemItemDTO(FileSystemItem item)
        {
            return item switch
            {
                FileItem file => ToFileSystemItemDTO(file),
                DirectoryItem directory => ToFileSystemItemDTO(directory),
                _ => throw new NotSupportedException($"Unknown FileSystemItem type: {item.GetType().Name}")
            };
        }
        private static FileSystemItemDTO ToFileSystemItemDTO(FileItem item) 
        {
            return new FileSystemItemDTO { Name = item.Name, FullPath = item.FullPath };
        }
        private static FileSystemItemDTO ToFileSystemItemDTO(DirectoryItem item)
        {
            return new FileSystemItemDTO { Name = item.Name, FullPath = item.FullPath, Children = item.Children.Select(ToFileSystemItemDTO).ToList() };
        }
    }
}
