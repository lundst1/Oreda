using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredaDL
{
    public class DirectoryItem : FileSystemItem
    {
        public override bool IsDirectory => true;
        public List<FileSystemItem> Children { get; set; } = new();
    }
}
