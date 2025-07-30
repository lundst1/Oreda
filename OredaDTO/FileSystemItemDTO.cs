namespace OredaDTO
{
    public class FileSystemItemDTO
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public bool IsDirectory { get; }
        public List<FileSystemItemDTO>? Children { get; set; }
    }
}
