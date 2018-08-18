using System.Collections.ObjectModel;
using org.ek.HandMeAFile.commons.UI.MVVM;
using org.ek.HandMeAFile.Model;

namespace org.ek.HandMeAFile.ViewModel
{
    public class FilePackViewModel
    {
        public string Label { get; set; }
        public ObservableCollection<string> Files { get; set; }
        public IExecCommand DeleteFilePack { get; set; }
        public object Tag { get; set; }
    }
}