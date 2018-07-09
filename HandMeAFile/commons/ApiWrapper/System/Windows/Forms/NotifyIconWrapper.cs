using System;
using System.ComponentModel;
using System.Runtime.Remoting;
using System.Windows.Forms;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Windows.Forms
{
    public class NotifyIconWrapper : INotifyIcon 
    {
        /// <summary>
        /// Ruft das aktuelle Lebensdauerdienstobjekt ab, das die Lebensdauerrichtlinien für diese Instanz steuert.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        public object GetLifetimeService()
        {
            return m_orgIcon.GetLifetimeService();
        }

        /// <summary>
        /// Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien für diese Instanz gesteuert werden können.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt für diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime"/>-Eigenschaft initialisiert wurde.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        public object InitializeLifetimeService()
        {
            return m_orgIcon.InitializeLifetimeService();
        }

        /// <summary>
        /// Erstellt ein Objekt mit allen relevanten Informationen, die zum Generieren eines Proxys für die Kommunikation mit einem Remoteobjekt erforderlich sind.
        /// </summary>
        /// <returns>
        /// Zum Generieren eines Proxys erforderliche Informationen.
        /// </returns>
        /// <param name="requestedType">Der <see cref="T:System.Type"/> des Objekts, auf das der neue <see cref="T:System.Runtime.Remoting.ObjRef"/> verweist.</param><exception cref="T:System.Runtime.Remoting.RemotingException">Diese Instanz ist kein gültiges Remoteobjekt.</exception><exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure"/></PermissionSet>
        public ObjRef CreateObjRef(Type requestedType)
        {
            return m_orgIcon.CreateObjRef(requestedType);
        }

        /// <summary>
        /// Gibt alle vom <see cref="T:System.ComponentModel.Component"/> verwendeten Ressourcen frei.
        /// </summary>
        public void Dispose()
        {
            m_orgIcon.Dispose();
        }

        /// <summary>
        /// Ruft die <see cref="T:System.ComponentModel.ISite"/> der <see cref="T:System.ComponentModel.Component"/> ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Die der <see cref="T:System.ComponentModel.Component"/> zugeordnete <see cref="T:System.ComponentModel.ISite"/> oder null, wenn die <see cref="T:System.ComponentModel.Component"/> nicht in einem <see cref="T:System.ComponentModel.IContainer"/> gekapselt ist, der <see cref="T:System.ComponentModel.Component"/> keine <see cref="T:System.ComponentModel.ISite"/> zugeordnet ist oder die <see cref="T:System.ComponentModel.Component"/> aus dem <see cref="T:System.ComponentModel.IContainer"/> entfernt wird.
        /// </returns>
        public ISite Site
        {
            get { return m_orgIcon.Site; }
            set { m_orgIcon.Site = value; }
        }

        /// <summary>
        /// Ruft den <see cref="T:System.ComponentModel.IContainer"/> ab, der die <see cref="T:System.ComponentModel.Component"/> enthält.
        /// </summary>
        /// <returns>
        /// Der <see cref="T:System.ComponentModel.IContainer"/>, der die <see cref="T:System.ComponentModel.Component"/> enthält, sofern vorhanden, oder null, wenn die <see cref="T:System.ComponentModel.Component"/> nicht in einem <see cref="T:System.ComponentModel.IContainer"/> gekapselt ist.
        /// </returns>
        public IContainer Container
        {
            get { return m_orgIcon.Container; }
        }

        public event EventHandler Disposed
        {
            add { m_orgIcon.Disposed += value; }
            remove { m_orgIcon.Disposed -= value; }
        }

        /// <summary>
        /// Zeigt für den angegebenen Zeitraum in der Taskleiste eine QuickInfo-Sprechblase an.
        /// </summary>
        /// <param name="timeout">Die Zeitdauer in Millisekunden, für die die SprechblasenInfo angezeigt werden soll.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout"/> ist kleiner als 0.</exception>
        public void ShowBalloonTip(int timeout)
        {
            m_orgIcon.ShowBalloonTip(timeout);
        }

        /// <summary>
        /// Zeigt für den angegebenen Zeitraum in der Taskleiste eine QuickInfo-Sprechblase mit dem angegebenen Titel, Text und Symbol an.
        /// </summary>
        /// <param name="timeout">Die Zeitdauer in Millisekunden, für die die SprechblasenInfo angezeigt werden soll.</param><param name="tipTitle">Der Titel, der in der SprechblasenInfo angezeigt werden soll.</param><param name="tipText">Der Text, der in der SprechblasenInfo angezeigt werden soll.</param><param name="tipIcon">Einer der <see cref="T:System.Windows.Forms.ToolTipIcon"/>-Werte.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="timeout"/> ist kleiner als 0.</exception><exception cref="T:System.ArgumentException"><paramref name="tipText"/> ist null oder eine leere Zeichenfolge.</exception><exception cref="T:System.ComponentModel.InvalidEnumArgumentException"><paramref name="tipIcon"/> ist kein Member von <see cref="T:System.Windows.Forms.ToolTipIcon"/>.</exception>
        public void ShowBalloonTip(int timeout, string tipTitle, string tipText, ToolTipIcon tipIcon)
        {
            m_orgIcon.ShowBalloonTip(timeout, tipTitle, tipText, tipIcon);
        }

        /// <summary>
        /// Ruft den Text ab oder legt den Text fest, der in der mit <see cref="T:System.Windows.Forms.NotifyIcon"/> verknüpften QuickInfo-Sprechblase angezeigt wird.
        /// </summary>
        /// <returns>
        /// Der Text, der in der SprechblasenInfo angezeigt wird, die dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnet ist.
        /// </returns>
        public string BalloonTipText
        {
            get { return m_orgIcon.BalloonTipText; }
            set { m_orgIcon.BalloonTipText = value; }
        }

        /// <summary>
        /// Ruft das Symbol ab oder legt das Symbol fest, das in der mit <see cref="T:INotifyIcon"/> verknüpften QuickInfo-Sprechblase angezeigt wird.
        /// </summary>
        /// <returns>
        /// Das <see cref="T:IToolTipIcon"/>, das in der SprechblasenInfo angezeigt wird, die dem <see cref="T:INotifyIcon"/> zugeordnet ist.
        /// </returns>
        /// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">Die angegebene Komponente ist kein <see cref="T:IToolTipIcon"/>.</exception>
        public IToolTipIcon BalloonTipIcon
        {
            get { return new ToolTipIconWrapper(m_orgIcon.BalloonTipIcon); }
            set { m_orgIcon.BalloonTipIcon = ((IProvideOrgToolTipIcon)value).OrgIcon; }
        }

        /// <summary>
        /// Ruft den Titel der QuickInfo-Sprechblase ab, der für <see cref="T:System.Windows.Forms.NotifyIcon"/> angezeigt wird, oder legt ihn fest.
        /// </summary>
        /// <returns>
        /// Der Text, der als Titel der SprechblasenInfo angezeigt werden soll.
        /// </returns>
        public string BalloonTipTitle
        {
            get { return m_orgIcon.BalloonTipTitle; }
            set { m_orgIcon.BalloonTipTitle = value; }
        }

        /// <summary>
        /// Ruft das Kontextmenü für das Symbol ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das <see cref="T:System.Windows.Forms.ContextMenu"/> für das Symbol. Der Standardwert ist null.
        /// </returns>
        public IContextMenu ContextMenu
        {
            get { return new ContextMenuWrapper(m_orgIcon.ContextMenu); }
            set { m_orgIcon.ContextMenu = ((IProvideOrgContextMenu)value).OrgMenu; }
        }

        /// <summary>
        /// Ruft das dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnete Kontextmenü ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das dem <see cref="T:System.Windows.Forms.NotifyIcon"/> zugeordnete <see cref="T:System.Windows.Forms.ContextMenuStrip"/>.
        /// </returns>
        public IContextMenuStrip ContextMenuStrip
        {
            get { return new ContextMenuStripWrapper(m_orgIcon.ContextMenuStrip); }
            set { m_orgIcon.ContextMenuStrip = ((IProvideOrgContextMenuStrip)value).OrgStrip; }
        }

        /// <summary>
        /// Ruft das aktuelle Symbol ab oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Das <see cref="T:System.Drawing.Icon"/>, das von der <see cref="T:System.Windows.Forms.NotifyIcon"/>-Komponente angezeigt wird. Der Standardwert ist null.
        /// </returns>
        public IIcon Icon
        {
            get { return new IconWrapper(m_orgIcon.Icon); }
            set { m_orgIcon.Icon = ((IProvideOrgIcon)value).OrgIcon; }
        }

        /// <summary>
        /// Ruft den QuickInfo-Text ab, der angezeigt wird, wenn mit dem Mauszeiger auf ein Symbol im Statusbereich gezeigt wird, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Der QuickInfo-Text, der angezeigt wird, wenn mit dem Mauszeiger auf ein Symbol im Statusbereich gezeigt wird.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">Der QuickInfo-Text ist mehr als 63 Zeichen lang.</exception><PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/><IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        public string Text
        {
            get { return m_orgIcon.Text; }
            set { m_orgIcon.Text = value; }
        }

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob das Symbol im Statusbereich der Taskleiste sichtbar ist, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// true, wenn das Symbol im Statusbereich sichtbar ist, andernfalls false. Der Standardwert ist false.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence"/><IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        public bool Visible
        {
            get { return m_orgIcon.Visible; }
            set { m_orgIcon.Visible = value; }
        }

        /// <summary>
        /// Ruft ein Objekt ab, das Daten über das <see cref="T:System.Windows.Forms.NotifyIcon"/> enthält, oder legt dieses fest.
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.Object"/>, das Daten über das <see cref="T:System.Windows.Forms.NotifyIcon"/> enthält.
        /// </returns>
        public object Tag
        {
            get { return m_orgIcon.Tag; }
            set { m_orgIcon.Tag = value; }
        }

        public event EventHandler BalloonTipClicked
        {
            add { m_orgIcon.BalloonTipClicked += value; }
            remove { m_orgIcon.BalloonTipClicked -= value; }
        }

        public event EventHandler BalloonTipClosed
        {
            add { m_orgIcon.BalloonTipClosed += value; }
            remove { m_orgIcon.BalloonTipClosed -= value; }
        }

        public event EventHandler BalloonTipShown
        {
            add { m_orgIcon.BalloonTipShown += value; }
            remove { m_orgIcon.BalloonTipShown -= value; }
        }

        public event EventHandler Click
        {
            add { m_orgIcon.Click += value; }
            remove { m_orgIcon.Click -= value; }
        }

        public event EventHandler DoubleClick
        {
            add { m_orgIcon.DoubleClick += value; }
            remove { m_orgIcon.DoubleClick -= value; }
        }

        public event MouseEventHandler MouseClick
        {
            add { m_orgIcon.MouseClick += value; }
            remove { m_orgIcon.MouseClick -= value; }
        }

        public event MouseEventHandler MouseDoubleClick
        {
            add { m_orgIcon.MouseDoubleClick += value; }
            remove { m_orgIcon.MouseDoubleClick -= value; }
        }

        public event MouseEventHandler MouseDown
        {
            add { m_orgIcon.MouseDown += value; }
            remove { m_orgIcon.MouseDown -= value; }
        }

        public event MouseEventHandler MouseMove
        {
            add { m_orgIcon.MouseMove += value; }
            remove { m_orgIcon.MouseMove -= value; }
        }

        public event MouseEventHandler MouseUp
        {
            add { m_orgIcon.MouseUp += value; }
            remove { m_orgIcon.MouseUp -= value; }
        }

        private readonly NotifyIcon m_orgIcon;

        public NotifyIconWrapper(NotifyIcon orgIcon)
        {
            m_orgIcon = orgIcon;
        }
    }
}