using System.Windows;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Interop
{
    public interface IProvideWindowInteropHelper
    {
        IWindowInteropHelper Provide(Window window);
    }
}