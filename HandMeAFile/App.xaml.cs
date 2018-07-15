using System;
using System.Windows;
using System.Windows.Controls;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq;
using org.ek.HandMeAFile.commons.Tools;
using org.ek.HandMeAFile.commons.Tools.Application;
using org.ek.HandMeAFile.Model;
using org.ek.HandMeAFile.View;
using org.ek.HandMeAFile.ViewModel;

namespace org.ek.HandMeAFile
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App
    {
        private IReadAndStoreFilePacks m_packsRepository;
        private IStoreSettings m_settings;
        private IUpdateTheContextMenu m_contextUpdater;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            #region Upgrade settings
            if (!HandMeAFile.Properties.Settings.Default.Updated)
            {
                HandMeAFile.Properties.Settings.Default.Updated = true;
                HandMeAFile.Properties.Settings.Default.Upgrade();
                HandMeAFile.Properties.Settings.Default.Save();

            } 
            #endregion

            IClipboard clipboard = new ClipboardWrapper();
            m_packsRepository = new ClipboardFilesRepository(new ClipboardNotifier(), clipboard);
            m_settings = new SettingsStorage(m_packsRepository, new FilePackSerializer(new XDocumentProvider()));
            m_packsRepository.Init(m_settings.FilePacks);
            

            IProvideContextMenu contextMenuProvider = new ContextMenuProvider();

            IContextMenu contextMenu = contextMenuProvider.Provide(new IMenuItem[0]);
            IProvideMenuItem menuItemProvider = new MenuItemProvider();
            IMenuItem settingsMenuItem = menuItemProvider.Provide("Settings");
            contextMenu.Add(menuItemProvider.Provide("-"));
            contextMenu.Add(settingsMenuItem);
            settingsMenuItem.Click += CreateSettingsWindow;
            m_contextUpdater = new ContextMenuUpdater(m_packsRepository, contextMenu, menuItemProvider, clipboard);


            IRunTheTrayApp trayApplication = new TrayApplication(contextMenu,
                                                                 new ApplicationWrapper(this),
                                                                 new NotifyIconProvider(),
                                                                 new StaticIconProvider(new IconWrapper(HandMeAFile.Properties.Resources.HandMeAFile)));
            trayApplication.Run();
        }

        private void CreateSettingsWindow(object sender, EventArgs e)
        {
            new SettingsWindow();
        }
    }
}
