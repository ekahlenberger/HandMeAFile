using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms;

namespace org.ek.HandMeAFile.commons.Tools.Application
{
    public class TrayApplication : IRunTheTrayApp
    {
        private readonly IContextMenu m_contextMenu;
        private readonly IApplication m_application;
        private readonly IProvideNotifyIcon m_notifyIconProvider;
        private readonly IProvideIcon m_trayIconProvider;
        private readonly IRunTheBackgroundTrayApp m_background;
        private INotifyIcon m_notifyIcon;
        private bool m_stop;

        public TrayApplication([NotNull] IContextMenu contextMenu,
                               [NotNull] IApplication application,
                               [NotNull] IProvideNotifyIcon notifyIconProvider,
                               [NotNull] IProvideIcon trayIconProvider,
                               [CanBeNull] IRunTheBackgroundTrayApp background = null)
        {
            m_contextMenu = contextMenu ?? throw new ArgumentNullException(nameof(contextMenu));
            m_application = application ?? throw new ArgumentNullException(nameof(application));
            m_notifyIconProvider = notifyIconProvider ?? throw new ArgumentNullException(nameof(notifyIconProvider));
            m_trayIconProvider = trayIconProvider ?? throw new ArgumentNullException(nameof(trayIconProvider));
            m_background = background;

            m_notifyIcon = m_notifyIconProvider.Provide();
            m_application.Exit += ApplicationOnExit;
            m_notifyIcon.Visible = true;
            m_notifyIcon.ContextMenu = m_contextMenu;
        }

        private void ApplicationOnExit(object sender, ExitEventArgs exitEventArgs)
        {
            m_notifyIcon?.Dispose();
            m_stop = true;
        }

        public void Run()
        {
            Task.Run(() =>
                     {
                         while (!m_stop)
                         {
                             try
                             {
                                 m_background?.Run();
                                 if (m_notifyIcon != null)
                                     m_notifyIcon.Icon = m_trayIconProvider.Get();
                                 Thread.Sleep(m_background?.SleepTime ?? 100);
                             }
                             catch (Exception ex)
                             {
                                 Console.WriteLine(ex.Message);
                             }
                         }
                     });
        }
    }
}