using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public interface IContextMenu
    {
        event EventHandler Popup;
        IMenuItem[] MenuItems { get; }
        void Add(IMenuItem item);
        void Remove(IMenuItem item);
        void RemoveByKey(string name);
        void Clear();
    }
}