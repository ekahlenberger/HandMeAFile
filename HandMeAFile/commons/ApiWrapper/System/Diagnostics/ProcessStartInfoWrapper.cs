using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public class ProcessStartInfoWrapper : IProcessStartInfo, IProvideOrgProcessStartInfo
    {
        private ProcessStartInfo m_orgPsi;
        public ProcessStartInfoWrapper(ProcessStartInfo orgPsi)
        {
            m_orgPsi = orgPsi;
        }
        /// <summary>Ruft den Fensterzustand ab, der beim Starten des Prozesses verwendet werden soll, oder legt diesen fest.</summary>
        /// <returns>Einer der Enumerationswerte, der angibt, ob der Prozess in einem maximierten, minimierten, normalen (weder maximierten noch minimierten) oder in einem nicht sichtbaren Fenster gestartet wird. Der Standardwert ist Normal.</returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Der Fensterstil gehört nicht zu den <see cref="T:System.Diagnostics.ProcessWindowStyle" />-Enumerationsmembern.</exception>
        public ProcessWindowStyle WindowStyle
        {
            get { return m_orgPsi.WindowStyle; }
            set { m_orgPsi.WindowStyle = value; }
        }

        /// <summary>Ruft das Fensterhandle ab, das beim Anzeigen eines Fehlerdialogfelds für einen fehlgeschlagenen Prozessstart verwendet wird, oder legt dieses fest.</summary>
        /// <returns>Ein Zeiger auf das Handle des Fehlerdialogfelds, das aus einem fehlerhaften Prozessstart resultiert.</returns>
        public IntPtr ErrorDialogParentHandle
        {
            get { return m_orgPsi.ErrorDialogParentHandle; }
            set { m_orgPsi.ErrorDialogParentHandle = value; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob dem Benutzer ein Fehlerdialogfeld angezeigt wird, wenn der Prozess nicht gestartet werden kann, oder legt diesen fest.</summary>
        /// <returns>true, wenn auf dem Bildschirm ein Fehlerdialogfeld angezeigt werden soll, wenn der Prozess nicht gestartet werden kann, andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool ErrorDialog
        {
            get { return m_orgPsi.ErrorDialog; }
            set { m_orgPsi.ErrorDialog = value; }
        }

        /// <summary>Wenn die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> Eigenschaft false ist, ruft das Arbeitsverzeichnis für den zu startenden Prozess ab oder legt ihn fest,. Wenn <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />true ist, ruft das Verzeichnis ab, das den zu startenden Prozess enthält oder legt ihn fest.</summary>
        /// <returns>Wenn <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> ist true, der voll gekennzeichnete Name des Verzeichnisses, das den zu startenden Prozess enthält. Wenn die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> Eigenschaft false ist, das Arbeitsverzeichnis für den zu startenden Prozess. Der Standardwert ist eine leere Zeichenfolge ("").</returns>
        public string WorkingDirectory
        {
            get { return m_orgPsi.WorkingDirectory; }
            set { m_orgPsi.WorkingDirectory = value; }
        }

        /// <summary>Ruft die zu startende Anwendung oder das zu startende Dokument ab oder legt die Anwendung bzw. das Dokument fest.</summary>
        /// <returns>Der Name der zu startenden Anwendung oder der Dokumentname eines einer Anwendung zugeordneten Dateityps, für den eine Standard-Open-Aktion verfügbar ist. Der Standardwert ist eine leere Zeichenfolge ("").</returns>
        public string FileName
        {
            get { return m_orgPsi.FileName; }
            set { m_orgPsi.FileName = value; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob das Windows-Benutzerprofil aus der Registrierung geladen werden soll, oder legt diesen fest.</summary>
        /// <returns>true, wenn das Windows-Benutzerprofil geladen werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool LoadUserProfile
        {
            get { return m_orgPsi.LoadUserProfile; }
            set { m_orgPsi.LoadUserProfile = value; }
        }

        /// <summary>Ruft einen Wert ab, der die Domäne kennzeichnet, die beim Starten des Prozesses verwendet werden soll, oder legt diesen fest.</summary>
        /// <returns>Die Active Directory-Domäne, die beim Starten des Prozesses verwendet werden soll. Die Domäneneigenschaft ist hauptsächlich für Benutzer in Unternehmensumgebungen von Interesse, die Active Directory verwenden.</returns>
        public string Domain
        {
            get { return m_orgPsi.Domain; }
            set { m_orgPsi.Domain = value; }
        }

        /// <summary>Ruft eine sichere Zeichenfolge ab, die das Benutzerkennwort enthält, das beim Starten des Prozesses verwendet werden soll, oder legt diese fest.</summary>
        /// <returns>Das beim Starten des Prozesses zu verwendende Kennwort.</returns>
        public SecureString Password
        {
            get { return m_orgPsi.Password; }
            set { m_orgPsi.Password = value; }
        }

        /// <summary>Ruft den beim Starten des Prozesses zu verwendenden Benutzernamen ab oder legt diesen fest.</summary>
        /// <returns>Der beim Starten des Prozesses zu verwendende Benutzername.</returns>
        public string UserName
        {
            get { return m_orgPsi.UserName; }
            set { m_orgPsi.UserName = value; }
        }

        /// <summary>Ruft den Satz der Verben ab, der dem durch die <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebenen Dateityp zugeordnet ist.</summary>
        /// <returns>Die Aktionen, die das System auf die durch die <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebene Datei anwenden kann.</returns>
        public string[] Verbs
        {
            get { return m_orgPsi.Verbs; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob zum Starten des Prozesses die Betriebssystemshell verwendet werden soll, oder legt diesen fest.</summary>
        /// <returns>true, wenn beim Starten des Prozesses die Shell verwendet werden soll; false, wenn der Prozess direkt von der ausführbaren Datei aus erstellt werden soll. Die Standardeinstellung ist true.</returns>
        public bool UseShellExecute
        {
            get { return m_orgPsi.UseShellExecute; }
            set { m_orgPsi.UseShellExecute = value; }
        }
        /// <summary>Ruft einen Wert ab, der angibt, ob die Fehlerausgabe einer Anwendung in den <see cref="P:System.Diagnostics.Process.StandardError" />-Stream geschrieben wird, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Fehlerausgabe in <see cref="P:System.Diagnostics.Process.StandardError" /> geschrieben werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool RedirectStandardError
        {
            get { return m_orgPsi.RedirectStandardError; }
            set { m_orgPsi.RedirectStandardError = value; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Ausgabe einer Anwendung in den <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream geschrieben wird, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Ausgabe in <see cref="P:System.Diagnostics.Process.StandardOutput" /> geschrieben werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool RedirectStandardOutput
        {
            get { return m_orgPsi.RedirectStandardOutput; }
            set { m_orgPsi.RedirectStandardOutput = value; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Eingabe für eine Anwendung aus dem <see cref="P:System.Diagnostics.Process.StandardInput" />-Stream gelesen wird, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Eingabe von <see cref="P:System.Diagnostics.Process.StandardInput" /> gelesen werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool RedirectStandardInput
        {
            get { return m_orgPsi.RedirectStandardInput; }
            set { m_orgPsi.RedirectStandardInput = value; }
        }

        /// <summary>Ruft Suchpfade für Dateien, Verzeichnisse für temporäre Dateien, anwendungsspezifische Optionen und andere ähnliche Informationen ab.</summary>
        /// <returns>Ein Zeichenfolgenwörterbuch, das Umgebungsvariablen für diesen Prozess und untergeordnete Prozesse bereitstellt. Der Standardwert ist null.</returns>
        public StringDictionary EnvironmentVariables
        {
            get { return m_orgPsi.EnvironmentVariables; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob der Prozess in einem neuen Fenster gestartet werden soll, oder legt diesen fest.</summary>
        /// <returns>true, wenn der Prozess ohne Erstellung eines neuen, für ihn bestimmten Fensters gestartet werden soll, andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool CreateNoWindow
        {
            get { return m_orgPsi.CreateNoWindow; }
            set { m_orgPsi.CreateNoWindow = value; }
        }

        /// <summary>Ruft den Satz von Befehlszeilenargumenten ab, die beim Starten der Anwendung verwendet werden sollen, oder legt diesen fest.</summary>
        /// <returns>Dateitypspezifische Argumente, die das System der in der <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebenen Anwendung zuordnen kann. Der Standardwert ist eine leere Zeichenfolge (""). Unter Windows Vista und früheren Versionen des Windows-Betriebssystems muss die Länge der Argumente, die der Länge des vollständigen Pfads des Prozesses hinzugefügt werden, kleiner sein als 2080. Unter Windows 7 und höheren Versionen muss die Länge kleiner als 32699 sein.</returns>
        public string Arguments
        {
            get { return m_orgPsi.Arguments; }
            set { m_orgPsi.Arguments = value; }
        }

        /// <summary>Ruft das Verb ab, das beim Öffnen der in der <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebenen Anwendung oder des in dieser Eigenschaft angegebenen Dokuments verwendet wird, oder legt dieses fest.</summary>
        /// <returns>Die Aktion, die mit der vom Prozess geöffneten Datei durchzuführen ist. Der Standardwert ist eine leere Zeichenfolge (""), die keine Aktion angibt.</returns>
        public string Verb
        {
            get { return m_orgPsi.Verb; }
            set { m_orgPsi.Verb = value; }
        }

        public ProcessStartInfo OrgInfo => m_orgPsi;
    }
}