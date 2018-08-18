using System.Windows;
using org.ek.HandMeAFile.ViewModel;

namespace org.ek.HandMeAFile.View
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public ISettingsWindowViewModel ViewModel { get; set; }
        public SettingsWindow(ISettingsWindowViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
