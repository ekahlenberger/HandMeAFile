using System;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using Microsoft.Win32;

namespace org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32
{
    public class RegistryKeyWrapper : IRegistryKey
    {
        /// <summary>Ruft das aktuelle Lebensdauerdienstobjekt ab, das die Lebensdauerrichtlinien für diese Instanz steuert.</summary>
        /// <returns>Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" />
        /// </PermissionSet>
        public object GetLifetimeService()
        {
            return m_key.GetLifetimeService();
        }

        /// <summary>Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien für diese Instanz gesteuert werden können.</summary>
        /// <returns>Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt für diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" />-Eigenschaft initialisiert wurde.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" />
        /// </PermissionSet>
        public object InitializeLifetimeService()
        {
            return m_key.InitializeLifetimeService();
        }

        /// <summary>Erstellt ein Objekt mit allen relevanten Informationen, die zum Generieren eines Proxys für die Kommunikation mit einem Remoteobjekt erforderlich sind.</summary>
        /// <returns>Zum Generieren eines Proxys erforderliche Informationen.</returns>
        /// <param name="requestedType">Der <see cref="T:System.Type" /> des Objekts, auf das der neue <see cref="T:System.Runtime.Remoting.ObjRef" /> verweist.</param>
        /// <exception cref="T:System.Runtime.Remoting.RemotingException">Diese Instanz ist kein gültiges Remoteobjekt.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
        /// </PermissionSet>
        public ObjRef CreateObjRef(Type requestedType)
        {
            return m_key.CreateObjRef(requestedType);
        }

        /// <summary>Schließt den Schlüssel und schreibt diesen auf den Datenträger weg, sofern der Inhalt verändert wurde.</summary>
        public void Close()
        {
            m_key.Close();
        }

        /// <summary>Schreibt alle Attribute des angegebenen geöffneten Registrierungsschlüssels in die Registrierung.</summary>
        public void Flush()
        {
            m_key.Flush();
        }

        /// <summary>Gibt alle von der aktuellen Instanz der <see cref="T:Microsoft.Win32.RegistryKey" />-Klasse verwendeten Ressourcen frei.</summary>
        public void Dispose()
        {
            m_key.Dispose();
        }

        /// <summary>Erstellt einen neuen Unterschlüssel oder öffnet einen vorhandenen Unterschlüssel für Schreibzugriff.</summary>
        /// <returns>Der neu erstellte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist. Wenn eine Zeichenfolge der Länge 0 (null) für <paramref name="subkey" /> angegeben wird, wird das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt zurückgegeben.</returns>
        /// <param name="subkey">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> ist null.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Öffnen des Registrierungsschlüssels.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, für den die Methode aufgerufen wird, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der aktuelle <see cref="T:Microsoft.Win32.RegistryKey" /> kann nicht bearbeitet werden. Möglicherweise wurde der Schlüssel schreibgeschützt geöffnet, oder der Benutzer verfügt nicht über die erforderlichen Zugriffsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Die Schachtelungsebene übersteigt 510. -oder- Ein Systemfehler ist aufgetreten. Möglicherweise wurde der Schlüssel gelöscht, oder es wurde versucht, einen Schlüssel im <see cref="F:Microsoft.Win32.Registry.LocalMachine" />-Stamm zu erstellen.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public IRegistryKey CreateSubKey(string subkey)
        {
            return new RegistryKeyWrapper(m_key.CreateSubKey(subkey));
        }

        /// <summary>Erstellt einen neuen Unterschlüssel oder öffnet einen vorhandenen Unterschlüssel für Schreibzugriff unter Verwendung der angegebenen Berechtigungsprüfungsoption.</summary>
        /// <returns>Der neu erstellte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist. Wenn eine Zeichenfolge der Länge 0 (null) für <paramref name="subkey" /> angegeben wird, wird das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt zurückgegeben.</returns>
        /// <param name="subkey">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <param name="permissionCheck">Einer der Enumerationswerte, der angibt, ob der Schlüssel für Lesezugriff oder für Lese-/Schreibzugriff geöffnet wird.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> ist null.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Öffnen des Registrierungsschlüssels.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="permissionCheck" /> enthält einen ungültigen Wert.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, für den die Methode aufgerufen wird, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der aktuelle <see cref="T:Microsoft.Win32.RegistryKey" /> kann nicht bearbeitet werden. Möglicherweise wurde der Schlüssel schreibgeschützt geöffnet, oder der Benutzer verfügt nicht über die erforderlichen Zugriffsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Die Schachtelungsebene übersteigt 510. -oder- Ein Systemfehler ist aufgetreten. Möglicherweise wurde der Schlüssel gelöscht, oder es wurde versucht, einen Schlüssel im <see cref="F:Microsoft.Win32.Registry.LocalMachine" />-Stamm zu erstellen.</exception>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck)
        {
            return new RegistryKeyWrapper(m_key.CreateSubKey(subkey, permissionCheck));
        }

        /// <summary>Erstellt oder öffnet einen Unterschlüssel für Schreibzugriff unter Verwendung der angegebenen Berechtigungsprüfungs- und Registrierungsoptionen.</summary>
        /// <returns>Der neu erstellte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist.</returns>
        /// <param name="subkey">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels.</param>
        /// <param name="permissionCheck">Einer der Enumerationswerte, der angibt, ob der Schlüssel für Lesezugriff oder für Lese-/Schreibzugriff geöffnet wird.</param>
        /// <param name="options">Die zu verwendende Registrierungsoption, z. B. zum Erstellen eines temporären Schlüssels.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey " />ist null.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt, auf das zugegriffen werden soll, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt kann nicht bearbeitet werden. Möglicherweise wurde der Schlüssel schreibgeschützt geöffnet, oder der Benutzer verfügt nicht über die erforderlichen Zugriffsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Die Schachtelungsebene übersteigt 510. -oder- Ein Systemfehler ist aufgetreten. Möglicherweise wurde der Schlüssel gelöscht, oder es wurde versucht, einen Schlüssel im <see cref="F:Microsoft.Win32.Registry.LocalMachine" />-Stamm zu erstellen.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Öffnen des Registrierungsschlüssels.</exception>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions options)
        {
            return new RegistryKeyWrapper(m_key.CreateSubKey(subkey, permissionCheck, options));
        }

        /// <summary>Erstellt einen neuen Unterschlüssel oder öffnet einen vorhandenen Unterschlüssel für Schreibzugriff unter Verwendung der angegebenen Berechtigungsprüfungsoption und der Registrierungssicherheit.</summary>
        /// <returns>Der neu erstellte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist. Wenn eine Zeichenfolge der Länge 0 (null) für <paramref name="subkey" /> angegeben wird, wird das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt zurückgegeben.</returns>
        /// <param name="subkey">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <param name="permissionCheck">Einer der Enumerationswerte, der angibt, ob der Schlüssel für Lesezugriff oder für Lese-/Schreibzugriff geöffnet wird.</param>
        /// <param name="registrySecurity">Die Zugriffssteuerungssicherheit für den neuen Schlüssel.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> ist null.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Öffnen des Registrierungsschlüssels.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="permissionCheck" /> enthält einen ungültigen Wert.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, für den die Methode aufgerufen wird, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der aktuelle <see cref="T:Microsoft.Win32.RegistryKey" /> kann nicht bearbeitet werden. Möglicherweise wurde der Schlüssel schreibgeschützt geöffnet, oder der Benutzer verfügt nicht über die erforderlichen Zugriffsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Die Schachtelungsebene übersteigt 510. -oder- Ein Systemfehler ist aufgetreten. Möglicherweise wurde der Schlüssel gelöscht, oder es wurde versucht, einen Schlüssel im <see cref="F:Microsoft.Win32.Registry.LocalMachine" />-Stamm zu erstellen.</exception>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistrySecurity registrySecurity)
        {
            return new RegistryKeyWrapper(m_key.CreateSubKey(subkey, permissionCheck, registrySecurity));
        }

        /// <summary>Erstellt oder öffnet einen Unterschlüssel für Schreibzugriff unter Verwendung der angegebenen Berechtigungsprüfungsoption, Registrierungsoption und Registrierungssicherheit.</summary>
        /// <returns>Der neu erstellte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist.</returns>
        /// <param name="subkey">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels.</param>
        /// <param name="permissionCheck">Einer der Enumerationswerte, der angibt, ob der Schlüssel für Lesezugriff oder für Lese-/Schreibzugriff geöffnet wird.</param>
        /// <param name="registryOptions">Die zu verwendende Registrierungsoption.</param>
        /// <param name="registrySecurity">Die Zugriffssteuerungssicherheit für den neuen Unterschlüssel.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey " />ist null.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt ist geschlossen. Auf geschlossene Schlüssel kann nicht zugegriffen werden.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Das aktuelle <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt kann nicht bearbeitet werden. Möglicherweise wurde der Schlüssel schreibgeschützt geöffnet, oder der Benutzer verfügt nicht über die erforderlichen Zugriffsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Die Schachtelungsebene übersteigt 510. -oder- Ein Systemfehler ist aufgetreten. Möglicherweise wurde der Schlüssel gelöscht, oder es wurde versucht, einen Schlüssel im <see cref="F:Microsoft.Win32.Registry.LocalMachine" />-Stamm zu erstellen.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Öffnen des Registrierungsschlüssels.</exception>
        public IRegistryKey CreateSubKey(string subkey, RegistryKeyPermissionCheck permissionCheck, RegistryOptions registryOptions, IRegistrySecurity registrySecurity)
        {
            return new RegistryKeyWrapper(m_key.CreateSubKey(subkey, permissionCheck, registryOptions, ((IProvideOrgRegistrySecurity) registrySecurity).OrgSecurity));
        }

        /// <summary>Löscht den angegebenen Unterschlüssel.</summary>
        /// <param name="subkey">Der Name des zu löschenden Unterschlüssels. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <exception cref="T:System.InvalidOperationException">Der <paramref name="subkey" /> besitzt untergeordnete Unterschlüssel.</exception>
        /// <exception cref="T:System.ArgumentException">Der <paramref name="subkey" />-Parameter gibt keinen gültigen Registrierungsschlüssel an.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> entspricht null</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Schlüssel zu löschen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void DeleteSubKey(string subkey)
        {
            m_key.DeleteSubKey(subkey);
        }

        /// <summary>Löscht den angegebenen Unterschlüssel und gibt an, ob eine Ausnahme ausgelöst wird, wenn der Unterschlüssel nicht gefunden wird.</summary>
        /// <param name="subkey">Der Name des zu löschenden Unterschlüssels. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <param name="throwOnMissingSubKey">Gibt an, ob eine Ausnahme ausgelöst werden soll, wenn der angegebene Unterschlüssel nicht gefunden werden kann. Wenn dieses Argument true und der angegebene Unterschlüssel nicht vorhanden ist, wird eine Ausnahme ausgelöst. Wenn dieses Argument false und der angegebene Unterschlüssel nicht vorhanden ist, findet keine Aktion statt.</param>
        /// <exception cref="T:System.InvalidOperationException">
        /// <paramref name="subkey" /> hat untergeordnete Unterschlüssel.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="subkey" /> gibt keinen gültigen Registrierungsschlüssel an, und <paramref name="throwOnMissingSubKey" /> ist true.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> ist null.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Schlüssel zu löschen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void DeleteSubKey(string subkey, bool throwOnMissingSubKey)
        {
            m_key.DeleteSubKey(subkey, throwOnMissingSubKey);
        }

        /// <summary>Löscht einen Unterschlüssel und alle untergeordneten Unterschlüssel rekursiv.</summary>
        /// <param name="subkey">Der zu löschende Unterschlüssel. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> ist null.</exception>
        /// <exception cref="T:System.ArgumentException">Es wird versucht, eine Stammstruktur zu löschen. -oder- <paramref name="subkey" /> gibt keinen gültigen Registrierungsunterschlüssel an.</exception>
        /// <exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Schlüssel zu löschen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void DeleteSubKeyTree(string subkey)
        {
            m_key.DeleteSubKeyTree(subkey);
        }

        /// <summary>Löscht den angegebenen Unterschlüssel und untergeordnete Unterschlüssel rekursiv und gibt an, ob eine Ausnahme ausgelöst wird, wenn der Unterschlüssel nicht gefunden wird.</summary>
        /// <param name="subkey">Der Name des zu löschenden Unterschlüssels. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <param name="throwOnMissingSubKey">Gibt an, ob eine Ausnahme ausgelöst werden soll, wenn der angegebene Unterschlüssel nicht gefunden werden kann. Wenn dieses Argument true und der angegebene Unterschlüssel nicht vorhanden ist, wird eine Ausnahme ausgelöst. Wenn dieses Argument false und der angegebene Unterschlüssel nicht vorhanden ist, findet keine Aktion statt.</param>
        /// <exception cref="T:System.ArgumentException">Es wurde versucht, den Stammhive der Struktur zu löschen. -oder- <paramref name="subkey" /> gibt keinen gültigen Registrierungsunterschlüssel an, und <paramref name="throwOnMissingSubKey" /> ist true.</exception>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="subkey" /> ist null.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Schlüssel zu löschen.</exception>
        public void DeleteSubKeyTree(string subkey, bool throwOnMissingSubKey)
        {
            m_key.DeleteSubKeyTree(subkey, throwOnMissingSubKey);
        }

        /// <summary>Löscht den angegebenen Wert aus diesem Schlüssel.</summary>
        /// <param name="name">Der Name des zu löschenden Werts.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="name" /> ist kein gültiger Verweis auf einen Wert.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Wert zu löschen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist schreibgeschützt.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void DeleteValue(string name)
        {
            m_key.DeleteValue(name);
        }

        /// <summary>Löscht den angegebenen Wert aus diesem Schlüssel und gibt an, ob eine Ausnahme ausgelöst wird, wenn der Wert nicht gefunden wird.</summary>
        /// <param name="name">Der Name des zu löschenden Werts.</param>
        /// <param name="throwOnMissingValue">Gibt an, ob eine Ausnahme ausgelöst werden soll, wenn der angegebene Wert nicht gefunden werden kann. Wenn dieses Argument true und der angegebene Wert nicht vorhanden ist, wird eine Ausnahme ausgelöst. Wenn dieses Argument false und der angegebene Wert nicht vorhanden ist, findet keine Aktion statt.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="name" /> ist kein gültiger Verweis auf einen Wert, und <paramref name="throwOnMissingValue" /> ist true.  -oder-  <paramref name="name" /> ist null.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Wert zu löschen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist schreibgeschützt.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void DeleteValue(string name, bool throwOnMissingValue)
        {
            m_key.DeleteValue(name, throwOnMissingValue);
        }

        /// <summary>Ruft einen angegebenen Unterschlüssel ab und gibt an, ob Schreibzugriff auf den Schlüssel angewendet werden soll.</summary>
        /// <returns>Der angeforderte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist.</returns>
        /// <param name="name">Name oder Pfad des zu öffnenden Unterschlüssels.</param>
        /// <param name="writable">Muss für Schreibzugriff auf den Schlüssel auf true festgelegt werden.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="name" /> ist null.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um auf den Registrierungsschlüssel im angegebenen Modus zuzugreifen.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public IRegistryKey OpenSubKey(string name, bool writable)
        {
            return new RegistryKeyWrapper(m_key.OpenSubKey(name, writable));
        }

        /// <summary>Ruft den angegebenen Unterschlüssel für Lesezugriff oder Lese-/Schreibzugriff ab.</summary>
        /// <returns>Der angeforderte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist.</returns>
        /// <param name="name">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels.</param>
        /// <param name="permissionCheck">Einer der Enumerationswerte, der angibt, ob der Schlüssel für Lesezugriff oder für Lese-/Schreibzugriff geöffnet wird.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="name" /> entspricht null</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="permissionCheck" /> enthält einen ungültigen Wert.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Registrierungsschlüssel zu lesen.</exception>
        public IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck)
        {
            return new RegistryKeyWrapper(m_key.OpenSubKey(name, permissionCheck));
        }

        /// <summary>Ruft den angegebenen Unterschlüssel für Lesezugriff oder Lese-/Schreibzugriff ab, und fordert die angegebenen Zugriffsrechte an.</summary>
        /// <returns>Der angeforderte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist.</returns>
        /// <param name="name">Name oder Pfad des zu erstellenden oder zu öffnenden Unterschlüssels.</param>
        /// <param name="permissionCheck">Einer der Enumerationswerte, der angibt, ob der Schlüssel für Lesezugriff oder für Lese-/Schreibzugriff geöffnet wird.</param>
        /// <param name="rights">Eine bitweise Kombination von Enumerationswerten, die den gewünschten Sicherheitszugriff angeben.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="name" /> entspricht null</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="permissionCheck" /> enthält einen ungültigen Wert.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.Security.SecurityException">
        /// <paramref name="rights" /> enthält ungültige Werte für Registrierungsrechte. -oder- Der Benutzer verfügt nicht über die angeforderten Berechtigungen.</exception>
        public IRegistryKey OpenSubKey(string name, RegistryKeyPermissionCheck permissionCheck, RegistryRights rights)
        {
            return new RegistryKeyWrapper(m_key.OpenSubKey(name, permissionCheck, rights));
        }

        /// <summary>Ruft einen Unterschlüssel als schreibgeschützt ab.</summary>
        /// <returns>Der angeforderte Unterschlüssel oder null, wenn bei dem Vorgang ein Fehler aufgetreten ist.</returns>
        /// <param name="name">Der Name oder der Pfad des Unterschlüssels, der schreibgeschützt geöffnet werden soll.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="name" /> entspricht null</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um den Registrierungsschlüssel zu lesen.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
        /// </PermissionSet>
        public IRegistryKey OpenSubKey(string name)
        {
            return new RegistryKeyWrapper(m_key.OpenSubKey(name));
        }

        /// <summary>Ruft ein Array von Zeichenfolgen mit den Namen aller Unterschlüssel ab.</summary>
        /// <returns>Ein Array von Zeichenfolgen, das die Namen der Unterschlüssel des aktuellen Schlüssels enthält.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um aus dem Schlüssel zu lesen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Ein Systemfehler ist aufgetreten, möglicherweise wurde der aktuelle Schlüssel gelöscht.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public string[] GetSubKeyNames()
        {
            return m_key.GetSubKeyNames();
        }

        /// <summary>Ruft ein Array von Zeichenfolgen ab, das die Namen aller diesem Schlüssel zugeordneten Werte enthält.</summary>
        /// <returns>Ein Array von Zeichenfolgen, das die Namen der Werte für den aktuellen Schlüssel enthält.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um aus dem Registrierungsschlüssel zu lesen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Ein Systemfehler ist aufgetreten, möglicherweise wurde der aktuelle Schlüssel gelöscht.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public string[] GetValueNames()
        {
            return m_key.GetValueNames();
        }

        /// <summary>Ruft den Wert ab, der dem angegebenen Namen zugeordnet ist. Gibt null zurück, wenn das Name-Wert-Paar in der Registrierung nicht vorhanden ist.</summary>
        /// <returns>Der <paramref name="name" /> zugeordnete Wert oder null, wenn <paramref name="name" /> nicht gefunden wurde.</returns>
        /// <param name="name">Der Name des abzurufenden Werts. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um aus dem Registrierungsschlüssel zu lesen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.IO.IOException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, wurde zum Löschen markiert.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
        /// </PermissionSet>
        public object GetValue(string name)
        {
            return m_key.GetValue(name);
        }

        /// <summary>Ruft den Wert ab, der dem angegebenen Namen zugeordnet ist. Wenn der Name nicht gefunden wird, wird der von Ihnen bereitgestellte Standardwert zurückgegeben.</summary>
        /// <returns>Der <paramref name="name" /> zugeordnete Wert mit allen eingebetteten Umgebungsvariablen, die nicht erweitert wurden, oder <paramref name="defaultValue" />, wenn <paramref name="name" /> nicht gefunden wurde.</returns>
        /// <param name="name">Der Name des abzurufenden Werts. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <param name="defaultValue">Der zurückzugebende Wert, wenn <paramref name="name" /> nicht vorhanden ist.</param>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um aus dem Registrierungsschlüssel zu lesen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.IO.IOException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, wurde zum Löschen markiert.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
        /// </PermissionSet>
        public object GetValue(string name, object defaultValue)
        {
            return m_key.GetValue(name, defaultValue);
        }

        /// <summary>Ruft den Wert ab, der dem angegebenen Namen und den Abrufoptionen zugeordnet ist. Wenn der Name nicht gefunden wird, wird der von Ihnen bereitgestellte Standardwert zurückgegeben.</summary>
        /// <returns>Der <paramref name="name" /> zugeordnete Wert, der entsprechend den <paramref name="options" /> verarbeitet wurde, oder <paramref name="defaultValue" />, wenn <paramref name="name" /> nicht gefunden wird.</returns>
        /// <param name="name">Der Name des abzurufenden Werts. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <param name="defaultValue">Der zurückzugebende Wert, wenn <paramref name="name" /> nicht vorhanden ist.</param>
        /// <param name="options">Einer der Enumerationswerte, die eine optionale Verarbeitung des abgerufenen Werts angeben.</param>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um aus dem Registrierungsschlüssel zu lesen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.IO.IOException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, wurde zum Löschen markiert.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="options" /> ist kein gültiger <see cref="T:Microsoft.Win32.RegistryValueOptions" />-Wert; ein ungültiger Wert wird z. B. in <see cref="T:Microsoft.Win32.RegistryValueOptions" /> umgewandelt.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
        /// </PermissionSet>
        public object GetValue(string name, object defaultValue, RegistryValueOptions options)
        {
            return m_key.GetValue(name, defaultValue, options);
        }

        /// <summary>Ruft den Registrierungsdatentyp des Werts ab, der dem angegebenen Namen zugeordnet ist.</summary>
        /// <returns>Der Registrierungsdatentyp des <paramref name="name" /> zugeordneten Werts.</returns>
        /// <param name="name">Der Name des Werts, dessen Registrierungsdatentyp abgerufen werden soll. Bei dieser Zeichenfolge wird die Groß-/Kleinschreibung nicht berücksichtigt.</param>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen, um aus dem Registrierungsschlüssel zu lesen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.IO.IOException">Der Unterschlüssel, der den angegebenen Wert enthält, ist nicht vorhanden. -oder- Das von <paramref name="name" /> angegebene Name-Wert-Paar ist nicht vorhanden. Diese Ausnahme wird unter Windows 95, Windows 98 oder Windows Millennium Edition nicht ausgelöst.</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="\" />
        /// </PermissionSet>
        public RegistryValueKind GetValueKind(string name)
        {
            return m_key.GetValueKind(name);
        }

        /// <summary>Legt das angegebene Name-Wert-Paar fest.</summary>
        /// <param name="name">Der Name des zu speichernden Werts.</param>
        /// <param name="value">Die zu speichernden Daten.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="value" /> ist null.</exception>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="value" /> ist ein nicht unterstützter Datentyp.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist schreibgeschützt, sodass das Schreiben in den Schlüssel nicht möglich ist. Möglicherweise wurde der Schlüssel ohne Schreibzugriff geöffnet.  -oder- Das <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt stellt einen Knoten auf Stammebene dar, und das Betriebssystem ist Windows Millennium Edition oder Windows 98.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Ändern von Registrierungsschlüsseln.</exception>
        /// <exception cref="T:System.IO.IOException">Das <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt stellt einen Knoten auf der Stammebene dar, und das Betriebssystem ist Windows 2000, Windows XP oder Windows Server 2003.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void SetValue(string name, object value)
        {
            m_key.SetValue(name, value);
        }

        /// <summary>Legt mithilfe des angegebenen Registrierungsdatentyps den Wert eines Name-Wert-Paars im Registrierungsschlüssel fest.</summary>
        /// <param name="name">Der Name des zu speichernden Werts.</param>
        /// <param name="value">Die zu speichernden Daten.</param>
        /// <param name="valueKind">Der beim Speichern der Daten zu verwendende Registrierungsdatentyp.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="value" /> ist null.</exception>
        /// <exception cref="T:System.ArgumentException">Der Typ von <paramref name="value" /> stimmt nicht mit dem durch <paramref name="valueKind" /> angegebenen Registrierungsdatentyp überein. Die Daten konnten daher nicht ordnungsgemäß konvertiert werden.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" />, der den angegebenen Wert enthält, ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist schreibgeschützt, sodass das Schreiben in den Schlüssel nicht möglich ist. Möglicherweise wurde der Schlüssel ohne Schreibzugriff geöffnet. -oder- Das <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt stellt einen Knoten auf Stammebene dar, und das Betriebssystem ist Windows Millennium Edition oder Windows 98.</exception>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die erforderlichen Berechtigungen zum Erstellen oder Ändern von Registrierungsschlüsseln.</exception>
        /// <exception cref="T:System.IO.IOException">Das <see cref="T:Microsoft.Win32.RegistryKey" />-Objekt stellt einen Knoten auf der Stammebene dar, und das Betriebssystem ist Windows 2000, Windows XP oder Windows Server 2003.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
        /// </PermissionSet>
        public void SetValue(string name, object value, RegistryValueKind valueKind)
        {
            m_key.SetValue(name, value, valueKind);
        }

        /// <summary>Gibt die Zugriffssteuerungssicherheit für den aktuellen Registrierungsschlüssel zurück.</summary>
        /// <returns>Ein Objekt, das die Zugriffssteuerungsberechtigungen für den durch den aktuellen <see cref="T:Microsoft.Win32.RegistryKey" /> dargestellten Registrierungsschlüssel beschreibt.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer verfügt nicht über die notwendigen Berechtigungen.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.InvalidOperationException">Der aktuelle Schlüssel wurde gelöscht.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public IRegistrySecurity GetAccessControl()
        {
            return new RegistrySecurityWrapper(m_key.GetAccessControl());
        }

        /// <summary>
        /// Renames a subkey of the passed in registry key since 
        /// the Framework totally forgot to include such a handy feature.
        /// The RegistryKey that contains the subkey 
        /// you want to rename (must be writeable)
        /// </summary>
        /// <param name="subKeyName">The name of the subkey that you want to rename
        /// </param>
        /// <param name="newSubKeyName">The new name of the RegistryKey</param>
        public void RenameSubKey(string subKeyName, string newSubKeyName)
        {
            CopySubKey(subKeyName, newSubKeyName);
            DeleteSubKeyTree(subKeyName);
        }

        /// <summary>
        /// Copy a registry key.  The parentKey must be writeable.
        /// </summary>
        /// <param name="subKeyFrom"></param>
        /// <param name="subKeyTo"></param>
        public void CopySubKey(string subKeyFrom, string subKeyTo)
        {
            //Create new key
            IRegistryKey destinationKey = CreateSubKey(subKeyTo);

            //Open the sourceKey we are copying from
            IRegistryKey sourceKey = OpenSubKey(subKeyFrom);
            RecurseCopyKey(sourceKey, destinationKey);
        }
        /// <summary>
        /// Copies all values and Subkeys with their values to targetKey. The target will not be pruned beforehand.
        /// </summary>
        /// <param name="targetKey">target key of the copy operation</param>
        public void CopyTo(IRegistryKey targetKey)
        {
            RecurseCopyKey(this, targetKey);
        }

        private static void RecurseCopyKey(IRegistryKey sourceKey, IRegistryKey destinationKey)
        {
            //copy all the values
            foreach (string valueName in sourceKey.GetValueNames())
            {
                object objValue = sourceKey.GetValue(valueName);
                RegistryValueKind valKind = sourceKey.GetValueKind(valueName);
                destinationKey.SetValue(valueName, objValue, valKind);
            }

            //For Each subKey 
            //Create a new subKey in destinationKey 
            foreach (string sourceSubKeyName in sourceKey.GetSubKeyNames())
            {
                IRegistryKey sourceSubKey = sourceKey.OpenSubKey(sourceSubKeyName);
                IRegistryKey destSubKey = destinationKey.CreateSubKey(sourceSubKeyName);
                RecurseCopyKey(sourceSubKey, destSubKey);
            }
        }

        /// <summary>Ruft die Anzahl der Unterschlüssel des aktuellen Schlüssels ab.</summary>
        /// <returns>Die Anzahl der Unterschlüssel des aktuellen Schlüssels.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer besitzt keine Leseberechtigung für den Schlüssel.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Ein Systemfehler ist aufgetreten, möglicherweise wurde der aktuelle Schlüssel gelöscht.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public int SubKeyCount => m_key.SubKeyCount;

        /// <summary>Ruft die Anzahl der Werte im Schlüssel ab.</summary>
        /// <returns>Die Anzahl der Name-Wert-Paare im Schlüssel.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der Benutzer besitzt keine Leseberechtigung für den Schlüssel.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Der zu bearbeitende <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        /// <exception cref="T:System.UnauthorizedAccessException">Der Benutzer verfügt nicht über die notwendigen Registrierungsrechte.</exception>
        /// <exception cref="T:System.IO.IOException">Ein Systemfehler ist aufgetreten, möglicherweise wurde der aktuelle Schlüssel gelöscht.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.RegistryPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public int ValueCount => m_key.ValueCount;

        /// <summary>Ruft den Namen des Schlüssels ab.</summary>
        /// <returns>Der absolute (vollständige) Name des Schlüssels.</returns>
        /// <exception cref="T:System.ObjectDisposedException">Der <see cref="T:Microsoft.Win32.RegistryKey" /> ist geschlossen (auf geschlossene Schlüssel kann nicht zugegriffen werden).</exception>
        public string Name => m_key.Name;

        private readonly RegistryKey m_key;

        public RegistryKeyWrapper(RegistryKey key)
        {
            m_key = key;
        }
    }
}