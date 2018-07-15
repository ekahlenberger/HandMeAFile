using System;
using org.ek.HandMeAFile.Model;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public interface IMenuItem
    {
        event EventHandler Click;

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob das Menüelement sichtbar ist, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// true, wenn das Menüelement im Menü sichtbar gemacht wird, andernfalls false. Die Standardeinstellung ist true.
        /// </returns>
        bool Visible { get; set; }

        object Tag { get; set; }

        /// <summary>
        /// Generiert ein <see cref="E:System.Windows.Forms.Control.Click"/>-Ereignis für <see cref="T:System.Windows.Forms.MenuItem"/>, wobei ein Mausklick durch einen Benutzer simuliert wird.
        /// </summary>
        void PerformClick();

        void Add(IMenuItem item);
        void Remove(IMenuItem item);
        void RemoveByKey(string name);
        void Clear();
    }
}