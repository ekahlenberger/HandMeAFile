using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Threading;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq;
using org.ek.HandMeAFile.commons.Tools;
using org.ek.HandMeAFile.commons.Tools.Application;
using org.ek.HandMeAFile.commons.Tools.SingleInstance;
using org.ek.HandMeAFile.commons.UI.MVVM.CommandCreation;
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
        private IDispatcher m_dispatcher;
        private Window m_settingsWindow;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            WcfMutexSingleInstanceRunner instanceRunner = new WcfMutexSingleInstanceRunner("8E756836-F0DE-490E-AEA5-EDAADF9C5FF8");
            if (!instanceRunner.Run(e))
            {
                instanceRunner.Dispose();
                Shutdown(0);
            }
            m_dispatcher = new DispatcherWrapper(Dispatcher.CurrentDispatcher);
            instanceRunner.SecondInstanceStarted += CreateSettingsWindow;
            
            
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
            m_packsRepository.Init(m_settings.FilePacks.Select(p => p.SetCount((p.ClipboardCount + 1)/2)).ToArray());
            

            IProvideContextMenu contextMenuProvider = new ContextMenuProvider();

            IContextMenu contextMenu = contextMenuProvider.Provide(new IMenuItem[0]);
            IProvideMenuItem menuItemProvider = new MenuItemProvider();
            IMenuItem settingsMenuItem = menuItemProvider.Provide("Settings");
            IMenuItem exitMenuItem = menuItemProvider.Provide("Exit");
            contextMenu.Add(menuItemProvider.Provide("-"));
            contextMenu.Add(settingsMenuItem);
            contextMenu.Add(exitMenuItem);
            settingsMenuItem.Click += CreateSettingsWindow;
            exitMenuItem.Click += (senderObj, args) => Shutdown(0);
            m_contextUpdater = new ContextMenuUpdater(m_packsRepository, contextMenu, menuItemProvider, clipboard);


            IRunTheTrayApp trayApplication = new TrayApplication(contextMenu,
                                                                 new ApplicationWrapper(this),
                                                                 new NotifyIconProvider(),
                                                                 new StaticIconProvider(new IconWrapper(HandMeAFile.Properties.Resources.HandMeAFile)),
                                                                 doubleClickAction: CreateSettingsWindow);
            trayApplication.Run();
        }

        private void CreateSettingsWindow(object sender, EventArgs e)
        {
            if (!m_dispatcher.CheckAccess())
            {
                Dispatcher.Invoke(() => CreateSettingsWindow(sender, e));
                return;
            }

            IProvideService<ICreateCommands<ProgressInfo>> commandCreatorProvider = new ServiceProvider<ICreateCommands<ProgressInfo>>();
            SettingsWindowViewModel viewModel = new SettingsWindowViewModel(m_packsRepository, commandCreatorProvider, m_dispatcher);
            commandCreatorProvider.Set(new CommandCreator<ProgressInfo>(new SimpleDefaultUiInteractionProvider<ProgressInfo>(viewModel.ExceptionHandler, viewModel.Progress)));

            m_settingsWindow = new SettingsWindow(viewModel);
            m_settingsWindow.Show();
        }
    }
}
