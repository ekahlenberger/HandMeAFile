using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.Tools
{
    /// <summary>
    /// Provides notifications when the contents of the clipboard is updated.
    /// </summary>
    public class ClipboardNotifier : INotifyOfClipboardUpdates
    {
        /// <summary>
        /// Occurs when the contents of the clipboard is updated.
        /// </summary>
        public event EventHandler ClipboardUpdate;

        private readonly NotificationForm m_form = new NotificationForm();

        public ClipboardNotifier()
        {
            m_form.ClipboardUpdate += (sender, args) => OnClipboardUpdate(args);
        }
        /// <summary>
        /// Raises the <see cref="ClipboardUpdate"/> event.
        /// </summary>
        /// <param name="e">Event arguments for the event.</param>
        private void OnClipboardUpdate(EventArgs e)
        {
            ClipboardUpdate?.Invoke(this, e ?? EventArgs.Empty);
        }

        /// <summary>
        /// Hidden form to recieve the WM_CLIPBOARDUPDATE message.
        /// </summary>
        private class NotificationForm : Form
        {
            public event EventHandler ClipboardUpdate;
            public NotificationForm()
            {
                NativeMethods.SetParent(Handle, NativeMethods.HwndMessage);
                NativeMethods.AddClipboardFormatListener(Handle);
            }

            /// <summary>
            ///   Gibt die von der <see cref="T:System.Windows.Forms.Form" />-Klasse verwendeten Ressourcen (mit Ausnahme des Speichers) frei.
            /// </summary>
            /// <param name="disposing">
            ///   <see langword="true" />, um sowohl verwaltete als auch nicht verwaltete Ressourcen freizugeben, <see langword="false" />, um ausschließlich nicht verwaltete Ressourcen freizugeben.
            /// </param>
            protected override void Dispose(bool disposing)
            {
                NativeMethods.RemoveClipboardFormatListener(Handle);
                base.Dispose(disposing);
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == NativeMethods.WmClipboardupdate)
                {
                    OnClipboardUpdate();
                }
                base.WndProc(ref m);
            }

            protected virtual void OnClipboardUpdate()
            {
                ClipboardUpdate?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Dispose()
        {
            m_form?.Dispose();
        }
        private static class NativeMethods
        {
            // See http://msdn.microsoft.com/en-us/library/ms649021%28v=vs.85%29.aspx
            public const  int    WmClipboardupdate = 0x031D;
            public static readonly IntPtr HwndMessage       = new IntPtr(-3);

            // See http://msdn.microsoft.com/en-us/library/ms632599%28VS.85%29.aspx#message_only
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool AddClipboardFormatListener(IntPtr hwnd);

            // See http://msdn.microsoft.com/en-us/library/ms633541%28v=vs.85%29.aspx
            // See http://msdn.microsoft.com/en-us/library/ms649033%28VS.85%29.aspx
            [DllImport("user32.dll", SetLastError = true)]
            public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

            // See https://docs.microsoft.com/de-de/windows/desktop/api/winuser/nf-winuser-removeclipboardformatlistener
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool RemoveClipboardFormatListener(IntPtr hWndChild);
        }        
    }
}