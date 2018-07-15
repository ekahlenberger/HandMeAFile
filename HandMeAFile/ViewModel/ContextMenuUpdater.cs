using System;
using System.Diagnostics;
using System.Linq;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.Model;

namespace org.ek.HandMeAFile.ViewModel
{
    public class ContextMenuUpdater : IUpdateTheContextMenu
    {
        private readonly IReadAndStoreFilePacks m_filePacksRepository;
        private readonly IContextMenu           m_contextMenu;
        private readonly IProvideMenuItem       m_menuItemProvider;
        private readonly IClipboard             m_clipboard;
        private          IMenuItem[]            m_defaultContextItems;

        public ContextMenuUpdater([NotNull] IReadAndStoreFilePacks filePacksRepository,
                                  [NotNull] IContextMenu contextMenu,
                                  [NotNull] IProvideMenuItem menuItemProvider,
                                  [NotNull] IClipboard clipboard)
        {
            Debug.Assert(filePacksRepository != null, nameof(filePacksRepository) + " != null");
            Debug.Assert(contextMenu         != null, nameof(contextMenu)         + " != null");
            Debug.Assert(menuItemProvider    != null, nameof(menuItemProvider)    + " != null");
            Debug.Assert(clipboard           != null, nameof(clipboard)           + " != null");


            m_filePacksRepository = filePacksRepository;
            m_contextMenu         = contextMenu;
            m_menuItemProvider    = menuItemProvider;
            m_clipboard           = clipboard;
            m_defaultContextItems = contextMenu.MenuItems;
            UpdateContextMenu();
            m_filePacksRepository.ClipboardFilePacksUpdated += FilePacksRepositoryOnClipboardFilePacksUpdated;
        }
        private void UpdateContextMenu()
        {
            m_contextMenu.Clear();
            m_filePacksRepository.GetTop(10).Run(pack =>
                                                 {
                                                     IMenuItem menuItem = m_menuItemProvider.Provide(pack.CommonAncestor, pack);
                                                     menuItem.Click += FilePackClick;
                                                     m_contextMenu.Add(menuItem);
                                                 });
            m_defaultContextItems.Run(m_contextMenu.Add);

        }
        private void FilePackClick(object sender, EventArgs e)
        {
            IMenuItem menuItem = (IMenuItem) sender;
            FilePack  pack     = (FilePack) menuItem.Tag;
            m_clipboard.SetFileDropList(pack);
        }
        private void FilePacksRepositoryOnClipboardFilePacksUpdated(object sender, EventArgs e)
        {
            UpdateContextMenu();
        }
    }
}