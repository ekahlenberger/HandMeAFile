using System.Collections.ObjectModel;
using System.ComponentModel;
using org.ek.HandMeAFile.commons.UI.MVVM;

namespace org.ek.HandMeAFile.ViewModel
{
    public interface ISettingsWindowViewModel : INotifyPropertyChanged
    {
        ObservableCollection<FilePackViewModel> FilePacks { get; set; }
        IExecCommand LoadFilePacks { get; }
    }
}