using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.ViewModel
{
    public interface ISettingsWindowViewModel : INotifyPropertyChanged
    {
        
    }

    public class SettingsWindowViewModel : ISettingsWindowViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}