using System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Interop;

namespace org.ek.HandMeAFile.commons.Native
{
    public interface IGetAndSetWindowPlacement
    {
        void SetPlacement(IWindowInteropHelper interop, string placement);
        string GetPlacement(IWindowInteropHelper interop);
        void SetPlacement(Window window, string placement);
        string GetPlacement(Window window);
    }
}