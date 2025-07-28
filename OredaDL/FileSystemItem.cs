namespace OredaDL
{
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public abstract bool IsDirectory { get; }

    }
}
