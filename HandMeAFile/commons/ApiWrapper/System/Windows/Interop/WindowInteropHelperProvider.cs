using System.Windows;
using System.Windows.Interop;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Interop
{
    public class WindowInteropHelperProvider : IProvideWindowInteropHelper
    {
        public IWindowInteropHelper Provide(Window window)
        {
            return new WindowInteropHelperWrapper(new WindowInteropHelper(window));
        }
    }
}