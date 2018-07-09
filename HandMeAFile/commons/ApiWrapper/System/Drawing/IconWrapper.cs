using System;
using System.Drawing;
using org.ek.HandMeAFile.commons.ApiWrapper.System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Drawing
{
    public class IconWrapper : IIcon, IProvideOrgIcon
    {
        /// <summary>Klont das <see cref="T:System.Drawing.Icon" />, wodurch ein Bildduplikat erstellt wird.</summary>
        /// <returns>Ein Objekt, das in ein <see cref="T:System.Drawing.Icon" /> umgewandelt werden kann.</returns>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
        /// </PermissionSet>
        public object Clone()
        {
            return new IconWrapper((Icon)m_orgIcon.Clone());
        }

        /// <summary>Gibt alle von diesem <see cref="T:System.Drawing.Icon" /> verwendeten Ressourcen frei.</summary>
        public void Dispose()
        {
            m_orgIcon.Dispose();
        }

        /// <summary>Speichert dieses <see cref="T:System.Drawing.Icon" /> im angegebenen Ausgabe-<see cref="T:System.IO.Stream" />.</summary>
        /// <param name="outputStream">Die <see cref="T:System.IO.Stream" /> für den Speichervorgang.</param>
        public void Save(IStream outputStream)
        {
            m_orgIcon.Save(((IProvideOrgStream)outputStream).OrgStream);
        }

        /// <summary>Konvertiert dieses <see cref="T:System.Drawing.Icon" /> in eine GDI+-<see cref="T:IBitmap" />.</summary>
        /// <returns>Eine <see cref="T:System.Drawing.Bitmap" />, die das konvertierte <see cref="T:IIcon" /> darstellt.</returns>
        /// <PermissionSet>
        ///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
        /// </PermissionSet>
        public IBitmap ToBitmap()
        {
            return new BitmapWrapper(m_orgIcon.ToBitmap());
        }

        /// <summary>Ruft das Windows-Handle für dieses <see cref="T:System.Drawing.Icon" /> ab. Dies ist keine Kopie des Handles. Geben Sie es nicht frei.</summary>
        /// <returns>Das Windows-Handle für das Symbol.</returns>
        public IntPtr Handle => m_orgIcon.Handle;

        /// <summary>Ruft die Höhe dieses <see cref="T:System.Drawing.Icon" /> ab.</summary>
        /// <returns>Die Höhe dieses <see cref="T:System.Drawing.Icon" />.</returns>
        public int Height => m_orgIcon.Height;

        /// <summary>Ruft die Größe dieses <see cref="T:System.Drawing.Icon" /> ab.</summary>
        /// <returns>Eine <see cref="T:System.Drawing.Size" />-Struktur, die die Breite und Höhe dieses <see cref="T:System.Drawing.Icon" /> angibt.</returns>
        public Size Size => m_orgIcon.Size;

        /// <summary>Ruft die Breite dieses <see cref="T:System.Drawing.Icon" /> ab.</summary>
        /// <returns>Die Breite dieses <see cref="T:System.Drawing.Icon" />.</returns>
        public int Width => m_orgIcon.Width;

        private readonly Icon m_orgIcon;
        public Icon OrgIcon => m_orgIcon;

        public IconWrapper(Icon orgIcon)
        {
            m_orgIcon = orgIcon;
        }

        
    }
}