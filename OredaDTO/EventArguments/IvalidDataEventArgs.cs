using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OredaDTO.EventArguments
{
    /// <summary>
    /// Class for event arguments for events that occur when data is invalid.
    /// </summary>
    public class IvalidDataEventArgs : EventArgs
    {
        /// <summary>
        /// The path that is invalid.
        /// Both read and write access.
        /// </summary>
        public string Path {  get; set; }
        /// <summary>
        /// A message describing what data is invalid.
        /// Both read and write access.
        /// </summary>
        public string Message { get; set; }
    }
}
