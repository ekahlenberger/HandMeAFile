using System;
using System.Windows.Interop;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Interop
{
    public class WindowInteropHelperWrapper : IWindowInteropHelper
    {
        /// <summary>
        /// Erstellt den HWND des Fensters, wenn der HWND noch nicht erstellt wurde.
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.IntPtr"/>, das den HWND darstellt.
        /// </returns>
        public IntPtr EnsureHandle()
        {
            return m_orgHelper.EnsureHandle();
        }

        /// <summary>
        /// Ruft das Fensterhandle für ein Windows Presentation Foundation (WPF)-Fenster ab, in dem dieser <see cref="T:System.Windows.Interop.WindowInteropHelper"/> erstellt wird.
        /// </summary>
        /// <returns>
        /// Das Windows Presentation Foundation (WPF)-Fensterhandle (HWND).
        /// </returns>
        public IntPtr Handle => m_orgHelper.Handle;

        /// <summary>
        /// Ruft das Fensterhandle des Windows Presentation Foundation (WPF)-Besitzerfensters ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das Besitzerfensterhandle (HWND).
        /// </returns>
        public IntPtr Owner
        {
            get { return m_orgHelper.Owner; }
            set { m_orgHelper.Owner = value; }
        }

        private readonly WindowInteropHelper m_orgHelper;

        public WindowInteropHelperWrapper([NotNull] WindowInteropHelper orgHelper)
        {
            if (orgHelper == null) throw new ArgumentNullException(nameof(orgHelper));
            m_orgHelper = orgHelper;
        }
    }
}