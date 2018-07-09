using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq
{
    public class XDocumentWrapper : IXDocument
    {
        /// <summary>Ruft einen Wert ab, der angibt, ob die Klasse Zeileninformationen zur�ckgeben kann.</summary>
        /// <returns>true, wenn <see cref="P:System.Xml.IXmlLineInfo.LineNumber" /> und <see cref="P:System.Xml.IXmlLineInfo.LinePosition" /> angegeben werden k�nnen, andernfalls false.</returns>
        public bool HasLineInfo()
        {
            return ((IXmlLineInfo) m_orgDocument).HasLineInfo();
        }

        /// <summary>Ruft die aktuelle Zeilennummer ab.</summary>
        /// <returns>Die aktuelle Zeilennummer oder 0, wenn keine Zeileninformationen vorliegen (z.�B. gibt <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" />false zur�ck).</returns>
        public int LineNumber
        {
            get { return ((global::System.Xml.IXmlLineInfo) m_orgDocument).LineNumber; }
        }

        /// <summary>Ruft die aktuelle Zeilenposition ab.</summary>
        /// <returns>Die aktuelle Zeilenposition oder 0, wenn keine Zeileninformationen vorliegen (z.�B. gibt <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" />false zur�ck).</returns>
        public int LinePosition
        {
            get { return ((global::System.Xml.IXmlLineInfo) m_orgDocument).LinePosition; }
        }

        /// <summary>Ruft den Basis-URI f�r dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Ein <see cref="T:System.String" />, der den Basis-URI f�r dieses <see cref="T:System.Xml.Linq.XObject" /> enth�lt.</returns>
        public string BaseUri
        {
            get { return m_orgDocument.BaseUri; }
        }

        /// <summary>Ruft das <see cref="T:System.Xml.Linq.XDocument" /> f�r dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Das <see cref="T:System.Xml.Linq.XDocument" /> f�r dieses <see cref="T:System.Xml.Linq.XObject" />.</returns>
        public XDocument Document
        {
            get { return m_orgDocument.Document; }
        }

        /// <summary>Ruft das �bergeordnete <see cref="T:System.Xml.Linq.XElement" /> dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Das �bergeordnete <see cref="T:System.Xml.Linq.XElement" /> dieses <see cref="T:System.Xml.Linq.XObject" />.</returns>
        public XElement Parent
        {
            get { return m_orgDocument.Parent; }
        }

        public event EventHandler<XObjectChangeEventArgs> Changed
        {
            add { m_orgDocument.Changed += value; }
            remove { m_orgDocument.Changed -= value; }
        }

        public event EventHandler<XObjectChangeEventArgs> Changing
        {
            add { m_orgDocument.Changing += value; }
            remove { m_orgDocument.Changing -= value; }
        }

        /// <summary>F�gt den angegebenen Inhalt unmittelbar hinter diesem Knoten hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die hinter diesem Knoten hinzugef�gt werden sollen.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        public void AddAfterSelf(object content)
        {
            m_orgDocument.AddAfterSelf(content);
        }

        /// <summary>F�gt den angegebenen Inhalt unmittelbar hinter diesem Knoten hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        public void AddAfterSelf(params object[] content)
        {
            m_orgDocument.AddAfterSelf(content);
        }

        /// <summary>F�gt den angegebenen Inhalt direkt vor diesem Knoten hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die vor diesem Knoten hinzugef�gt werden sollen.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        public void AddBeforeSelf(object content)
        {
            m_orgDocument.AddBeforeSelf(content);
        }

        /// <summary>F�gt den angegebenen Inhalt direkt vor diesem Knoten hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        public void AddBeforeSelf(params object[] content)
        {
            m_orgDocument.AddBeforeSelf(content);
        }

        /// <summary>Gibt eine Auflistung der �bergeordneten Elemente dieses Knotens zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der �bergeordneten Elemente dieses Knotens.</returns>
        public IEnumerable<XElement> Ancestors()
        {
            return m_orgDocument.Ancestors();
        }

        /// <summary>Gibt eine gefilterte Auflistung der �bergeordneten Elemente dieses Knotens zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der �bergeordneten Elemente dieses Knotens. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten. Die Knoten in der zur�ckgegebenen Auflistung sind in der umgekehrten Dokumentreihenfolge angeordnet. Diese Methode verwendet verz�gerte Ausf�hrung.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        public IEnumerable<XElement> Ancestors(XName name)
        {
            return m_orgDocument.Ancestors(name);
        }

        /// <summary>Gibt eine Auflistung der nebengeordneten Knoten nach diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" /> der nebengeordneten Knoten nach diesem Knoten in Dokumentreihenfolge.</returns>
        public IEnumerable<XNode> NodesAfterSelf()
        {
            return m_orgDocument.NodesAfterSelf();
        }

        /// <summary>Gibt eine Auflistung der nebengeordneten Knoten vor diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" /> der nebengeordneten Knoten vor diesem Knoten in Dokumentreihenfolge.</returns>
        public IEnumerable<XNode> NodesBeforeSelf()
        {
            return m_orgDocument.NodesBeforeSelf();
        }

        /// <summary>Gibt eine Auflistung der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge.</returns>
        public IEnumerable<XElement> ElementsAfterSelf()
        {
            return m_orgDocument.ElementsAfterSelf();
        }

        /// <summary>Gibt eine gefilterte Auflistung der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        public IEnumerable<XElement> ElementsAfterSelf(XName name)
        {
            return m_orgDocument.ElementsAfterSelf(name);
        }

        /// <summary>Gibt eine Auflistung der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge.</returns>
        public IEnumerable<XElement> ElementsBeforeSelf()
        {
            return m_orgDocument.ElementsBeforeSelf();
        }

        /// <summary>Gibt eine gefilterte Auflistung der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        public IEnumerable<XElement> ElementsBeforeSelf(XName name)
        {
            return m_orgDocument.ElementsBeforeSelf(name);
        }

        /// <summary>Bestimmt, ob der aktuelle Knoten nach einem angegebenen Knoten in der Dokumentreihenfolge angezeigt wird.</summary>
        /// <returns>true, wenn dieser Knoten nach dem angegebenen Knoten angezeigt wird, andernfalls false.</returns>
        /// <param name="node">Der <see cref="T:System.Xml.Linq.XNode" />, dessen Dokumentreihenfolge verglichen werden soll.</param>
        public bool IsAfter(XNode node)
        {
            return m_orgDocument.IsAfter(node);
        }

        /// <summary>Bestimmt, ob der aktuelle Knoten vor einem angegebenen Knoten in der Dokumentreihenfolge angezeigt wird.</summary>
        /// <returns>true, wenn dieser Knoten vor dem angegebenen Knoten angezeigt wird, andernfalls false.</returns>
        /// <param name="node">Der <see cref="T:System.Xml.Linq.XNode" />, dessen Dokumentreihenfolge verglichen werden soll.</param>
        public bool IsBefore(XNode node)
        {
            return m_orgDocument.IsBefore(node);
        }

        /// <summary>Entfernt diesen Knoten aus seinem �bergeordneten Element.</summary>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        public void Remove()
        {
            m_orgDocument.Remove();
        }

        /// <summary>Ersetzt diesen Knoten durch den angegebenen Inhalt.</summary>
        /// <param name="content">Inhalt, durch den dieser Knoten ersetzt wird.</param>
        public void ReplaceWith(object content)
        {
            m_orgDocument.ReplaceWith(content);
        }

        /// <summary>Ersetzt diesen Knoten durch den angegebenen Inhalt.</summary>
        /// <param name="content">Eine Parameterliste des neuen Inhalts.</param>
        public void ReplaceWith(params object[] content)
        {
            m_orgDocument.ReplaceWith(content);
        }

        /// <summary>Gibt das XML f�r diesen Knoten zur�ck, wobei optional die Formatierung deaktiviert wird.</summary>
        /// <returns>Ein <see cref="T:System.String" /> mit dem XML.</returns>
        /// <param name="options">Ein <see cref="T:System.Xml.Linq.SaveOptions" />, das Formatierungsverhalten angibt.</param>
        public string ToString(SaveOptions options)
        {
            return m_orgDocument.ToString(options);
        }

        /// <summary>Ruft den n�chsten nebengeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Der <see cref="T:System.Xml.Linq.XNode" />, der den n�chsten nebengeordneten Knoten enth�lt.</returns>
        public XNode NextNode
        {
            get { return m_orgDocument.NextNode; }
        }

        /// <summary>Ruft den vorherigen nebengeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Der <see cref="T:System.Xml.Linq.XNode" />, der den vorherigen nebengeordneten Knoten enth�lt.</returns>
        public XNode PreviousNode
        {
            get { return m_orgDocument.PreviousNode; }
        }

        /// <summary>F�gt den angegebenen Inhalt als untergeordnete Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die hinzugef�gt werden sollen.</param>
        public void Add(object content)
        {
            m_orgDocument.Add(content);
        }

        /// <summary>F�gt den angegebenen Inhalt als untergeordnete Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        public void Add(params object[] content)
        {
            m_orgDocument.Add(content);
        }

        /// <summary>F�gt den angegebenen Inhalt als erste untergeordnete Elemente dieses Dokuments oder Elements hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die hinzugef�gt werden sollen.</param>
        public void AddFirst(object content)
        {
            m_orgDocument.AddFirst(content);
        }

        /// <summary>F�gt den angegebenen Inhalt als erste untergeordnete Elemente dieses Dokuments oder Elements hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        public void AddFirst(params object[] content)
        {
            m_orgDocument.AddFirst(content);
        }

        /// <summary>Erstellt einen <see cref="T:System.Xml.XmlWriter" />, der zum Hinzuf�gen von Knoten zu dem <see cref="T:System.Xml.Linq.XContainer" /> verwendet werden kann.</summary>
        /// <returns>Ein <see cref="T:System.Xml.XmlWriter" />, in den Inhalt geschrieben werden kann.</returns>
        public XmlWriter CreateWriter()
        {
            return m_orgDocument.CreateWriter();
        }

        /// <summary>Gibt eine Auflistung der Nachfolgerknoten f�r dieses Dokument oder Element in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" />, das die Nachfolgerknoten des <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enth�lt.</returns>
        public IEnumerable<XNode> DescendantNodes()
        {
            return m_orgDocument.DescendantNodes();
        }

        /// <summary>Gibt eine Auflistung der Nachfolgerelemente f�r dieses Dokument oder Element in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> mit den Nachfolgerelementen des <see cref="T:System.Xml.Linq.XContainer" />.</returns>
        public IEnumerable<XElement> Descendants()
        {
            return m_orgDocument.Descendants();
        }

        /// <summary>Gibt eine gefilterte Auflistung der Nachfolgerelemente f�r dieses Dokument oder Element in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die Nachfolgerelemente des <see cref="T:System.Xml.Linq.XContainer" /> enth�lt, die mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> �bereinstimmen.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        public IEnumerable<XElement> Descendants(XName name)
        {
            return m_orgDocument.Descendants(name);
        }

        /// <summary>Ruft das erste (in Dokumentreihenfolge) untergeordnete Element mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XElement" />, das mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> �bereinstimmt, oder null.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        public XElement Element(XName name)
        {
            return m_orgDocument.Element(name);
        }

        /// <summary>Gibt eine Auflistung der untergeordneten Elemente dieses Dokuments oder Elements in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die untergeordneten Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enth�lt.</returns>
        public IEnumerable<XElement> Elements()
        {
            return m_orgDocument.Elements();
        }

        /// <summary>Gibt eine gefilterte Auflistung der untergeordneten Elemente dieses Dokuments oder Elements in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die untergeordneten Elemente des <see cref="T:System.Xml.Linq.XContainer" />, die einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> aufweisen, in Dokumentreihenfolge enth�lt.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        public IEnumerable<XElement> Elements(XName name)
        {
            return m_orgDocument.Elements(name);
        }

        /// <summary>Gibt eine Auflistung der untergeordneten Knoten dieses Dokuments oder Elements in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" />, das die Inhalte dieses <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enth�lt.</returns>
        public IEnumerable<XNode> Nodes()
        {
            return m_orgDocument.Nodes();
        }

        /// <summary>Entfernt die untergeordneten Knoten aus diesem Dokument oder Element.</summary>
        public void RemoveNodes()
        {
            m_orgDocument.RemoveNodes();
        }

        /// <summary>Ersetzt die untergeordneten Knoten dieses Dokuments oder Elements durch den angegebenen Inhalt.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die die untergeordneten Knoten ersetzen.</param>
        public void ReplaceNodes(object content)
        {
            m_orgDocument.ReplaceNodes(content);
        }

        /// <summary>Ersetzt die untergeordneten Knoten dieses Dokuments oder Elements durch den angegebenen Inhalt.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        public void ReplaceNodes(params object[] content)
        {
            m_orgDocument.ReplaceNodes(content);
        }

        /// <summary>Ruft den ersten untergeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der den ersten untergeordneten Knoten des <see cref="T:System.Xml.Linq.XContainer" /> enth�lt.</returns>
        public XNode FirstNode
        {
            get { return m_orgDocument.FirstNode; }
        }

        /// <summary>Ruft den letzten untergeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der den letzten untergeordneten Knoten des <see cref="T:System.Xml.Linq.XContainer" /> enth�lt.</returns>
        public XNode LastNode
        {
            get { return m_orgDocument.LastNode; }
        }

        /// <summary>Ruft das IXDocument als XContainer ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XContainer" />, der dieses Document als <see cref="T:System.Xml.Linq.XContainer" /> repr�sentiert.</returns>
        public XContainer IdentityNode => m_orgDocument;

        /// <summary>Serialisieren Sie dieses <see cref="T:System.Xml.Linq.XDocument" /> in eine Datei, und �berschreiben Sie dabei eine vorhandene Datei, sofern vorhanden.</summary>
        /// <param name="fileName">Eine Zeichenfolge, die den Namen der Datei enth�lt.</param>
        public void Save(string fileName)
        {
            m_orgDocument.Save(fileName);
        }

        /// <summary>Serialisiert dieses <see cref="T:System.Xml.Linq.XDocument" /> in eine Datei, wobei optional die Formatierung deaktiviert wird.</summary>
        /// <param name="fileName">Eine Zeichenfolge, die den Namen der Datei enth�lt.</param>
        /// <param name="options">Ein <see cref="T:System.Xml.Linq.SaveOptions" />, das Formatierungsverhalten angibt.</param>
        public void Save(string fileName, SaveOptions options)
        {
            m_orgDocument.Save(fileName, options);
        }

        /// <summary>Ruft die XML-Deklaration f�r das Dokument ab oder legt diese fest.</summary>
        /// <returns>Eine <see cref="T:System.Xml.Linq.XDeclaration" />, die die XML-Deklaration f�r dieses Dokument enth�lt.</returns>
        public XDeclaration Declaration
        {
            get { return m_orgDocument.Declaration; }
            set { m_orgDocument.Declaration = value; }
        }

        /// <summary>Ruft die Dokumenttypdefinition (DTD) f�r dieses Dokument ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XDocumentType" />, der die DTD f�r dieses Dokument enth�lt.</returns>
        public XDocumentType DocumentType
        {
            get { return m_orgDocument.DocumentType; }
        }

        /// <summary>Ruft den Knotentyp f�r diesen Knoten ab.</summary>
        /// <returns>Der Knotentyp. F�r <see cref="T:System.Xml.Linq.XDocument" />-Objekte ist dieser Wert <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
        public XmlNodeType NodeType
        {
            get { return m_orgDocument.NodeType; }
        }

        /// <summary>Ruft das Stammelement der XML-Struktur f�r dieses Dokument ab.</summary>
        /// <returns>Das Stamm-<see cref="T:System.Xml.Linq.XElement" /> der XML-Struktur.</returns>
        public XElement Root
        {
            get { return m_orgDocument.Root; }
        }

        private readonly XDocument m_orgDocument;

        public XDocumentWrapper(XDocument orgDocument)
        {
            m_orgDocument = orgDocument;
        }
    }
}