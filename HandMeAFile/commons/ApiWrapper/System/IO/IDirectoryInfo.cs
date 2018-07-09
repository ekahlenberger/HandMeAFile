using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IDirectoryInfo
    {
        /// <summary>
        /// Erstellt ein Verzeichnis.
        /// </summary>
        /// <exception cref="T:System.IO.IOException">Das Verzeichnis kann nicht erstellt werden.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        void Create();
        /// <summary>
        /// Ruft den Stammteil des Verzeichnisses ab.
        /// </summary>
        /// <returns>
        /// Ein Objekt, das den Stamm des Verzeichnisses darstellt.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der Aufrufer verfügt nicht über die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IDirectoryInfo Root { get; }
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob das Verzeichnis vorhanden ist.
        /// </summary>
        /// <returns>
        /// true, wenn das Verzeichnis vorhanden ist, andernfalls false.
        /// </returns>
        bool Exists { get; }
        /// <summary>
        /// Ruft das übergeordnete Verzeichnis eines angegebenen Unterverzeichnisses ab.
        /// </summary>
        /// <returns>
        /// Das übergeordnete Verzeichnis oder null, wenn der Pfad null ist oder der Dateipfad ein Stammverzeichnis angibt (z. B. "\", "C:" oder * "\\server\share").
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der Aufrufer verfügt nicht über die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        IDirectoryInfo Parent { get; }
        /// <summary>
        /// Ruft den Namen dieser <see cref="T:System.IO.DirectoryInfo"/>-Instanz ab.
        /// </summary>
        /// <returns>
        /// Der Name des Verzeichnisses.
        /// </returns>
        string Name { get; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Schreibens in die aktuelle Datei oder das aktuelle Verzeichnis im UTC-Format (Coordinated Universal Time) ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Die UTC-Zeit des letzten Schreibzugriffs auf die aktuelle Datei.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows NT oder höher.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ungültige Zeit für den Schreibvorgang festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastWriteTimeUtc { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Schreibzugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Der Zeitpunkt des letzten Schreibzugriffs auf die Datei.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows NT oder höher.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ungültige Zeit für den Schreibvorgang festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastWriteTime { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Zugriffs auf die aktuelle Datei bzw. das aktuelle Verzeichnis im UTC-Format (Coordinated Universal Time) ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Die UTC-Zeit des letzten Zugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows NT oder höher.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ungültige Zugriffszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastAccessTimeUtc { get; set; }
        /// <summary>
        /// Ruft den Zeitpunkt des letzten Zugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Der Zeitpunkt des letzten Zugriffs auf die aktuelle Datei oder das aktuelle Verzeichnis.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows NT oder höher.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ungültige Zugriffszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime LastAccessTime { get; set; }
        /// <summary>
        /// Ruft die Erstellungszeit der aktuellen Datei oder des aktuellen Verzeichnisses im UTC-Format (Coordinated Universal Time) ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Das Erstellungsdatum und die Erstellungszeit (im UTC-Format) des aktuellen <see cref="T:System.IO.FileSystemInfo"/>-Objekts.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ungültig. Zum Beispiel befindet er sich auf einem nicht zugeordneten Laufwerk.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows NT oder höher.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ungültige Zugriffszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime CreationTimeUtc { get; set; }
        /// <summary>
        /// Ruft den Erstellungszeitpunkt der aktuellen Datei oder des aktuellen Verzeichnisses ab oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Das Erstellungsdatum und die Erstellungszeit des aktuellen <see cref="T:System.IO.FileSystemInfo"/>-Objekts.
        /// </returns>
        /// <exception cref="T:System.IO.IOException"><see cref="M:System.IO.FileSystemInfo.Refresh"/> kann die Daten nicht initialisieren.</exception><exception cref="T:System.IO.DirectoryNotFoundException">Der angegebene Pfad ist ungültig. Zum Beispiel befindet er sich auf einem nicht zugeordneten Laufwerk.</exception><exception cref="T:System.PlatformNotSupportedException">Das aktuelle Betriebssystem ist nicht Windows NT oder höher.</exception><exception cref="T:System.ArgumentOutOfRangeException">Der Aufrufer versucht, eine ungültige Erstellungszeit festzulegen.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        DateTime CreationTime { get; set; }
        /// <summary>
        /// Ruft die Zeichenfolge ab, die den Erweiterungsteil der Datei darstellt.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge, die die <see cref="T:System.IO.FileSystemInfo"/>-Erweiterung enthält.
        /// </returns>
        string Extension { get; }
        /// <summary>
        /// Ruft den vollständigen Pfad des Verzeichnisses oder der Datei ab.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge mit dem vollständigen Pfad.
        /// </returns>
        /// <exception cref="T:System.IO.PathTooLongException">Der vollqualifizierte Pfad und der Dateiname sind mindestens 260 Zeichen lang.</exception><exception cref="T:System.Security.SecurityException">Der Aufrufer verfügt nicht über die erforderliche Berechtigung.</exception><PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        string FullName { get; }
    }
}