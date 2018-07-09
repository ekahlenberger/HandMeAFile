using System;
using System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms;
using org.ek.HandMeAFile.commons.Tools.Application;
using org.ek.HandMeAFile.View;

namespace org.ek.HandMeAFile
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            IProvideContextMenu contextMenuProvider = new ContextMenuProvider();

            IContextMenu contextMenu = contextMenuProvider.Provide(new IMenuItem[0]);
            IProvideMenuItem menuItemProvider = new MenuItemProvider();
            IMenuItem settingsMenuItem = menuItemProvider.Provide("Settings");
            contextMenu.Add(settingsMenuItem);
            settingsMenuItem.Click += CreateSettingsWindow;
            
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
