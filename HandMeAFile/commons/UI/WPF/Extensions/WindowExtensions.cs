using System.Windows;
using org.ek.HandMeAFile.commons.Native;

namespace org.ek.HandMeAFile.commons.UI.WPF.Extensions
{
    public static class WindowExtensions
    {
        // ReSharper disable once FieldCanBeMadeReadOnly.Global
        public static IGetAndSetWindowPlacement PlacementTransceiver = new WindowPlacementTransceiver();
        public static string GetPlacement(this Window w) => PlacementTransceiver.GetPlacement(w);
        public static void SetPlacement(this Window w, string placement) => PlacementTransceiver.SetPlacement(w, placement);
    }
}