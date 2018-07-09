using System;
using System.ComponentModel;
using System.Runtime.Remoting;
using System.Windows.Forms;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public interface INotifyIcon
    {
        /// <summary>
        /// Ruft das aktuelle Lebensdauerdienstobjekt ab, das die Lebensdauerrichtlinien für diese Instanz steuert.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        object GetLifetimeService();
        
        /// <summary>
        /// Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien für diese Instanz gesteuert werden können.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt für diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime"/>-Eigenschaft initialisiert wurde.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        object InitializeLifetimeService();
        
        /// <summary>
        /// Erstellt ein Objekt mit allen relevanten Informationen, die zum Generieren eines Proxys für die Kommunikation mit einem Remoteobjekt erforderlich sind.
        /// </summary>
        /// <returns>
        /// Zum Generieren eines Proxys erforderliche Informationen.
        /// </returns>
        /// <param name="requestedType">Der <see cref="T:System.Type"/> des Objekts, auf das der neue <see cref="T:System.Runtime.Remoting.ObjRef"/> verweist.</param><exception cref="T:System.Runtime.Remoting.RemotingException">Diese Instanz ist kein gültiges Remoteobjekt.</exception><exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure"/></PermissionSet>
        ObjRef CreateObjRef(Type requestedType);

        /// <summary>
        /// Gibt alle vom <see cref="T:System.ComponentModel.Component"/> verwendeten Ressourcen frei.
        /// </summary>
        void Dispose();

        /// <summary>
        /// Ruft die <see cref="T:System.ComponentModel.ISite"/> der <see cref="T:System.ComponentModel.Component"/> ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Die der <see cref="T:System.ComponentModel.Component"/> zugeordnete <see cref="T:System.ComponentModel.ISite"/> oder null, wenn die <see cref="T:System.ComponentModel.Component"/> nicht in einem <see cref="T:System.ComponentModel.IContainer"/> gekapselt ist, der <see cref="T:System.ComponentModel.Component"/> keine <see cref="T:System.ComponentModel.ISite"/> zugeordnet ist oder die <see cref="T:System.ComponentModel.Component"/> aus dem <see cref="T:System.ComponentModel.IContainer"/> entfernt wird.
        /// </returns>
        ISite Site { get; set; }

        /// <summary>
        /// Ruft den <see cref="T:System.ComponentModel.IContainer"/> ab, der die <see cref="T:System.ComponentModel.Component"/> enthält.
        /// </summary>
        /// <returns>
        /// Der <see cref="T:System.ComponentModel.IContainer"/>, der die <see cref="T:System.ComponentModel.Component"/> enthält, sofern vorhanden, oder null, wenn die <see cref="T:System.ComponentModel.Component"/> nicht in einem <see cref="T:System.ComponentModel.IContainer"/> gekapselt ist.
        /// </returns>
        IContainer Container { get; }

        /// <summary>
        /// Ruft den Text ab oder legt den Text fest, der in der mit <see cref="T:System.Windows.Forms.NotifyIcon"/> verknüpften QuickInfo-Sprechblase angezeigt wird.
        /// </summary>
        /// <returns>
        /// Der Text, der in der SprechblasenInfo angezeigt wird, die dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnet ist.
        /// </returns>
        string BalloonTipText { get; set; }

        /// <summary>
        /// Ruft das Symbol ab oder legt das Symbol fest, das in der mit <see cref="T:System.Windows.Forms.NotifyIcon"/> verknüpften QuickInfo-Sprechblase angezeigt wird.
        /// </summary>
        /// <returns>
        /// Das <see cref="T:System.Windows.Forms.ToolTipIcon"/>, das in der SprechblasenInfo angezeigt wird, die dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnet ist.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Die angegebene Komponente ist kein <see cref="T:System.Windows.Forms.ToolTipIcon"/>.</exception>
        IToolTipIcon BalloonTipIcon { get; set; }

        /// <summary>
        /// Ruft den Titel der QuickInfo-Sprechblase ab, der für <see cref="T:System.Windows.Forms.NotifyIcon"/> angezeigt wird, oder legt ihn fest.
        /// </summary>
        /// <returns>
        /// Der Text, der als Titel der SprechblasenInfo angezeigt werden soll.
        /// </returns>
        string BalloonTipTitle { get; set; }

        /// <summary>
        /// Ruft das Kontextmenü für das Symbol ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das <see cref="T:System.Windows.Forms.ContextMenu"/> für das Symbol. Der Standardwert ist null.
        /// </returns>
        IContextMenu ContextMenu { get; set; }

        /// <summary>
        /// Ruft das dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnete Kontextmenü ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnete <see cref="T:System.Windows.Forms.ContextMenuStrip"/>.
        /// </returns>
        IContextMenuStrip ContextMenuStrip { get; set; }

        /// <summary>
        /// Ruft das aktuelle Symbol ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das <see cref="T:System.Drawing.Icon"/>, das von der <see cref="T:System.Windows.Forms.NotifyIcon"/>-Komponente angezeigt wird. Der Standardwert ist null.
        /// </returns>
        IIcon Icon { get; set; }

        /// <summary>
        /// Ruft den QuickInfo-Text ab, der angezeigt wird, wenn mit dem Mauszeiger auf ein Symbol im Statusbereich gezeigt wird, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Der QuickInfo-Text, der angezeigt wird, wenn mit dem Mauszeiger auf ein Symbol im Statusbereich gezeigt wird.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">Der QuickInfo-Text ist mehr als 63 Zeichen lang.</exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/><IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        string Text { get; set; }

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob das Symbol im Statusbereich der Taskleiste sichtbar ist, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// true, wenn das Symbol im Statusbereich sichtbar ist, andernfalls false. Der Standardwert ist false.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/><IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        bool Visible { get; set; }

        /// <summary>
        /// Ruft ein Objekt ab, das Daten über das <see cref="T:System.Windows.Forms.NotifyIcon"/> enthält, oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.Object"/>, das Daten über das <see cref="T:System.Windows.Forms.NotifyIcon"/> enthält.
        /// </returns>
        object Tag { get; set; }

        event EventHandler Disposed;

        /// <summary>
        /// Zeigt für den angegebenen Zeitraum in der Taskleiste eine QuickInfo-Sprechblase an.
        /// </summary>
        /// <param name="timeout">Die Zeitdauer in Millisekunden, für die die SprechblasenInfo angezeigt werden soll.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout"/> ist kleiner als 0.</exception>
        void ShowBalloonTip(int timeout);

        /// <summary>
        /// Zeigt für den angegebenen Zeitraum in der Taskleiste eine QuickInfo-Sprechblase mit dem angegebenen Titel, Text und Symbol an.
        /// </summary>
        /// <param name="timeout">Die Zeitdauer in Millisekunden, für die die SprechblasenInfo angezeigt werden soll.</param><param name="tipTitle">Der Titel, der in der SprechblasenInfo angezeigt werden soll.</param><param name="tipText">Der Text, der in der SprechblasenInfo angezeigt werden soll.</param><param name="tipIcon">Einer der <see cref="T:System.Windows.Forms.ToolTipIcon"/>-Werte.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout"/> ist kleiner als 0.</exception><exception cref="T:System.ArgumentException"><paramref name="tipText"/> ist null oder eine leere Zeichenfolge.</exception><exception cref="T:System.ComponentModel.InvalidEnumArgumentException"><paramref name="tipIcon"/> ist kein Member von <see cref="T:System.Windows.Forms.ToolTipIcon"/>.</exception>
        void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon);

        event EventHandler BalloonTipClicked;
        event EventHandler BalloonTipClosed;
        event EventHandler BalloonTipShown;
        event EventHandler Click;
        event EventHandler DoubleClick;
        event MouseEventHandler MouseClick;
        event MouseEventHandler MouseDoubleClick;
        event MouseEventHandler MouseDown;
        event MouseEventHandler MouseMove;
        event MouseEventHandler MouseUp;
    }
}