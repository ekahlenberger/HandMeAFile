using System.Windows;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Threading;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows
{
    public interface IApplication
    {
        /// <summary>Ruft den <see cref="T:System.Windows.Threading.Dispatcher" /> ab, der diesem <see cref="T:System.Windows.Threading.DispatcherObject" /> zugeordnet ist.</summary>
        /// <returns>Der Verteiler.</returns>
        IDispatcher Dispatcher { get; }

        /// <summary>Bestimmt, ob der aufrufende Thread auf dieses <see cref="T:System.Windows.Threading.DispatcherObject" /> zugreifen kann.</summary>
        /// <returns>true, wenn der aufrufende Thread auf dieses Objekt zugreifen kann, andernfalls false.</returns>
        bool CheckAccess();

        /// <summary>Fährt eine Anwendung herunter.</summary>
        void Shutdown();

        /// <summary>Fährt eine Anwendung herunter, die den angegebenen Exitcode an das Betriebssystem zurückgibt.</summary>
        /// <param name="exitCode">Ein ganzzahliger Exitcode für eine Anwendung. Der Standardexitcode ist 0 (null).</param>
        void Shutdown(int exitCode);

        /// <summary>
        /// Tritt kurz vor dem Herunterfahren einer Anwendung auf und kann nicht abgebrochen werden.
        /// </summary>
        event ExitEventHandler Exit;
    }
}