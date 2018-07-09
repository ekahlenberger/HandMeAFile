using System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Interop;

namespace org.ek.HandMeAFile.commons.Native
{
    public class WindowPlacementTransceiver : IGetAndSetWindowPlacement
    {
        private static readonly IProvideWindowInteropHelper InteropProvider = new WindowInteropHelperProvider();
        public void SetPlacement(Window window, string placement) => SetPlacement(InteropProvider.Provide(window),placement);

        public void SetPlacement(IWindowInteropHelper interop, string placement) => NativeWindowPlacement.SetPlacement(interop.Handle,placement);

        public string GetPlacement(Window window) => GetPlacement(InteropProvider.Provide(window));

        public string GetPlacement(IWindowInteropHelper interop) => NativeWindowPlacement.GetPlacement(interop.Handle);
    }
}