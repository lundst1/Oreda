using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredaDL
{
    public class FileItem : FileSystemItem
    {
        public override bool IsDirectory => false;
    }
}
