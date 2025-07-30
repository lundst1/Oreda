using ReactiveUI;
using OredaDTO;
using System.Collections.ObjectModel;
using SkiaSharp;
using System.Linq;

namespace Oreda.ViewModels
{
    public class FileSystemViewModel : ReactiveObject
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public bool IsDirectory { get; }
        ObservableCollection<FileSystemViewModel>? Children { get; }
        public FileSystemViewModel(FileSystemItemDTO fileSystemItemDTO) 
        { 
            Name = fileSystemItemDTO.Name;
            FullPath = fileSystemItemDTO.FullPath;
            IsDirectory = fileSystemItemDTO.IsDirectory;
            
            if (fileSystemItemDTO.IsDirectory)
            {
                Children = new ObservableCollection<FileSystemViewModel>(fileSystemItemDTO.Children.Select(child => new FileSystemViewModel(child)));
            }
        }
    }
}
