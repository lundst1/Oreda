using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace Oreda.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";
    
        /*public ObservableCollection<FileSystemItem> RootItems { get; } = new ObservableCollection<FileSystemItem>
        {
            new FileSystemItem("C:\\")  // eller annan startpunkt
        };*/
    }
}
