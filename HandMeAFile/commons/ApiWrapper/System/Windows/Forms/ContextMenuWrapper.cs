using System;
using System.Linq;
using System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class ContextMenuWrapper : IContextMenu, IProvideOrgContextMenu
    {
        public event EventHandler Popup
        {
            add => OrgMenu.Popup += value;
            remove => OrgMenu.Popup -= value;
        }

        public IMenuItem[] MenuItems => OrgMenu.MenuItems.OfType<MenuItem>().Select(omi => new MenuItemWrapper(omi)).OfType<IMenuItem>().ToArray();
        public ContextMenuWrapper(ContextMenu orgMenu)
        {
            OrgMenu = orgMenu;
        }
        public void Add(IMenuItem item)
        {
            OrgMenu.MenuItems.Add(((IProvideOrgMenuItem) item).OrgMenuItem);
        }
        public void Remove(IMenuItem item)
        {
            OrgMenu.MenuItems.Remove(((IProvideOrgMenuItem) item).OrgMenuItem);
        }
        public void RemoveByKey(string name)
        {
            OrgMenu.MenuItems.RemoveByKey(name);
        }
        public void Clear()
        {
            OrgMenu.MenuItems.Clear();
        }

        public ContextMenu OrgMenu { get; }
    }
}