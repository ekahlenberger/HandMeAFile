using System;
using System.IO;
using System.Runtime.Remoting;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IFileInfo
    {
        /// <summary>
        /// Ruft das aktuelle Lebensdauerdienstobjekt ab, das die Lebensdauerrichtlinien f�r diese Instanz steuert.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien f�r diese Instanz verwendet wird.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verf�gt nicht �ber die Berechtigung f�r die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        object GetLifetimeService();
        /// <summary>
        /// Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien f�r diese Instanz gesteuert werden k�nnen.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien f�r diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt f�r diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime"/>-Eigenschaft initialisiert wurde.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verf�gt nicht �ber die Berechtigung f�r die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        object InitializeLifetimeService();
        /// <summary>
        /// Erstellt ein Objekt mit allen relevanten Informationen, die zum Generieren eines Proxys f�r die Kommunikation mit einem Remoteobjekt erforderlich sind.
        /// </summary>
        /// <returns>
        /// Zum Generieren eines Proxys erforderliche Informationen.
        /// </returns>
        /// <param name="requestedType">Der <see cref="T:System.Type"/> des Objekts, auf das der neue <see cref="T:System.Runtime.Remoting.ObjRef"/> verweist.</param><exception cref="T:System.Runtime.Remoting.RemotingException">Diese Instanz ist kein g�ltiges Remoteobjekt.</exception><exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verf�gt nicht �ber die Berechtigung f�r die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure"/></PermissionSet>
        ObjRef CreateObjRef(Type requestedType);
        /// <summary>
        /// Aktualisiert den Zustand des Objekts.
        /// </summary>
        /// <exception cref="T:System.IO.IOException">Ein Ger�t, z.�B. ein Laufwerk, ist nicht verf�gbar.</exception>
        void Refresh();
        /// <summary>
        /// Ruft den vollst�ndigen Pfad des Verzeichnisses oder der Datei ab.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge mit dem vollst�ndigen Pfad.
        /// </returns>
        /// <exception cref="T:System.IO.PathTooLongException">Der vollqualifizierte Pfad und der Dateiname sind mindestens 260 Zeichen lang.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        string FullName { get; }
        /// <summary>
        /// Ruft die Zeichenfolge ab, die den Erweiterungsteil der Datei darstellt.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge, die die <see cref="T:System.IO.FileSystemInfo"/>-Erweiterung enth�lt.
        /// </returns>
        string Extension { get; }
        /// <summary>
        /// Ruft den Erstellungszeitpunkt der aktuellen Datei oder des aktuellen Verzeichnisses ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Das Erstellungsdatum und die Erstellungszeit des aktuellen <see cref="T:System.IO.FileSystemInfo"/>-Objekts.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Zum Beispiel befindet er sich auf einem nicht zugeordneten Laufwerk.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows�NT oder h�her.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ung�ltige Erstellungszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime CreationTime { get; set; }
        /// <summary>
        /// Ruft die Erstellungszeit der aktuellen Datei oder des aktuellen Verzeichnisses im UTC-Format (Coordinated Universal Time) ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Das Erstellungsdatum und die Erstellungszeit (im UTC-Format) des aktuellen <see cref="T:System.IO.FileSystemInfo"/>-Objekts.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Zum Beispiel befindet er sich auf einem nicht zugeordneten Laufwerk.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows�NT oder h�her.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ung�ltige Zugriffszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime CreationTimeUtc { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Zugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Der Zeitpunkt des letzten Zugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows�NT oder h�her.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ung�ltige Zugriffszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastAccessTime { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Zugriffs auf die aktuelle Datei bzw. das aktuelle Verzeichnis im UTC-Format (Coordinated Universal Time) ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Die UTC-Zeit des letzten Zugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows�NT oder h�her.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ung�ltige Zugriffszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastAccessTimeUtc { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Schreibzugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Der Zeitpunkt des letzten Schreibzugriffs auf die Datei.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows�NT oder h�her.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ung�ltige Zeit f�r den Schreibvorgang festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastWriteTime { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Schreibens in die aktuelle Datei oder das aktuelle Verzeichnis im UTC-Format (Coordinated Universal Time) ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Die UTC-Zeit des letzten Schreibzugriffs auf die aktuelle Datei.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows�NT oder h�her.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ung�ltige Zeit f�r den Schreibvorgang festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastWriteTimeUtc { get; set; }
        /// <summary>
        /// Ruft die Attribute f�r die aktuelle Datei oder das aktuelle Verzeichnis ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.IO.FileAttributes"/> der aktuellen <see cref="T:System.IO.FileSystemInfo"/>.
        /// </returns>
        /// <exception cref="T:System.IO.FileNotFoundException">Die angegebene Datei ist nicht vorhanden.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Zum Beispiel befindet er sich auf einem nicht zugeordneten Laufwerk.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.ArgumentException">Der Aufrufer versucht, ein ung�ltiges Dateiattribut festzulegen.  -oder- Die Benutzer versucht, einen Attributwert festzulegen, verf�gt jedoch nicht �ber Schreibberechtigungen.</exception><exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        FileAttributes Attributes { get; set; }
        /// <summary>
        /// Ruft den Namen der Datei ab.
        /// </summary>
        /// <returns>
        /// Der Name der Datei.
        /// </returns>
        string Name { get; }
        /// <summary>
        /// Ruft die Gr��e der aktuellen Datei in Byte ab.
        /// </summary>
        /// <returns>
        /// Die Gr��e der aktuellen Datei in Bytes.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann den Zustand der Datei oder des Verzeichnisses nicht aktualisieren.</exception><exception cref="T:System.IO.FileNotFoundException">Die Datei ist nicht vorhanden. -oder-  Die Length-Eigenschaft wird f�r ein Verzeichnis aufgerufen.</exception>
        long Length { get; }
        /// <summary>
        /// Ruft eine Zeichenfolge ab, die den vollst�ndigen Pfad des Verzeichnisses darstellt.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge, die den vollst�ndigen Pfad des Verzeichnisses darstellt.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">Als Verzeichnisname wurde null �bergeben.</exception><exception cref="T:System.IO.PathTooLongException">Der vollqualifizierte Pfad ist 260 oder mehr Zeichen.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        string DirectoryName { get; }
        /// <summary>
        /// Ruft einen Wert ab, der bestimmt, ob die aktuelle Datei schreibgesch�tzt ist, oder legt diesen Wert fest.
        /// </summary>
        /// <returns>
        /// true, wenn die aktuelle Datei schreibgesch�tzt ist, andernfalls false.
        /// </returns>
        /// <exception cref="T:System.IO.FileNotFoundException">Die durch das aktuelle <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei konnte nicht gefunden werden.</exception><exception cref="T:System.IO.IOException">E/A-Fehler beim �ffnen der Datei.</exception><exception cref="T:System.UnauthorizedAccessException">Dieser Vorgang wird von der aktuellen Plattform nicht unterst�tzt. -oder-  Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.ArgumentException">Der Benutzer verf�gt nicht �ber die Schreibberechtigung, hat jedoch versucht, diese Eigenschaft auf false festzulegen.</exception>
        bool IsReadOnly { get; set; }
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob eine Datei vorhanden ist.
        /// </summary>
        /// <returns>
        /// true, wenn die Datei vorhanden ist; false, wenn die Datei nicht vorhanden ist oder es sich um ein Verzeichnis handelt.
        /// </returns>
        bool Exists { get; }
        /// <summary>
        /// Kopiert eine vorhandene Datei in eine neue Datei, ohne das �berschreiben einer vorhandenen Datei zuzulassen.
        /// </summary>
        /// <returns>
        /// Eine neue Datei mit einem vollqualifizierten Pfad.
        /// </returns>
        /// <param name="destFileName">Der Name der neuen Datei, in die kopiert werden soll.</param><exception cref="T:System.ArgumentException"><paramref name="destFileName"/> ist leer oder enth�lt nur Leerr�ume oder ung�ltige Zeichen.</exception><exception cref="T:System.IO.IOException">Es tritt ein Fehler auf, oder die Zieldatei ist bereits vorhanden.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.ArgumentNullException"><paramref name="destFileName"/> ist null.</exception><exception cref="T:System.UnauthorizedAccessException">Ein Verzeichnispfad wird �bergeben, oder die Datei wird auf ein anderes Laufwerk verschoben.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Das in <paramref name="destFileName"/> angegebene Verzeichnis ist nicht vorhanden.</exception><exception cref="T:System.IO.PathTooLongException">Der angegebene Pfad und/oder der Dateiname �berschreiten die vom System vorgegebene H�chstl�nge. Beispielsweise m�ssen Pfade auf Windows-Plattformen weniger als 248�Zeichen und Dateinamen weniger als 260�Zeichen aufweisen.</exception><exception cref="T:System.NotSupportedException">Die Zeichenfolge von <paramref name="destFileName"/> enth�lt einen Doppelpunkt (:), aber das Volume ist nicht angegeben.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileInfo CopyTo(string destFileName);
        /// <summary>
        /// Kopiert eine vorhandene Datei in eine neue Datei und l�sst das �berschreiben einer vorhandenen Datei zu.
        /// </summary>
        /// <returns>
        /// Eine neue Datei oder eine �berschreibung einer vorhandenen Datei, wenn <paramref name="overwrite"/>true ist. Wenn die Datei vorhanden und <paramref name="overwrite"/>false ist, wird eine <see cref="T:System.IO.IOException"/> ausgel�st.
        /// </returns>
        /// <param name="destFileName">Der Name der neuen Datei, in die kopiert werden soll.</param><param name="overwrite">true, um das �berschreiben einer vorhandenen Datei zuzulassen, andernfalls false.</param><exception cref="T:System.ArgumentException"><paramref name="destFileName"/> ist leer oder enth�lt nur Leerr�ume oder ung�ltige Zeichen.</exception><exception cref="T:System.IO.IOException">Es tritt ein Fehler auf, oder die Zieldatei ist bereits vorhanden, und <paramref name="overwrite"/> ist false.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.ArgumentNullException"><paramref name="destFileName"/> ist null.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Das in <paramref name="destFileName"/> angegebene Verzeichnis ist nicht vorhanden.</exception><exception cref="T:System.UnauthorizedAccessException">Ein Verzeichnispfad wird �bergeben, oder die Datei wird auf ein anderes Laufwerk verschoben.</exception><exception cref="T:System.IO.PathTooLongException">Der angegebene Pfad und/oder der Dateiname �berschreiten die vom System vorgegebene H�chstl�nge. Beispielsweise m�ssen Pfade auf Windows-Plattformen weniger als 248�Zeichen und Dateinamen weniger als 260�Zeichen aufweisen.</exception><exception cref="T:System.NotSupportedException"><paramref name="destFileName"/> enth�lt einen Doppelpunkt (:) innerhalb der Zeichenfolge.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileInfo CopyTo(string destFileName, bool overwrite);
        /// <summary>
        /// Erstellt eine Datei.
        /// </summary>
        /// <returns>
        /// Eine neue Datei.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileStream Create();
        /// <summary>
        /// L�scht eine Datei unwiderruflich.
        /// </summary>
        /// <exception cref="T:System.IO.IOException">Die Zieldatei ist ge�ffnet, oder es handelt sich um eine Datei mit Speicherzuordnung (Memory-Mapped File) auf einem Computer, auf dem Microsoft�Windows�NT ausgef�hrt ist. -oder- F�r die Datei ist ein ge�ffnetes Handle vorhanden, und das Betriebssystem ist Windows XP oder fr�her. Dieses ge�ffnete Handle kann aus der Auflistung von Verzeichnissen und Dateien entstanden sein. Weitere Informationen finden Sie unter Gewusst wie: Auflisten von Verzeichnissen und Dateien.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.UnauthorizedAccessException">Der Pfad ist ein Verzeichnis.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        void Delete();
        /// <summary>
        /// Entschl�sselt eine Datei, die vom aktuellen Konto mit der <see cref="M:System.IO.FileInfo.Encrypt"/>-Methode verschl�sselt wurde.
        /// </summary>
        /// <exception cref="T:System.IO.DriveNotFoundException">Es wurde ein ung�ltiges Laufwerk angegeben.</exception><exception cref="T:System.IO.FileNotFoundException">Die durch das aktuelle <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei konnte nicht gefunden werden.</exception><exception cref="T:System.IO.IOException">E/A-Fehler beim �ffnen der Datei.</exception><exception cref="T:System.NotSupportedException">Das Dateisystem ist nicht NTFS.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Microsoft Windows�NT oder h�her.</exception><exception cref="T:System.UnauthorizedAccessException">Die vom aktuellen <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei ist schreibgesch�tzt. -oder-  Dieser Vorgang wird von der aktuellen Plattform nicht unterst�tzt. -oder-  Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        void Decrypt();
        /// <summary>
        /// Verschl�sselt eine Datei, sodass sie nur mit dem Konto, mit dem die Datei verschl�sselt wurde, entschl�sselt werden kann.
        /// </summary>
        /// <exception cref="T:System.IO.DriveNotFoundException">Es wurde ein ung�ltiges Laufwerk angegeben.</exception><exception cref="T:System.IO.FileNotFoundException">Die durch das aktuelle <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei konnte nicht gefunden werden.</exception><exception cref="T:System.IO.IOException">E/A-Fehler beim �ffnen der Datei.</exception><exception cref="T:System.NotSupportedException">Das Dateisystem ist nicht NTFS.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Microsoft Windows�NT oder h�her.</exception><exception cref="T:System.UnauthorizedAccessException">Die vom aktuellen <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei ist schreibgesch�tzt. -oder-  Dieser Vorgang wird von der aktuellen Plattform nicht unterst�tzt. -oder-  Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        void Encrypt();
        /// <summary>
        /// �ffnet eine Datei im angegebenen Modus.
        /// </summary>
        /// <returns>
        /// Eine im angegebenen Modus ge�ffnete Datei mit Lese-/Schreibzugriff und ohne Freigabe.
        /// </returns>
        /// <param name="mode">Eine <see cref="T:System.IO.FileMode"/>-Konstante, die den Modus angibt, in dem die Datei ge�ffnet werden soll (z.�B. Open oder Append).</param><exception cref="T:System.IO.FileNotFoundException">Die Datei wurde nicht gefunden.</exception><exception cref="T:System.UnauthorizedAccessException">Die Datei ist schreibgesch�tzt oder ein Verzeichnis.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Dies ist z.�B. der Fall, wenn das Laufwerk des Pfads nicht zugeordnet ist.</exception><exception cref="T:System.IO.IOException">Die Datei ist bereits ge�ffnet.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileStream Open(FileMode mode);
        /// <summary>
        /// �ffnet eine Datei im angegebenen Modus mit Lese-, Schreib- oder Lese-/Schreibzugriff.
        /// </summary>
        /// <returns>
        /// Ein im angegebenen Modus und mit dem angegebenem Zugriff ge�ffnetes <see cref="T:System.IO.FileStream"/>-Objekt ohne Freigabe.
        /// </returns>
        /// <param name="mode">Eine <see cref="T:System.IO.FileMode"/>-Konstante, die den Modus angibt, in dem die Datei ge�ffnet werden soll (z.�B. Open oder Append).</param><param name="access">Eine <see cref="T:System.IO.FileAccess"/>-Konstante, die angibt, ob die Datei mit Read-Zugriff, Write-Zugriff oder ReadWrite-Zugriff ge�ffnet werden soll.</param><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.ArgumentException"><paramref name="path"/> ist leer oder enth�lt nur Leerr�ume.</exception><exception cref="T:System.IO.FileNotFoundException">Die Datei wurde nicht gefunden.</exception><exception cref="T:System.ArgumentNullException">Ein oder mehrere Argumente sind null.</exception><exception cref="T:System.UnauthorizedAccessException"><paramref name="path"/> ist schreibgesch�tzt oder ein Verzeichnis.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Dies ist z.�B. der Fall, wenn das Laufwerk des Pfads nicht zugeordnet ist.</exception><exception cref="T:System.IO.IOException">Die Datei ist bereits ge�ffnet.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileStream Open(FileMode mode, FileAccess access);
        /// <summary>
        /// �ffnet eine Datei im angegebenen Modus mit Lese-, Schreib- oder Lese-/Schreibzugriff und der angegebenen Freigabeoption.
        /// </summary>
        /// <returns>
        /// Ein mit dem angegebenen Modus, dem angegebenen Zugriff und den angegebenen Freigabeoptionen ge�ffnetes <see cref="T:System.IO.FileStream"/>-Objekt.
        /// </returns>
        /// <param name="mode">Eine <see cref="T:System.IO.FileMode"/>-Konstante, die den Modus angibt, in dem die Datei ge�ffnet werden soll (z.�B. Open oder Append).</param><param name="access">Eine <see cref="T:System.IO.FileAccess"/>-Konstante, die angibt, ob die Datei mit Read-Zugriff, Write-Zugriff oder ReadWrite-Zugriff ge�ffnet werden soll.</param><param name="share">Eine <see cref="T:System.IO.FileShare"/>-Konstante, die die Art des Zugriffs angibt, die andere FileStream-Objekte auf diese Datei haben.</param><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.ArgumentException"><paramref name="path"/> ist leer oder enth�lt nur Leerr�ume.</exception><exception cref="T:System.IO.FileNotFoundException">Die Datei wurde nicht gefunden.</exception><exception cref="T:System.ArgumentNullException">Ein oder mehrere Argumente sind null.</exception><exception cref="T:System.UnauthorizedAccessException"><paramref name="path"/> ist schreibgesch�tzt oder ein Verzeichnis.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Dies ist z.�B. der Fall, wenn das Laufwerk des Pfads nicht zugeordnet ist.</exception><exception cref="T:System.IO.IOException">Die Datei ist bereits ge�ffnet.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileStream Open(FileMode mode, FileAccess access, FileShare share);
        /// <summary>
        /// Erstellt einen schreibgesch�tzten <see cref="T:System.IO.FileStream"/>.
        /// </summary>
        /// <returns>
        /// Ein neues schreibgesch�tztes <see cref="T:System.IO.FileStream"/>-Objekt.
        /// </returns>
        /// <exception cref="T:System.UnauthorizedAccessException"><paramref name="path"/> ist schreibgesch�tzt oder ein Verzeichnis.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Dies ist z.�B. der Fall, wenn das Laufwerk des Pfads nicht zugeordnet ist.</exception><exception cref="T:System.IO.IOException">Die Datei ist bereits ge�ffnet.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileStream OpenRead();
        /// <summary>
        /// Erstellt einen <see cref="T:System.IO.FileStream"/>, der nur �ber Schreibzugriff verf�gt.
        /// </summary>
        /// <returns>
        /// Ein lesegesch�tztes nicht freigegebenes <see cref="T:System.IO.FileStream"/>-Objekt f�r eine neue oder existierende Datei.
        /// </returns>
        /// <exception cref="T:System.UnauthorizedAccessException">Der beim Erstellen einer Instanz des <see cref="T:System.IO.FileInfo"/>-Objekts angegebene Pfad ist schreibgesch�tzt oder ein Verzeichnis.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der Pfad beim Erstellen eines <see cref="T:System.IO.FileInfo"/>-Objekts angegebene Pfad ist ung�ltig. Dies ist z.�B. der Fall, wenn das Laufwerk des Pfades nicht zugeordnet ist.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileStream OpenWrite();
        /// <summary>
        /// Verschiebt eine angegebene Datei an einen neuen Speicherort und erm�glicht das Angeben eines neuen Dateinamens.
        /// </summary>
        /// <param name="destFileName">Der Pfad, in den die Datei verschoben werden soll. Dadurch kann ein anderer Dateiname angegeben werden.</param><exception cref="T:System.IO.IOException">Es ist ein E/A-Fehler aufgetreten, beispielsweise ist die Zieldatei bereits vorhanden, oder das Zielger�t ist nicht bereit.</exception><exception cref="T:System.ArgumentNullException"><paramref name="destFileName"/> ist null.</exception><exception cref="T:System.ArgumentException"><paramref name="destFileName"/> ist leer oder enth�lt nur Leerr�ume oder ung�ltige Zeichen.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verf�gt nicht �ber die erforderliche Berechtigung.</exception><exception cref="T:System.UnauthorizedAccessException"><paramref name="destFileName"/> ist schreibgesch�tzt oder ein Verzeichnis.</exception><exception cref="T:System.IO.FileNotFoundException">Die Datei wurde nicht gefunden.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ung�ltig. Dies ist z.�B. der Fall, wenn das Laufwerk des Pfads nicht zugeordnet ist.</exception><exception cref="T:System.IO.PathTooLongException">Der angegebene Pfad und/oder der Dateiname �berschreiten die vom System vorgegebene H�chstl�nge. Beispielsweise m�ssen Pfade auf Windows-Plattformen weniger als 248�Zeichen und Dateinamen weniger als 260�Zeichen aufweisen.</exception><exception cref="T:System.NotSupportedException"><paramref name="destFileName"/> enth�lt einen Doppelpunkt (:) innerhalb der Zeichenfolge.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        void MoveTo(string destFileName);
        /// <summary>
        /// Ersetzt den Inhalt einer angegebenen Datei durch die vom aktuellen <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei, l�scht die urspr�ngliche Datei und erstellt eine Sicherungskopie der ersetzten Datei.
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.IO.FileInfo"/>-Objekt, das Informationen zu der mit dem <paramref name="destFileName"/>-Parameter beschriebenen Datei kapselt.
        /// </returns>
        /// <param name="destinationFileName">Der Name einer Datei, die durch die aktuelle Datei ersetzt werden soll.</param><param name="destinationBackupFileName">Der Name einer Datei, mit der eine Sicherungskopie der mit dem <paramref name="destFileName"/>-Parameter beschriebenen Datei erstellt werden soll.</param><exception cref="T:System.ArgumentException">Das Format des mit dem <paramref name="destFileName"/>-Parameter beschriebenen Pfads war ung�ltig. -oder- Das Format des mit dem <paramref name="destBackupFileName"/>-Parameter beschriebenen Pfads war ung�ltig.</exception><exception cref="T:System.ArgumentNullException">Der <paramref name="destFileName"/>-Parameter ist null.</exception><exception cref="T:System.IO.FileNotFoundException">Die durch das aktuelle <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei konnte nicht gefunden werden. -oder- Die vom <paramref name="destinationFileName"/>-Parameter beschriebene Datei konnte nicht gefunden werden.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Microsoft Windows�NT oder h�her.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName);
        /// <summary>
        /// Ersetzt den Inhalt einer angegebenen Datei durch die vom aktuellen <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei, l�scht die urspr�ngliche Datei und erstellt eine Sicherungskopie der ersetzten Datei.  Gibt auch an, ob Zusammenf�hrungsfehler ignoriert werden sollen.
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.IO.FileInfo"/>-Objekt, das Informationen zu der mit dem <paramref name="destFileName"/>-Parameter beschriebenen Datei kapselt.
        /// </returns>
        /// <param name="destinationFileName">Der Name einer Datei, die durch die aktuelle Datei ersetzt werden soll.</param><param name="destinationBackupFileName">Der Name einer Datei, mit der eine Sicherungskopie der mit dem <paramref name="destFileName"/>-Parameter beschriebenen Datei erstellt werden soll.</param><param name="ignoreMetadataErrors">true, um Fehler beim Zusammenf�hren der ersetzten Datei und der Ersetzungsdatei zu ignorieren (z.�B. Zugriffssteuerungslisten), andernfalls false.</param><exception cref="T:System.ArgumentException">Das Format des mit dem <paramref name="destFileName"/>-Parameter beschriebenen Pfads war ung�ltig. -oder- Das Format des mit dem <paramref name="destBackupFileName"/>-Parameter beschriebenen Pfads war ung�ltig.</exception><exception cref="T:System.ArgumentNullException">Der <paramref name="destFileName"/>-Parameter ist null.</exception><exception cref="T:System.IO.FileNotFoundException">Die durch das aktuelle <see cref="T:System.IO.FileInfo"/>-Objekt beschriebene Datei konnte nicht gefunden werden. -oder- Die vom <paramref name="destinationFileName"/>-Parameter beschriebene Datei konnte nicht gefunden werden.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Microsoft Windows�NT oder h�her.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);
    }
}