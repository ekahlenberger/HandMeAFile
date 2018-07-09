using System;

namespace org.ek.HandMeAFile.commons.Tools
{
    public interface INotifyOfClipboardUpdates : IDisposable
    {
        /// <summary>
        /// Occurs when the contents of the clipboard is updated.
        /// </summary>
        event EventHandler ClipboardUpdate;
    }
}