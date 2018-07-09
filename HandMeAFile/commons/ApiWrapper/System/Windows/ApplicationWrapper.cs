using System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Threading;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows
{
    public class ApplicationWrapper : IApplication
    {
        
        /// <summary>Ruft den <see cref="T:System.Windows.Threading.Dispatcher" /> ab, der diesem <see cref="T:System.Windows.Threading.DispatcherObject" /> zugeordnet ist.</summary>
        /// <returns>Der Verteiler.</returns>
        public IDispatcher Dispatcher => new DispatcherWrapper(m_orgApp.Dispatcher);
        /// <summary>
        /// Tritt kurz vor dem Herunterfahren einer Anwendung auf und kann nicht abgebrochen werden.
        /// </summary>
        public event ExitEventHandler Exit
        {
            add { m_orgApp.Exit += value; }
            remove { m_orgApp.Exit -= value; }
        }

        private Application m_orgApp;
        public ApplicationWrapper(Application orgApp)
        {
            m_orgApp = orgApp;
        }
        /// <summary>Bestimmt, ob der aufrufende Thread auf dieses <see cref="T:System.Windows.Threading.DispatcherObject" /> zugreifen kann.</summary>
        /// <returns>true, wenn der aufrufende Thread auf dieses Objekt zugreifen kann, andernfalls false.</returns>
        public bool CheckAccess()
        {
            return m_orgApp.CheckAccess();
        }
        /// <summary>Fährt eine Anwendung herunter.</summary>
        public void Shutdown()
        {
            m_orgApp.Shutdown();
        }

        /// <summary>Fährt eine Anwendung herunter, die den angegebenen Exitcode an das Betriebssystem zurückgibt.</summary>
        /// <param name="exitCode">Ein ganzzahliger Exitcode für eine Anwendung. Der Standardexitcode ist 0 (null).</param>
        public void Shutdown(int exitCode)
        {
            m_orgApp.Shutdown(exitCode);
        }
    }
}