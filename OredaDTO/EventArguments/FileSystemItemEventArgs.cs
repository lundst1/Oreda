using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredaDTO.EventArguments
{
    /// <summary>
    /// Event arguments for file system item events.
    /// </summary>
    public class FileSystemItemEventArgs : EventArgs
    {
        public FileSystemItemDTO fileSystemItemDTO {  get; set; }
    }
}
