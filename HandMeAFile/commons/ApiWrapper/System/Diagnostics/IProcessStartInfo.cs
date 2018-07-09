using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public interface IProcessStartInfo
    {
        /// <summary>Ruft den Fensterzustand ab, der beim Starten des Prozesses verwendet werden soll, oder legt diesen fest.</summary>
        /// <returns>Einer der Enumerationswerte, der angibt, ob der Prozess in einem maximierten, minimierten, normalen (weder maximierten noch minimierten) oder in einem nicht sichtbaren Fenster gestartet wird. Der Standardwert ist Normal.</returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Der Fensterstil gehört nicht zu den <see cref="T:System.Diagnostics.ProcessWindowStyle" />-Enumerationsmembern.</exception>
        ProcessWindowStyle WindowStyle { get; set; }

        /// <summary>Ruft das Fensterhandle ab, das beim Anzeigen eines Fehlerdialogfelds für einen fehlgeschlagenen Prozessstart verwendet wird, oder legt dieses fest.</summary>
        /// <returns>Ein Zeiger auf das Handle des Fehlerdialogfelds, das aus einem fehlerhaften Prozessstart resultiert.</returns>
        IntPtr ErrorDialogParentHandle { get; set; }

        /// <summary>Ruft einen Wert ab, der angibt, ob dem Benutzer ein Fehlerdialogfeld angezeigt wird, wenn der Prozess nicht gestartet werden kann, oder legt diesen fest.</summary>
        /// <returns>true, wenn auf dem Bildschirm ein Fehlerdialogfeld angezeigt werden soll, wenn der Prozess nicht gestartet werden kann, andernfalls false. Die Standardeinstellung ist false.</returns>
        bool ErrorDialog { get; set; }

        /// <summary>Wenn die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> Eigenschaft false ist, ruft das Arbeitsverzeichnis für den zu startenden Prozess ab oder legt ihn fest,. Wenn <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />true ist, ruft das Verzeichnis ab, das den zu startenden Prozess enthält oder legt ihn fest.</summary>
        /// <returns>Wenn <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> ist true, der voll gekennzeichnete Name des Verzeichnisses, das den zu startenden Prozess enthält. Wenn die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> Eigenschaft false ist, das Arbeitsverzeichnis für den zu startenden Prozess. Der Standardwert ist eine leere Zeichenfolge ("").</returns>
        string WorkingDirectory { get; set; }

        /// <summary>Ruft die zu startende Anwendung oder das zu startende Dokument ab oder legt die Anwendung bzw. das Dokument fest.</summary>
        /// <returns>Der Name der zu startenden Anwendung oder der Dokumentname eines einer Anwendung zugeordneten Dateityps, für den eine Standard-Open-Aktion verfügbar ist. Der Standardwert ist eine leere Zeichenfolge ("").</returns>
        string FileName { get; set; }

        /// <summary>Ruft einen Wert ab, der angibt, ob das Windows-Benutzerprofil aus der Registrierung geladen werden soll, oder legt diesen fest.</summary>
        /// <returns>true, wenn das Windows-Benutzerprofil geladen werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        bool LoadUserProfile { get; set; }

        /// <summary>Ruft einen Wert ab, der die Domäne kennzeichnet, die beim Starten des Prozesses verwendet werden soll, oder legt diesen fest.</summary>
        /// <returns>Die Active Directory-Domäne, die beim Starten des Prozesses verwendet werden soll. Die Domäneneigenschaft ist hauptsächlich für Benutzer in Unternehmensumgebungen von Interesse, die Active Directory verwenden.</returns>
        string Domain { get; set; }

        /// <summary>Ruft eine sichere Zeichenfolge ab, die das Benutzerkennwort enthält, das beim Starten des Prozesses verwendet werden soll, oder legt diese fest.</summary>
        /// <returns>Das beim Starten des Prozesses zu verwendende Kennwort.</returns>
        SecureString Password { get; set; }

        /// <summary>Ruft den beim Starten des Prozesses zu verwendenden Benutzernamen ab oder legt diesen fest.</summary>
        /// <returns>Der beim Starten des Prozesses zu verwendende Benutzername.</returns>
        string UserName { get; set; }

        /// <summary>Ruft den Satz der Verben ab, der dem durch die <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebenen Dateityp zugeordnet ist.</summary>
        /// <returns>Die Aktionen, die das System auf die durch die <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebene Datei anwenden kann.</returns>
        string[] Verbs { get; }

        /// <summary>Ruft einen Wert ab, der angibt, ob zum Starten des Prozesses die Betriebssystemshell verwendet werden soll, oder legt diesen fest.</summary>
        /// <returns>true, wenn beim Starten des Prozesses die Shell verwendet werden soll; false, wenn der Prozess direkt von der ausführbaren Datei aus erstellt werden soll. Die Standardeinstellung ist true.</returns>
        bool UseShellExecute { get; set; }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Fehlerausgabe einer Anwendung in den <see cref="P:System.Diagnostics.Process.StandardError" />-Stream geschrieben wird, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Fehlerausgabe in <see cref="P:System.Diagnostics.Process.StandardError" /> geschrieben werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        bool RedirectStandardError { get; set; }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Ausgabe einer Anwendung in den <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream geschrieben wird, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Ausgabe in <see cref="P:System.Diagnostics.Process.StandardOutput" /> geschrieben werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        bool RedirectStandardOutput { get; set; }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Eingabe für eine Anwendung aus dem <see cref="P:System.Diagnostics.Process.StandardInput" />-Stream gelesen wird, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Eingabe von <see cref="P:System.Diagnostics.Process.StandardInput" /> gelesen werden soll; andernfalls false. Die Standardeinstellung ist false.</returns>
        bool RedirectStandardInput { get; set; }

        /// <summary>Ruft Suchpfade für Dateien, Verzeichnisse für temporäre Dateien, anwendungsspezifische Optionen und andere ähnliche Informationen ab.</summary>
        /// <returns>Ein Zeichenfolgenwörterbuch, das Umgebungsvariablen für diesen Prozess und untergeordnete Prozesse bereitstellt. Der Standardwert ist null.</returns>
        StringDictionary EnvironmentVariables { get; }

        /// <summary>Ruft einen Wert ab, der angibt, ob der Prozess in einem neuen Fenster gestartet werden soll, oder legt diesen fest.</summary>
        /// <returns>true, wenn der Prozess ohne Erstellung eines neuen, für ihn bestimmten Fensters gestartet werden soll, andernfalls false. Die Standardeinstellung ist false.</returns>
        bool CreateNoWindow { get; set; }

        /// <summary>Ruft den Satz von Befehlszeilenargumenten ab, die beim Starten der Anwendung verwendet werden sollen, oder legt diesen fest.</summary>
        /// <returns>Dateitypspezifische Argumente, die das System der in der <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebenen Anwendung zuordnen kann. Der Standardwert ist eine leere Zeichenfolge (""). Unter Windows Vista und früheren Versionen des Windows-Betriebssystems muss die Länge der Argumente, die der Länge des vollständigen Pfads des Prozesses hinzugefügt werden, kleiner sein als 2080. Unter Windows 7 und höheren Versionen muss die Länge kleiner als 32699 sein.</returns>
        string Arguments { get; set; }

        /// <summary>Ruft das Verb ab, das beim Öffnen der in der <see cref="P:System.Diagnostics.ProcessStartInfo.FileName" />-Eigenschaft angegebenen Anwendung oder des in dieser Eigenschaft angegebenen Dokuments verwendet wird, oder legt dieses fest.</summary>
        /// <returns>Die Aktion, die mit der vom Prozess geöffneten Datei durchzuführen ist. Der Standardwert ist eine leere Zeichenfolge (""), die keine Aktion angibt.</returns>
        string Verb { get; set; }
    }
}