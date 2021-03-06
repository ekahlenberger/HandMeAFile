﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Remoting;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public class ProcessWrapper : IProcess
    {
        /// <summary>Ruft das aktuelle Lebensdauerdienstobjekt ab, das die Lebensdauerrichtlinien für diese Instanz steuert.</summary>
        /// <returns>Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" />
        /// </PermissionSet>
        public object GetLifetimeService()
        {
            return m_orgProcess.GetLifetimeService();
        }

        /// <summary>Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien für diese Instanz gesteuert werden können.</summary>
        /// <returns>Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease" />, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt für diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime" />-Eigenschaft initialisiert wurde.</returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure" />
        /// </PermissionSet>
        public object InitializeLifetimeService()
        {
            return m_orgProcess.InitializeLifetimeService();
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
            return m_orgProcess.CreateObjRef(requestedType);
        }

        /// <summary>Gibt alle vom <see cref="T:System.ComponentModel.Component" /> verwendeten Ressourcen frei.</summary>
        public void Dispose()
        {
            m_orgProcess.Dispose();
        }

        /// <summary>Ruft die <see cref="T:System.ComponentModel.ISite" /> der <see cref="T:System.ComponentModel.Component" /> ab oder legt diese fest.</summary>
        /// <returns>Die der <see cref="T:System.ComponentModel.Component" /> zugeordnete <see cref="T:System.ComponentModel.ISite" /> oder null, wenn die <see cref="T:System.ComponentModel.Component" /> nicht in einem <see cref="T:System.ComponentModel.IContainer" /> gekapselt ist, der <see cref="T:System.ComponentModel.Component" /> keine <see cref="T:System.ComponentModel.ISite" /> zugeordnet ist oder die <see cref="T:System.ComponentModel.Component" /> aus dem <see cref="T:System.ComponentModel.IContainer" /> entfernt wird.</returns>
        public ISite Site
        {
            get { return m_orgProcess.Site; }
            set { m_orgProcess.Site = value; }
        }

        /// <summary>Ruft den <see cref="T:System.ComponentModel.IContainer" /> ab, der die <see cref="T:System.ComponentModel.Component" /> enthält.</summary>
        /// <returns>Der <see cref="T:System.ComponentModel.IContainer" />, der die <see cref="T:System.ComponentModel.Component" /> enthält, sofern vorhanden, oder null, wenn die <see cref="T:System.ComponentModel.Component" /> nicht in einem <see cref="T:System.ComponentModel.IContainer" /> gekapselt ist.</returns>
        public IContainer Container => m_orgProcess.Container;

        public event EventHandler Disposed
        {
            add { m_orgProcess.Disposed += value; }
            remove { m_orgProcess.Disposed -= value; }
        }

        /// <summary>Schließt einen Prozess mit einer Benutzeroberfläche, indem eine Meldung zum Schließen an das Hauptfenster gesendet wird.</summary>
        /// <returns>true, wenn die Meldung zum Schließen erfolgreich gesendet wurde. false, wenn der zugeordnete Prozess nicht über ein Hauptfenster verfügt oder wenn das Hauptfenster deaktiviert ist (z. B., wenn ein modales Dialogfeld angezeigt wird).</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />-Eigenschaft auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess wurde bereits beendet.  -oder- Dem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        public bool CloseMainWindow()
        {
            return m_orgProcess.CloseMainWindow();
        }

        /// <summary>Gibt alle dieser Komponente zugeordneten Ressourcen frei.</summary>
        public void Close()
        {
            m_orgProcess.Close();
        }

        /// <summary>Verwirft alle Informationen über den zugeordneten Prozess, die in der Prozesskomponente zwischengespeichert waren.</summary>
        public void Refresh()
        {
            m_orgProcess.Refresh();
        }

        /// <summary>Startet die von der <see cref="P:System.Diagnostics.Process.StartInfo" />-Eigenschaft dieser <see cref="T:System.Diagnostics.Process" />-Komponente angegebene Prozessressource (oder verwendet sie erneut) und ordnet diese der Komponente zu.</summary>
        /// <returns>true, wenn eine Prozessressource gestartet wird. false, wenn keine neue Prozessressource gestartet wird, sondern z. B. eine vorhandene Prozessressource wiederverwendet wird.</returns>
        /// <exception cref="T:System.InvalidOperationException">Im <see cref="P:System.Diagnostics.Process.StartInfo" /> der <see cref="T:System.Diagnostics.Process" />-Komponente wurde kein Dateiname angegeben. -oder-  Der <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />-Member der <see cref="P:System.Diagnostics.Process.StartInfo" />-Eigenschaft ist true, und <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardInput" />, <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" /> oder <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" /> ist true.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Beim Öffnen der zugeordneten Datei ist ein Fehler aufgetreten.</exception>
        /// <exception cref="T:System.ObjectDisposedException">Das Prozessobjekt wurde bereits verworfen.</exception>
        public bool Start()
        {
            return m_orgProcess.Start();
        }

        /// <summary>Hält den zugeordneten Prozess sofort an.</summary>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Der zugeordnete Prozess konnte nicht beendet werden.  -oder- Der Prozess wird beendet. -oder-  Der zugeordnete Prozess ist eine ausführbare Win16-Datei.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, <see cref="M:System.Diagnostics.Process.Kill" /> für einen auf einem Remotecomputer ausgeführten Prozess aufzurufen. Die Methode ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess wurde bereits beendet.  -oder- Diesem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        public void Kill()
        {
            m_orgProcess.Kill();
        }

        /// <summary>Weist die <see cref="T:System.Diagnostics.Process" />-Komponente an, für die Dauer von angegebenen Millisekunden zu warten, bis der zugeordnete Prozess beendet wird.</summary>
        /// <returns>true, wenn der zugeordnete Prozess beendet wurde, andernfalls false.</returns>
        /// <param name="milliseconds">Die Zeitspanne in Millisekunden, die auf die Beendigung des zugeordneten Prozesses gewartet werden soll. Der Höchstwert ist der größtmögliche Wert einer 32-Bit-Ganzzahl, der für das Betriebssystem unendlich bedeutet.</param>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Auf die Warteeinstellung konnte nicht zugegriffen werden.</exception>
        /// <exception cref="T:System.SystemException">Es wurde keine <see cref="P:System.Diagnostics.Process.Id" /> für den Prozess festgelegt, und es ist kein <see cref="P:System.Diagnostics.Process.Handle" /> vorhanden, über das die <see cref="P:System.Diagnostics.Process.Id" />-Eigenschaft bestimmt werden kann. -oder-  Diesem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet. -oder-  Sie versuchen, <see cref="M:System.Diagnostics.Process.WaitForExit(System.Int32)" /> für einen auf einem Remotecomputer ausgeführten Prozess aufzurufen. Diese Methode ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public bool WaitForExit(int milliseconds)
        {
            return m_orgProcess.WaitForExit(milliseconds);
        }

        /// <summary>Weist die <see cref="T:System.Diagnostics.Process" />-Komponente an, unbestimmte Zeit zu warten, bis der zugeordnete Prozess beendet wird.</summary>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Auf die Warteeinstellung konnte nicht zugegriffen werden.</exception>
        /// <exception cref="T:System.SystemException">Es wurde keine <see cref="P:System.Diagnostics.Process.Id" /> für den Prozess festgelegt, und es ist kein <see cref="P:System.Diagnostics.Process.Handle" /> vorhanden, über das die <see cref="P:System.Diagnostics.Process.Id" />-Eigenschaft bestimmt werden kann. -oder-  Diesem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet. -oder-  Sie versuchen, <see cref="M:System.Diagnostics.Process.WaitForExit" /> für einen auf einem Remotecomputer ausgeführten Prozess aufzurufen. Diese Methode ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public void WaitForExit()
        {
            m_orgProcess.WaitForExit();
        }

        /// <summary>Bewirkt, dass die <see cref="T:System.Diagnostics.Process" />-Komponente die Dauer von angegebenen Millisekunden wartet, bis der zugeordnete Prozess in den Leerlauf wechselt. Diese Überladung ist nur für Prozesse mit einer Benutzeroberfläche und einer Nachrichtenschleife gültig.</summary>
        /// <returns>true, wenn der zugeordnete Prozess in den Leerlauf wechselt, andernfalls false.</returns>
        /// <param name="milliseconds">Der Wert 1 für <see cref="F:System.Int32.MaxValue" />, der die Zeitspanne in Millisekunden angibt, die gewartet werden soll, bis sich der zugehörige Prozess im Leerlauf befindet. Der Wert 0 gibt eine sofortige Rückgabe an, der Wert -1 gibt eine unendliche Wartezeit an.</param>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess hat keine grafische Schnittstelle. -oder- Unbekannter Fehler. Der Prozess konnte nicht in den Leerlauf eintreten. -oder- Der Prozess wurde bereits beendet.  -oder- Dem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        public bool WaitForInputIdle(int milliseconds)
        {
            return m_orgProcess.WaitForInputIdle(milliseconds);
        }

        /// <summary>Bewirkt, dass die <see cref="T:System.Diagnostics.Process" />-Komponente unbegrenzt wartet, bis der zugeordnete Prozess in den Leerlauf wechselt. Diese Überladung ist nur für Prozesse mit einer Benutzeroberfläche und einer Nachrichtenschleife gültig.</summary>
        /// <returns>true, wenn der zugehörige Prozess in den Leerlauf wechselt.</returns>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess hat keine grafische Schnittstelle. -oder- Unbekannter Fehler. Der Prozess konnte nicht in den Leerlauf eintreten. -oder- Der Prozess wurde bereits beendet.  -oder- Dem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        public bool WaitForInputIdle()
        {
            return m_orgProcess.WaitForInputIdle();
        }

        /// <summary>Startet asynchrone Lesevorgänge im umgeleiteten <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream der Anwendung.</summary>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardOutput" />-Eigenschaft ist false. - oder -  Ein asynchroner Lesevorgang wird bereits im <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream ausgeführt. - oder -  Der <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream wurde von einem synchronen Lesevorgang verwendet.</exception>
        public void BeginOutputReadLine()
        {
            m_orgProcess.BeginOutputReadLine();
        }

        /// <summary>Startet asynchrone Lesevorgänge im umgeleiteten <see cref="P:System.Diagnostics.Process.StandardError" />-Stream der Anwendung.</summary>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.ProcessStartInfo.RedirectStandardError" />-Eigenschaft ist false. - oder -  Ein asynchroner Lesevorgang wird bereits im <see cref="P:System.Diagnostics.Process.StandardError" />-Stream ausgeführt. - oder -  Der <see cref="P:System.Diagnostics.Process.StandardError" />-Stream wurde von einem synchronen Lesevorgang verwendet.</exception>
        public void BeginErrorReadLine()
        {
            m_orgProcess.BeginErrorReadLine();
        }

        /// <summary>Bricht den asynchronen Lesevorgang im umgeleiteten <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream einer Anwendung ab.</summary>
        /// <exception cref="T:System.InvalidOperationException">Der <see cref="P:System.Diagnostics.Process.StandardOutput" />-Stream ist nicht für asynchrone Lesevorgänge aktiviert.</exception>
        public void CancelOutputRead()
        {
            m_orgProcess.CancelOutputRead();
        }

        /// <summary>Bricht den asynchronen Lesevorgang im umgeleiteten <see cref="P:System.Diagnostics.Process.StandardError" />-Stream einer Anwendung ab.</summary>
        /// <exception cref="T:System.InvalidOperationException">Der <see cref="P:System.Diagnostics.Process.StandardError" />-Stream ist nicht für asynchrone Lesevorgänge aktiviert.</exception>
        public void CancelErrorRead()
        {
            m_orgProcess.CancelErrorRead();
        }

        /// <summary>Ruft die Basispriorität des zugeordneten Prozesses ab.</summary>
        /// <returns>Die Basispriorität, die anhand der <see cref="P:System.Diagnostics.Process.PriorityClass" /> des zugeordneten Prozesses berechnet wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />-Eigenschaft auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess wurde beendet. -oder-  Der Prozess wurde nicht gestartet, daher ist keine Prozess-ID vorhanden.</exception>
        public int BasePriority => m_orgProcess.BasePriority;

        /// <summary>Ruft den Wert ab, der vom zugeordneten Prozess beim Beenden angegeben wurde.</summary>
        /// <returns>Der Code, der vom zugeordneten Prozess beim Beenden angegeben wurde.</returns>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess wurde nicht beendet. -oder-  Das <see cref="P:System.Diagnostics.Process.Handle" /> des Prozesses ist ungültig.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.ExitCode" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public int ExitCode => m_orgProcess.ExitCode;

        /// <summary>Ruft einen Wert ab, der angibt, ob der zugehörige Prozess beendet wurde.</summary>
        /// <returns>true, wenn der Betriebssystemprozess, auf den die <see cref="T:System.Diagnostics.Process" />-Komponente verweist, beendet wurde, ansonsten false.</returns>
        /// <exception cref="T:System.InvalidOperationException">Dem Objekt ist kein Prozess zugeordnet.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Der Exitcode für den Prozess konnte nicht abgerufen werden.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.HasExited" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public bool HasExited => m_orgProcess.HasExited;

        /// <summary>Ruft den Zeitpunkt ab, zu dem der zugeordnete Prozess beendet wurde.</summary>
        /// <returns>Eine <see cref="T:System.DateTime" />, die angibt, wann der zugeordnete Prozess beendet wurde.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.ExitTime" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public DateTime ExitTime => m_orgProcess.ExitTime;

        /// <summary>Ruft das systemeigene Handle des zugeordneten Prozesses ab.</summary>
        /// <returns>Das Handle, das das Betriebssystem dem zugeordneten Prozess beim Starten des Prozesses zugewiesen hat. Das System verwendet dieses Handle zum Verfolgen der Prozessattribute.</returns>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess wurde nicht gestartet, oder er wurde beendet. Die <see cref="P:System.Diagnostics.Process.Handle" />-Eigenschaft kann nicht gelesen werden, da dieser <see cref="T:System.Diagnostics.Process" />-Instanz kein Prozess zugeordnet ist. -oder-  Die <see cref="T:System.Diagnostics.Process" />-Instanz wurde an einen laufenden Prozess angefügt, Sie haben aber keine ausreichenden Berechtigungen zum Abrufen eines Handles mit vollen Zugriffsrechten.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.Handle" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public IntPtr Handle => m_orgProcess.Handle;

        /// <summary>Ruft die Anzahl der vom Prozess geöffneten Handles ab.</summary>
        /// <returns>Die Anzahl der vom Prozess geöffneten Betriebssystemhandles.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />-Eigenschaft auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        public int HandleCount => m_orgProcess.HandleCount;

        /// <summary>Ruft den eindeutigen Bezeichner für den zugeordneten Prozess ab.</summary>
        /// <returns>Der vom System generierte eindeutige Bezeichner des Prozesses, auf den von dieser <see cref="T:System.Diagnostics.Process" />-Instanz verwiesen wird.</returns>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" />-Eigenschaft des Prozesses wurde nicht festgelegt. -oder-  Diesem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie die <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" />-Eigenschaft auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        public int Id => m_orgProcess.Id;

        /// <summary>Ruft den Namen des Computers ab, auf dem der zugeordnete Prozess ausgeführt wird.</summary>
        /// <returns>Der Name des Computers, auf dem der zugeordnete Prozess ausgeführt wird.</returns>
        /// <exception cref="T:System.InvalidOperationException">Diesem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        public string MachineName => m_orgProcess.MachineName;

        /// <summary>Ruft das Fensterhandle des Hauptfensters des zugeordneten Prozesses ab.</summary>
        /// <returns>Das vom System generierte Fensterhandle des Hauptfensters des zugeordneten Prozesses.</returns>
        /// <exception cref="T:System.InvalidOperationException">
        /// <see cref="P:System.Diagnostics.Process.MainWindowHandle" /> ist nicht definiert, da der Prozess beendet wurde.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.MainWindowHandle" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        public IntPtr MainWindowHandle => m_orgProcess.MainWindowHandle;

        /// <summary>Ruft die Beschriftung des Hauptfensters des Prozesses ab.</summary>
        /// <returns>Der Titel des Hauptfensters des Prozesses.</returns>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.MainWindowTitle" />-Eigenschaft ist nicht definiert, da der Prozess beendet wurde.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.MainWindowTitle" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        public string MainWindowTitle => m_orgProcess.MainWindowTitle;

        /// <summary>Ruft das Hauptmodul für den zugeordneten Prozess ab.</summary>
        /// <returns>Das zum Starten des Prozesses verwendete <see cref="T:System.Diagnostics.ProcessModule" />.</returns>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.MainModule" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Ein 32-Bit-Prozess versucht, auf die Module eines 64-Bit-Prozesses zuzugreifen.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" /> des Prozesses ist nicht verfügbar. -oder-  Der Prozess wurde beendet.</exception>
        public ProcessModule MainModule => m_orgProcess.MainModule;

        /// <summary>Ruft die maximal zulässige Workingsetgröße für den zugeordneten Prozess ab oder legt diese fest.</summary>
        /// <returns>Die im Speicher maximal zulässige Workingsetgröße für den Prozess in Bytes.</returns>
        /// <exception cref="T:System.ArgumentException">Die maximale Workingsetgröße ist ungültig. Sie muss größer als die minimale Größe der Arbeitsseiten sein oder ihr entsprechen.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Es können keine Arbeitsseiteninformationen von der zugeordneten Prozessressource abgerufen werden. -oder-  Die Prozess-ID oder das Prozesshandle ist 0, da der Prozess noch nicht gestartet wurde.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.MaxWorkingSet" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" /> des Prozesses ist nicht verfügbar. -oder-  Der Prozess wurde beendet.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public IntPtr MaxWorkingSet
        {
            get { return m_orgProcess.MaxWorkingSet; }
            set { m_orgProcess.MaxWorkingSet = value; }
        }

        /// <summary>Ruft die minimale zulässige Workingsetgröße für den zugeordneten Prozess ab oder legt diese fest.</summary>
        /// <returns>Die im Speicher mindestens erforderliche Workingsetgröße für den Prozess in Bytes.</returns>
        /// <exception cref="T:System.ArgumentException">Die minimale Workingsetgröße ist ungültig. Sie muss kleiner als die maximale Größe der Arbeitsseiten sein oder ihr entsprechen.</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Es können keine Arbeitsseiteninformationen von der zugeordneten Prozessressource abgerufen werden. -oder-  Die Prozess-ID oder das Prozesshandle ist 0, da der Prozess noch nicht gestartet wurde.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.MinWorkingSet" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" /> des Prozesses ist nicht verfügbar. -oder-  Der Prozess wurde beendet.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public IntPtr MinWorkingSet
        {
            get { return m_orgProcess.MinWorkingSet; }
            set { m_orgProcess.MinWorkingSet = value; }
        }

        /// <summary>Ruft die Menge des für den zugeordneten Prozess belegten nicht ausgelagerten Systemspeichers ab.</summary>
        /// <returns>Der Anteil am Systemspeicher in Bytes, der für den zugeordneten Prozess reserviert ist und der nicht in die Auslagerungsdatei des virtuellen Speichers geschrieben werden kann.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long NonpagedSystemMemorySize64 => m_orgProcess.NonpagedSystemMemorySize64;

        /// <summary>Ruft die Größe des ausgelagerten Speichers ab, der für den zugeordneten Prozess belegt wird.</summary>
        /// <returns>Die Größe des Arbeitsspeichers in Bytes, der für den zugeordneten Prozess in der Auslagerungsdatei des virtuellen Arbeitsspeichers belegt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long PagedMemorySize64 => m_orgProcess.PagedMemorySize64;

        /// <summary>Ruft die Menge des für den zugeordneten Prozess belegten auslagerbaren Systemspeichers ab.</summary>
        /// <returns>Der Anteil am Systemspeicher in Bytes, der für den zugeordneten Prozess belegt wird und der in die Auslagerungsdatei des virtuellen Speichers geschrieben werden kann.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long PagedSystemMemorySize64 => m_orgProcess.PagedSystemMemorySize64;

        /// <summary>Ruft die vom zugeordneten Prozess verwendete maximale Speichergröße in der Auslagerungsdatei des virtuellen Arbeitsspeichers ab.</summary>
        /// <returns>Die maximale Größe des Arbeitsspeichers in Bytes, der seit dem Starten für den zugeordneten Prozess in der Auslagerungsdatei des virtuellen Arbeitsspeichers belegt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long PeakPagedMemorySize64 => m_orgProcess.PeakPagedMemorySize64;
        
        /// <summary>Ruft die maximale Größe des physischen Speichers ab, der vom zugeordneten Prozess verwendet wird.</summary>
        /// <returns>Die maximale Größe des physischen Speichers in Bytes, der für den zugeordneten Prozess seit dem Starten belegt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long PeakWorkingSet64 => m_orgProcess.PeakWorkingSet64;
        
        /// <summary>Ruft die maximale Größe des virtuellen Speichers ab, der vom zugeordneten Prozess verwendet wird.</summary>
        /// <returns>Die maximale Größe des virtuellen Arbeitsspeichers in Bytes, der für den zugeordneten Prozess seit dem Starten belegt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long PeakVirtualMemorySize64 => m_orgProcess.PeakVirtualMemorySize64;

        /// <summary>Ruft einen Wert ab, der angibt, ob die zugeordnete Prozesspriorität durch das Betriebssystem vorübergehend erhöht werden soll, wenn das Hauptfenster den Fokus besitzt, oder legt diesen fest.</summary>
        /// <returns>true, wenn die Prozesspriorität eines Prozesses dynamisch erhöht werden soll, wenn dieser den Wartezustand verlässt, andernfalls false. Die Standardeinstellung ist false.</returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Informationen über die Prioritätserhöhung konnten von der zugeordneten Prozessressource nicht abgerufen werden.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen. -oder-  Die Prozess-ID oder das Prozesshandle ist 0. (Der Prozess wurde nicht gestartet.)</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.PriorityBoostEnabled" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" /> des Prozesses ist nicht verfügbar.</exception>
        public bool PriorityBoostEnabled
        {
            get { return m_orgProcess.PriorityBoostEnabled; }
            set { m_orgProcess.PriorityBoostEnabled = value; }
        }

        /// <summary>Ruft die allgemeine Prioritätskategorie für den zugeordneten Prozess ab oder legt diese fest.</summary>
        /// <returns>Die Prioritätskategorie für den zugeordneten Prozess, aus der die <see cref="P:System.Diagnostics.Process.BasePriority" /> des Prozesses berechnet wird.</returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Informationen über die Prozesspriorität konnten von der zugeordneten Prozessressource nicht festgelegt oder abgerufen werden. -oder-  Die Prozess-ID oder das Prozesshandle ist 0. (Der Prozess wurde nicht gestartet.)</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.PriorityClass" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" /> des Prozesses ist nicht verfügbar.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Sie haben bei der Verwendung von Windows 98 oder Windows Millennium Edition (Windows Me) die <see cref="P:System.Diagnostics.Process.PriorityClass" /> auf AboveNormal oder BelowNormal festgelegt. Diese Plattformen unterstützen diese Werte für die Prioritätsklasse nicht.</exception>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Die Prioritätsklasse kann nicht festgelegt werden, da für diese kein gültiger Wert verwendet wird, wie in der <see cref="T:System.Diagnostics.ProcessPriorityClass" />-Enumeration definiert.</exception>
        public ProcessPriorityClass PriorityClass
        {
            get { return m_orgProcess.PriorityClass; }
            set { m_orgProcess.PriorityClass = value; }
        }

        /// <summary>Ruft die Größe des privaten Speichers ab, der für den zugeordneten Prozess belegt wird.</summary>
        /// <returns>Die Größe des Speichers in Bytes, der für den zugeordneten Prozess belegt wird und nicht mit anderen Prozessen gemeinsam genutzt werden kann.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long PrivateMemorySize64 => m_orgProcess.PrivateMemorySize64;

        /// <summary>Ruft die privilegierte Prozessorzeit für diesen Prozess ab.</summary>
        /// <returns>Eine <see cref="T:System.TimeSpan" />, die angibt, wie lange der Prozess im Betriebssystemkern Code ausgeführt hat.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public TimeSpan PrivilegedProcessorTime => m_orgProcess.PrivilegedProcessorTime;

        /// <summary>Ruft den Namen des Prozesses ab.</summary>
        /// <returns>Der Name, mit dem das System den Prozess für den Benutzer kennzeichnet.</returns>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess verfügt über keinen Bezeichner, oder dem <see cref="T:System.Diagnostics.Process" /> ist kein Prozess zugeordnet. -oder-  Der zugeordnete Prozess wurde beendet.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        /// <exception cref="T:System.NotSupportedException">Der Prozess befindet sich nicht auf diesem Computer.</exception>
        public string ProcessName => m_orgProcess.ProcessName;

        /// <summary>Ruft die Prozessoren ab, auf denen die Ausführung der Threads in diesem Prozess geplant werden kann, oder legt diese fest.</summary>
        /// <returns>Eine Bitmaske, die angibt, auf welchen Prozessoren die Threads im zugeordneten Prozess ausgeführt werden können. Der Standardwert hängt von der Anzahl der Prozessoren des Computers ab. Der Standardwert ist 2n-1, wobei n die Anzahl der Prozessoren ist.</returns>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Informationen über <see cref="P:System.Diagnostics.Process.ProcessorAffinity" /> konnten von der zugeordneten Prozessressource nicht festgelegt oder abgerufen werden. -oder-  Die Prozess-ID oder das Prozesshandle ist 0. (Der Prozess wurde nicht gestartet.)</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.ProcessorAffinity" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.Diagnostics.Process.Id" /> des Prozesses ist nicht verfügbar. -oder-  Der Prozess wurde beendet.</exception>
        public IntPtr ProcessorAffinity
        {
            get { return m_orgProcess.ProcessorAffinity; }
            set { m_orgProcess.ProcessorAffinity = value; }
        }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Benutzeroberfläche des Prozesses reagiert.</summary>
        /// <returns>true, wenn die Benutzeroberfläche des zugeordneten Prozesses auf das System reagiert, andernfalls false.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me). Legen Sie <see cref="P:System.Diagnostics.ProcessStartInfo.UseShellExecute" /> auf false fest, um auf diese Eigenschaft unter Windows 98 und Windows Me zuzugreifen.</exception>
        /// <exception cref="T:System.InvalidOperationException">Diesem <see cref="T:System.Diagnostics.Process" />-Objekt ist kein Prozess zugeordnet.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.Responding" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public bool Responding => m_orgProcess.Responding;

        /// <summary>Ruft die Terminaldienste-Sitzungs-ID für den zugeordneten Prozess ab.</summary>
        /// <returns>Die Terminaldienste-Sitzungs-ID für den zugeordneten Prozess.</returns>
        /// <exception cref="T:System.NullReferenceException">Diesem Prozess ist keine Sitzung zugeordnet.</exception>
        /// <exception cref="T:System.InvalidOperationException">Dieser Sitzungs-ID ist kein Prozess zugeordnet. -oder- Der zugeordnete Prozess befindet sich nicht auf diesem Computer.</exception>
        /// <exception cref="T:System.PlatformNotSupportedException">Die <see cref="P:System.Diagnostics.Process.SessionId" />-Eigenschaft wird unter Windows 98 nicht unterstützt.</exception>
        public int SessionId => m_orgProcess.SessionId;

        /// <summary>Ruft die Eigenschaften ab, die an die <see cref="M:System.Diagnostics.Process.Start" />-Methode von <see cref="T:System.Diagnostics.Process" /> übergeben werden sollen, oder legt diese fest.</summary>
        /// <returns>Die <see cref="T:System.Diagnostics.ProcessStartInfo" />, die die Daten darstellt, mit denen der Prozess gestartet werden soll. Diese Argumente beinhalten den Namen der ausführbaren Datei oder des Dokuments, das zum Starten des Prozesses verwendet wurde.</returns>
        /// <exception cref="T:System.ArgumentNullException">Der Wert, der <see cref="P:System.Diagnostics.Process.StartInfo" /> angibt, ist null.</exception>
        public IProcessStartInfo StartInfo
        {
            get { return new ProcessStartInfoWrapper(m_orgProcess.StartInfo); }
            set
            {
                IProvideOrgProcessStartInfo orgProvider = value as IProvideOrgProcessStartInfo;
                if (orgProvider != null) m_orgProcess.StartInfo = orgProvider.OrgInfo;
                else throw new ArgumentException("IProcessStartInfo implementation has to implement IProvideOrgProcessStartInfo for interoperability");
            }
        }

        /// <summary>Ruft die Zeit ab, zu der der zugeordnete Prozess gestartet wurde.</summary>
        /// <returns>Ein Objekt, das angibt, wann der zugeordnete Prozess gestartet wurde. Eine Ausnahme wird ausgelöst, wenn der Prozess nicht ausgeführt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.StartTime" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        /// <exception cref="T:System.InvalidOperationException">Der Prozess wurde beendet. -oder- (Der Prozess wurde nicht gestartet.)</exception>
        /// <exception cref="T:System.ComponentModel.Win32Exception">Fehler beim Aufruf der Windows-Funktion.</exception>
        public DateTime StartTime => m_orgProcess.StartTime;

        /// <summary>Ruft das Objekt ab, das zum Marshallen der Ereignishandleraufrufe verwendet wird, die als Ergebnis eines Prozessbeendigungsereignisses ausgegeben werden, oder legt dieses fest.</summary>
        /// <returns>Das <see cref="T:System.ComponentModel.ISynchronizeInvoke" />, das zum Marshallen von Ereignishandleraufrufen verwendet wird, die als Ergebnis eines <see cref="E:System.Diagnostics.Process.Exited" />-Ereignisses des Prozesses ausgegeben werden.</returns>
        public ISynchronizeInvoke SynchronizingObject
        {
            get { return m_orgProcess.SynchronizingObject; }
            set { m_orgProcess.SynchronizingObject = value; }
        }

        /// <summary>Ruft die gesamte Prozessorzeit für diesen Prozess ab.</summary>
        /// <returns>Eine <see cref="T:System.TimeSpan" />, die die Zeitspanne angibt, während der der zugeordnete Prozess die CPU verwendet hat. Dieser Wert ist die Summe von <see cref="P:System.Diagnostics.Process.UserProcessorTime" /> und <see cref="P:System.Diagnostics.Process.PrivilegedProcessorTime" />.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.TotalProcessorTime" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public TimeSpan TotalProcessorTime => m_orgProcess.TotalProcessorTime;

        /// <summary>Ruft die Benutzerprozessorzeit für diesen Prozess ab.</summary>
        /// <returns>Eine <see cref="T:System.TimeSpan" />, die die Zeitspanne angibt, während der der zugeordnete Prozess Code innerhalb der Anwendung des Prozesses (nicht im Betriebssystemkern) ausgeführt hat.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        /// <exception cref="T:System.NotSupportedException">Sie versuchen, auf die <see cref="P:System.Diagnostics.Process.UserProcessorTime" />-Eigenschaft für einen auf einem Remotecomputer ausgeführten Prozess zuzugreifen. Diese Eigenschaft ist nur für Prozesse verfügbar, die auf dem lokalen Computer ausgeführt werden.</exception>
        public TimeSpan UserProcessorTime => m_orgProcess.UserProcessorTime;

        /// <summary>Ruft die Größe des virtuellen Speichers ab, der für den zugeordneten Prozess belegt wird.</summary>
        /// <returns>Die Größe des virtuellen Speichers in Bytes, der für den zugeordneten Prozess belegt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long VirtualMemorySize64 => m_orgProcess.VirtualMemorySize64;

        /// <summary>Ruft ab oder legt fest, ob beim Beenden des Prozesses das <see cref="E:System.Diagnostics.Process.Exited" />-Ereignis ausgelöst werden soll.</summary>
        /// <returns>true, wenn das <see cref="E:System.Diagnostics.Process.Exited" />-Ereignis ausgelöst werden soll, wenn der zugeordnete Prozess beendet wird (entweder durch Beenden oder einen Aufruf von <see cref="M:System.Diagnostics.Process.Kill" />), andernfalls false. Die Standardeinstellung ist false.</returns>
        public bool EnableRaisingEvents
        {
            get { return m_orgProcess.EnableRaisingEvents; }
            set { m_orgProcess.EnableRaisingEvents = value; }
        }
        /// <summary>Ruft die Größe des physischen Speichers ab, der für den zugeordneten Prozess belegt wird.</summary>
        /// <returns>Die Größe des physischen Speichers in Bytes, der für den zugeordneten Prozess belegt wird.</returns>
        /// <exception cref="T:System.PlatformNotSupportedException">Die Plattform ist Windows 98 oder Windows Millennium Edition (Windows Me), die diese Eigenschaft nicht unterstützen.</exception>
        public long WorkingSet64 => m_orgProcess.WorkingSet64;

        public event DataReceivedEventHandler OutputDataReceived
        {
            add { m_orgProcess.OutputDataReceived += value; }
            remove { m_orgProcess.OutputDataReceived -= value; }
        }

        public event DataReceivedEventHandler ErrorDataReceived
        {
            add { m_orgProcess.ErrorDataReceived += value; }
            remove { m_orgProcess.ErrorDataReceived -= value; }
        }

        public event EventHandler Exited
        {
            add { m_orgProcess.Exited += value; }
            remove { m_orgProcess.Exited -= value; }
        }

        private Process m_orgProcess;

        public ProcessWrapper(Process orgProcess)
        {
            m_orgProcess = orgProcess;
        }
    }
}