using System;
using System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class MenuItemWrapper : IMenuItem,IProvideOrgMenuItem
    {
        public MenuItem OrgMenuItem { get; }
        public MenuItemWrapper(MenuItem orgMenuItem)
        {
            OrgMenuItem = orgMenuItem;
        }

        /// <summary>
        /// Generiert ein <see cref="E:System.Windows.Forms.Control.Click"/>-Ereignis für <see cref="T:System.Windows.Forms.MenuItem"/>, wobei ein Mausklick durch einen Benutzer simuliert wird.
        /// </summary>
        public void PerformClick()
        {
            OrgMenuItem.PerformClick();
        }

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob das Menüelement sichtbar ist, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// true, wenn das Menüelement im Menü sichtbar gemacht wird, andernfalls false. Die Standardeinstellung ist true.
        /// </returns>
        public bool Visible
        {
            get => OrgMenuItem.Visible;
            set => OrgMenuItem.Visible = value;
        }

        public event EventHandler Click
        {
            add => OrgMenuItem.Click += value;
            remove => OrgMenuItem.Click -= value;
        }

        public void Add(IMenuItem item)
        {
            OrgMenuItem.MenuItems.Add(((IProvideOrgMenuItem)item).OrgMenuItem);
        }
        public void Remove(IMenuItem item)
        {
            OrgMenuItem.MenuItems.Remove(((IProvideOrgMenuItem)item).OrgMenuItem);
        }
        public void RemoveByKey(string name)
        {
            OrgMenuItem.MenuItems.RemoveByKey(name);
        }
        public void Clear()
        {
            OrgMenuItem.MenuItems.Clear();
        }
    }
}