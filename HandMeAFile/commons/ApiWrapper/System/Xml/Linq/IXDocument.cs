using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq
{
    public interface IXDocument
    {
        /// <summary>Ruft einen Wert ab, der angibt, ob die Klasse Zeileninformationen zur�ckgeben kann.</summary>
        /// <returns>true, wenn <see cref="P:System.Xml.IXmlLineInfo.LineNumber" /> und <see cref="P:System.Xml.IXmlLineInfo.LinePosition" /> angegeben werden k�nnen, andernfalls false.</returns>
        bool HasLineInfo();

        /// <summary>Ruft die aktuelle Zeilennummer ab.</summary>
        /// <returns>Die aktuelle Zeilennummer oder 0, wenn keine Zeileninformationen vorliegen (z.�B. gibt <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" />false zur�ck).</returns>
        int LineNumber { get; }

        /// <summary>Ruft die aktuelle Zeilenposition ab.</summary>
        /// <returns>Die aktuelle Zeilenposition oder 0, wenn keine Zeileninformationen vorliegen (z.�B. gibt <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" />false zur�ck).</returns>
        int LinePosition { get; }

        /// <summary>Ruft den Basis-URI f�r dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Ein <see cref="T:System.String" />, der den Basis-URI f�r dieses <see cref="T:System.Xml.Linq.XObject" /> enth�lt.</returns>
        string BaseUri { get; }

        /// <summary>Ruft das <see cref="T:System.Xml.Linq.XDocument" /> f�r dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Das <see cref="T:System.Xml.Linq.XDocument" /> f�r dieses <see cref="T:System.Xml.Linq.XObject" />.</returns>
        XDocument Document { get; }

        /// <summary>Ruft das �bergeordnete <see cref="T:System.Xml.Linq.XElement" /> dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Das �bergeordnete <see cref="T:System.Xml.Linq.XElement" /> dieses <see cref="T:System.Xml.Linq.XObject" />.</returns>
        XElement Parent { get; }

        /// <summary>Ruft den n�chsten nebengeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Der <see cref="T:System.Xml.Linq.XNode" />, der den n�chsten nebengeordneten Knoten enth�lt.</returns>
        XNode NextNode { get; }

        /// <summary>Ruft den vorherigen nebengeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Der <see cref="T:System.Xml.Linq.XNode" />, der den vorherigen nebengeordneten Knoten enth�lt.</returns>
        XNode PreviousNode { get; }

        /// <summary>Ruft den ersten untergeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der den ersten untergeordneten Knoten des <see cref="T:System.Xml.Linq.XContainer" /> enth�lt.</returns>
        XNode FirstNode { get; }

        /// <summary>Ruft den letzten untergeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der den letzten untergeordneten Knoten des <see cref="T:System.Xml.Linq.XContainer" /> enth�lt.</returns>
        XNode LastNode { get; }
        
        /// <summary>Ruft das IXDocument als Node ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der dieses Document als <see cref="T:System.Xml.Linq.XContainer" /> repr�sentiert.</returns>
        XContainer IdentityNode { get; }

        /// <summary>Ruft die XML-Deklaration f�r das Dokument ab oder legt diese fest.</summary>
        /// <returns>Eine <see cref="T:System.Xml.Linq.XDeclaration" />, die die XML-Deklaration f�r dieses Dokument enth�lt.</returns>
        XDeclaration Declaration { get; set; }

        /// <summary>Ruft die Dokumenttypdefinition (DTD) f�r dieses Dokument ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XDocumentType" />, der die DTD f�r dieses Dokument enth�lt.</returns>
        XDocumentType DocumentType { get; }

        /// <summary>Ruft den Knotentyp f�r diesen Knoten ab.</summary>
        /// <returns>Der Knotentyp. F�r <see cref="T:System.Xml.Linq.XDocument" />-Objekte ist dieser Wert <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
        XmlNodeType NodeType { get; }

        /// <summary>Ruft das Stammelement der XML-Struktur f�r dieses Dokument ab.</summary>
        /// <returns>Das Stamm-<see cref="T:System.Xml.Linq.XElement" /> der XML-Struktur.</returns>
        XElement Root { get; }

        event EventHandler<XObjectChangeEventArgs> Changed;
        event EventHandler<XObjectChangeEventArgs> Changing;

        /// <summary>F�gt den angegebenen Inhalt unmittelbar hinter diesem Knoten hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die hinter diesem Knoten hinzugef�gt werden sollen.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        void AddAfterSelf(object content);

        /// <summary>F�gt den angegebenen Inhalt unmittelbar hinter diesem Knoten hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        void AddAfterSelf(params object[] content);

        /// <summary>F�gt den angegebenen Inhalt direkt vor diesem Knoten hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die vor diesem Knoten hinzugef�gt werden sollen.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        void AddBeforeSelf(object content);

        /// <summary>F�gt den angegebenen Inhalt direkt vor diesem Knoten hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        void AddBeforeSelf(params object[] content);

        /// <summary>Gibt eine Auflistung der �bergeordneten Elemente dieses Knotens zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der �bergeordneten Elemente dieses Knotens.</returns>
        IEnumerable<XElement> Ancestors();

        /// <summary>Gibt eine gefilterte Auflistung der �bergeordneten Elemente dieses Knotens zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der �bergeordneten Elemente dieses Knotens. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten. Die Knoten in der zur�ckgegebenen Auflistung sind in der umgekehrten Dokumentreihenfolge angeordnet. Diese Methode verwendet verz�gerte Ausf�hrung.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> Ancestors(XName name);

        /// <summary>Gibt eine Auflistung der nebengeordneten Knoten nach diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" /> der nebengeordneten Knoten nach diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XNode> NodesAfterSelf();

        /// <summary>Gibt eine Auflistung der nebengeordneten Knoten vor diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" /> der nebengeordneten Knoten vor diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XNode> NodesBeforeSelf();

        /// <summary>Gibt eine Auflistung der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XElement> ElementsAfterSelf();

        /// <summary>Gibt eine gefilterte Auflistung der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> ElementsAfterSelf(XName name);

        /// <summary>Gibt eine Auflistung der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XElement> ElementsBeforeSelf();

        /// <summary>Gibt eine gefilterte Auflistung der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> ElementsBeforeSelf(XName name);

        /// <summary>Bestimmt, ob der aktuelle Knoten nach einem angegebenen Knoten in der Dokumentreihenfolge angezeigt wird.</summary>
        /// <returns>true, wenn dieser Knoten nach dem angegebenen Knoten angezeigt wird, andernfalls false.</returns>
        /// <param name="node">Der <see cref="T:System.Xml.Linq.XNode" />, dessen Dokumentreihenfolge verglichen werden soll.</param>
        bool IsAfter(XNode node);

        /// <summary>Bestimmt, ob der aktuelle Knoten vor einem angegebenen Knoten in der Dokumentreihenfolge angezeigt wird.</summary>
        /// <returns>true, wenn dieser Knoten vor dem angegebenen Knoten angezeigt wird, andernfalls false.</returns>
        /// <param name="node">Der <see cref="T:System.Xml.Linq.XNode" />, dessen Dokumentreihenfolge verglichen werden soll.</param>
        bool IsBefore(XNode node);

        /// <summary>Entfernt diesen Knoten aus seinem �bergeordneten Element.</summary>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        void Remove();

        /// <summary>Ersetzt diesen Knoten durch den angegebenen Inhalt.</summary>
        /// <param name="content">Inhalt, durch den dieser Knoten ersetzt wird.</param>
        void ReplaceWith(object content);

        /// <summary>Ersetzt diesen Knoten durch den angegebenen Inhalt.</summary>
        /// <param name="content">Eine Parameterliste des neuen Inhalts.</param>
        void ReplaceWith(params object[] content);

        /// <summary>Gibt das XML f�r diesen Knoten zur�ck, wobei optional die Formatierung deaktiviert wird.</summary>
        /// <returns>Ein <see cref="T:System.String" /> mit dem XML.</returns>
        /// <param name="options">Ein <see cref="T:System.Xml.Linq.SaveOptions" />, das Formatierungsverhalten angibt.</param>
        string ToString(SaveOptions options);

        /// <summary>F�gt den angegebenen Inhalt als untergeordnete Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die hinzugef�gt werden sollen.</param>
        void Add(object content);

        /// <summary>F�gt den angegebenen Inhalt als untergeordnete Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        void Add(params object[] content);

        /// <summary>F�gt den angegebenen Inhalt als erste untergeordnete Elemente dieses Dokuments oder Elements hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die hinzugef�gt werden sollen.</param>
        void AddFirst(object content);

        /// <summary>F�gt den angegebenen Inhalt als erste untergeordnete Elemente dieses Dokuments oder Elements hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das �bergeordnete Element ist null.</exception>
        void AddFirst(params object[] content);

        /// <summary>Erstellt einen <see cref="T:System.Xml.XmlWriter" />, der zum Hinzuf�gen von Knoten zu dem <see cref="T:System.Xml.Linq.XContainer" /> verwendet werden kann.</summary>
        /// <returns>Ein <see cref="T:System.Xml.XmlWriter" />, in den Inhalt geschrieben werden kann.</returns>
        XmlWriter CreateWriter();

        /// <summary>Gibt eine Auflistung der Nachfolgerknoten f�r dieses Dokument oder Element in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" />, das die Nachfolgerknoten des <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enth�lt.</returns>
        IEnumerable<XNode> DescendantNodes();

        /// <summary>Gibt eine Auflistung der Nachfolgerelemente f�r dieses Dokument oder Element in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> mit den Nachfolgerelementen des <see cref="T:System.Xml.Linq.XContainer" />.</returns>
        IEnumerable<XElement> Descendants();

        /// <summary>Gibt eine gefilterte Auflistung der Nachfolgerelemente f�r dieses Dokument oder Element in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die Nachfolgerelemente des <see cref="T:System.Xml.Linq.XContainer" /> enth�lt, die mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> �bereinstimmen.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> Descendants(XName name);

        /// <summary>Ruft das erste (in Dokumentreihenfolge) untergeordnete Element mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XElement" />, das mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> �bereinstimmt, oder null.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        XElement Element(XName name);

        /// <summary>Gibt eine Auflistung der untergeordneten Elemente dieses Dokuments oder Elements in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die untergeordneten Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enth�lt.</returns>
        IEnumerable<XElement> Elements();

        /// <summary>Gibt eine gefilterte Auflistung der untergeordneten Elemente dieses Dokuments oder Elements in Dokumentreihenfolge zur�ck. Nur Elemente, die �ber einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verf�gen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die untergeordneten Elemente des <see cref="T:System.Xml.Linq.XContainer" />, die einen �bereinstimmenden <see cref="T:System.Xml.Linq.XName" /> aufweisen, in Dokumentreihenfolge enth�lt.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine �bereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> Elements(XName name);

        /// <summary>Gibt eine Auflistung der untergeordneten Knoten dieses Dokuments oder Elements in Dokumentreihenfolge zur�ck.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" />, das die Inhalte dieses <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enth�lt.</returns>
        IEnumerable<XNode> Nodes();

        /// <summary>Entfernt die untergeordneten Knoten aus diesem Dokument oder Element.</summary>
        void RemoveNodes();

        /// <summary>Ersetzt die untergeordneten Knoten dieses Dokuments oder Elements durch den angegebenen Inhalt.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enth�lt, die die untergeordneten Knoten ersetzen.</param>
        void ReplaceNodes(object content);

        /// <summary>Ersetzt die untergeordneten Knoten dieses Dokuments oder Elements durch den angegebenen Inhalt.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        void ReplaceNodes(params object[] content);

        /// <summary>Serialisieren Sie dieses <see cref="T:System.Xml.Linq.XDocument" /> in eine Datei, und �berschreiben Sie dabei eine vorhandene Datei, sofern vorhanden.</summary>
        /// <param name="fileName">Eine Zeichenfolge, die den Namen der Datei enth�lt.</param>
        void Save(string fileName);

        /// <summary>Serialisiert dieses <see cref="T:System.Xml.Linq.XDocument" /> in eine Datei, wobei optional die Formatierung deaktiviert wird.</summary>
        /// <param name="fileName">Eine Zeichenfolge, die den Namen der Datei enth�lt.</param>
        /// <param name="options">Ein <see cref="T:System.Xml.Linq.SaveOptions" />, das Formatierungsverhalten angibt.</param>
        void Save(string fileName, SaveOptions options);
    }
}