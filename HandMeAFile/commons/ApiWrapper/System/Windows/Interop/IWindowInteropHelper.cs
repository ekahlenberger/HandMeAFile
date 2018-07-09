using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Interop
{
    public interface IWindowInteropHelper
    {
        /// <summary>
        /// Erstellt den HWND des Fensters, wenn der HWND noch nicht erstellt wurde.
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.IntPtr"/>, das den HWND darstellt.
        /// </returns>
        IntPtr EnsureHandle();

        /// <summary>
        /// Ruft das Fensterhandle für ein Windows Presentation Foundation (WPF)-Fenster ab, in dem dieser <see cref="T:System.Windows.Interop.WindowInteropHelper"/> erstellt wird.
        /// </summary>
        /// <returns>
        /// Das Windows Presentation Foundation (WPF)-Fensterhandle (HWND).
        /// </returns>
        IntPtr Handle { get; }

        /// <summary>
        /// Ruft das Fensterhandle des Windows Presentation Foundation (WPF)-Besitzerfensters ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das Besitzerfensterhandle (HWND).
        /// </returns>
        IntPtr Owner { get; set; }
    }
}