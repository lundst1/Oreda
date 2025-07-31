using OredaBL;
using OredaDTO.EventArguments;
using System.ComponentModel.Design;
using System.IO;

namespace OredaSL
{
    public class OredaService
    {

        private OredaManager manager = new OredaManager();

        public delegate void EventHandler<IvalidDataEventArgs>(object sender, IvalidDataEventArgs e);
        public event EventHandler<IvalidDataEventArgs>? PathInvalid;
        public event EventHandler<FileSystemItemEventArgs>? FileSystemItemScanned;

        public OredaService()
        {
            manager.FileSystemItemScanned += OnFileSystemItemsScanned;
        }

        public void Scan(string path)
        {
            bool valid = Validate(path);

            if (valid)
            {
                manager.Scan(path);
            }
            else
            {
                IvalidDataEventArgs e = new IvalidDataEventArgs {Path = path, Message = "Path is invalid"};
                PathInvalid(path, e);
            }
        }
        private bool Validate (string path)
        {
            if (Directory.Exists(path) || File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void OnFileSystemItemsScanned(object sender, FileSystemItemEventArgs e)
        {
            FileSystemItemScanned(sender, e);   
        }
    }
}
