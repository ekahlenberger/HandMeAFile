using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Xml.Linq
{
    public interface IXDocument
    {
        /// <summary>Ruft einen Wert ab, der angibt, ob die Klasse Zeileninformationen zurückgeben kann.</summary>
        /// <returns>true, wenn <see cref="P:System.Xml.IXmlLineInfo.LineNumber" /> und <see cref="P:System.Xml.IXmlLineInfo.LinePosition" /> angegeben werden können, andernfalls false.</returns>
        bool HasLineInfo();

        /// <summary>Ruft die aktuelle Zeilennummer ab.</summary>
        /// <returns>Die aktuelle Zeilennummer oder 0, wenn keine Zeileninformationen vorliegen (z. B. gibt <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" />false zurück).</returns>
        int LineNumber { get; }

        /// <summary>Ruft die aktuelle Zeilenposition ab.</summary>
        /// <returns>Die aktuelle Zeilenposition oder 0, wenn keine Zeileninformationen vorliegen (z. B. gibt <see cref="M:System.Xml.IXmlLineInfo.HasLineInfo" />false zurück).</returns>
        int LinePosition { get; }

        /// <summary>Ruft den Basis-URI für dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Ein <see cref="T:System.String" />, der den Basis-URI für dieses <see cref="T:System.Xml.Linq.XObject" /> enthält.</returns>
        string BaseUri { get; }

        /// <summary>Ruft das <see cref="T:System.Xml.Linq.XDocument" /> für dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Das <see cref="T:System.Xml.Linq.XDocument" /> für dieses <see cref="T:System.Xml.Linq.XObject" />.</returns>
        XDocument Document { get; }

        /// <summary>Ruft das übergeordnete <see cref="T:System.Xml.Linq.XElement" /> dieses <see cref="T:System.Xml.Linq.XObject" /> ab.</summary>
        /// <returns>Das übergeordnete <see cref="T:System.Xml.Linq.XElement" /> dieses <see cref="T:System.Xml.Linq.XObject" />.</returns>
        XElement Parent { get; }

        /// <summary>Ruft den nächsten nebengeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Der <see cref="T:System.Xml.Linq.XNode" />, der den nächsten nebengeordneten Knoten enthält.</returns>
        XNode NextNode { get; }

        /// <summary>Ruft den vorherigen nebengeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Der <see cref="T:System.Xml.Linq.XNode" />, der den vorherigen nebengeordneten Knoten enthält.</returns>
        XNode PreviousNode { get; }

        /// <summary>Ruft den ersten untergeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der den ersten untergeordneten Knoten des <see cref="T:System.Xml.Linq.XContainer" /> enthält.</returns>
        XNode FirstNode { get; }

        /// <summary>Ruft den letzten untergeordneten Knoten dieses Knotens ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der den letzten untergeordneten Knoten des <see cref="T:System.Xml.Linq.XContainer" /> enthält.</returns>
        XNode LastNode { get; }
        
        /// <summary>Ruft das IXDocument als Node ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XNode" />, der dieses Document als <see cref="T:System.Xml.Linq.XContainer" /> repräsentiert.</returns>
        XContainer IdentityNode { get; }

        /// <summary>Ruft die XML-Deklaration für das Dokument ab oder legt diese fest.</summary>
        /// <returns>Eine <see cref="T:System.Xml.Linq.XDeclaration" />, die die XML-Deklaration für dieses Dokument enthält.</returns>
        XDeclaration Declaration { get; set; }

        /// <summary>Ruft die Dokumenttypdefinition (DTD) für dieses Dokument ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XDocumentType" />, der die DTD für dieses Dokument enthält.</returns>
        XDocumentType DocumentType { get; }

        /// <summary>Ruft den Knotentyp für diesen Knoten ab.</summary>
        /// <returns>Der Knotentyp. Für <see cref="T:System.Xml.Linq.XDocument" />-Objekte ist dieser Wert <see cref="F:System.Xml.XmlNodeType.Document" />.</returns>
        XmlNodeType NodeType { get; }

        /// <summary>Ruft das Stammelement der XML-Struktur für dieses Dokument ab.</summary>
        /// <returns>Das Stamm-<see cref="T:System.Xml.Linq.XElement" /> der XML-Struktur.</returns>
        XElement Root { get; }

        event EventHandler<XObjectChangeEventArgs> Changed;
        event EventHandler<XObjectChangeEventArgs> Changing;

        /// <summary>Fügt den angegebenen Inhalt unmittelbar hinter diesem Knoten hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enthält, die hinter diesem Knoten hinzugefügt werden sollen.</param>
        /// <exception cref="T:System.InvalidOperationException">Das übergeordnete Element ist null.</exception>
        void AddAfterSelf(object content);

        /// <summary>Fügt den angegebenen Inhalt unmittelbar hinter diesem Knoten hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das übergeordnete Element ist null.</exception>
        void AddAfterSelf(params object[] content);

        /// <summary>Fügt den angegebenen Inhalt direkt vor diesem Knoten hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enthält, die vor diesem Knoten hinzugefügt werden sollen.</param>
        /// <exception cref="T:System.InvalidOperationException">Das übergeordnete Element ist null.</exception>
        void AddBeforeSelf(object content);

        /// <summary>Fügt den angegebenen Inhalt direkt vor diesem Knoten hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das übergeordnete Element ist null.</exception>
        void AddBeforeSelf(params object[] content);

        /// <summary>Gibt eine Auflistung der übergeordneten Elemente dieses Knotens zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der übergeordneten Elemente dieses Knotens.</returns>
        IEnumerable<XElement> Ancestors();

        /// <summary>Gibt eine gefilterte Auflistung der übergeordneten Elemente dieses Knotens zurück. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der übergeordneten Elemente dieses Knotens. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten. Die Knoten in der zurückgegebenen Auflistung sind in der umgekehrten Dokumentreihenfolge angeordnet. Diese Methode verwendet verzögerte Ausführung.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine Übereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> Ancestors(XName name);

        /// <summary>Gibt eine Auflistung der nebengeordneten Knoten nach diesem Knoten in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" /> der nebengeordneten Knoten nach diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XNode> NodesAfterSelf();

        /// <summary>Gibt eine Auflistung der nebengeordneten Knoten vor diesem Knoten in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" /> der nebengeordneten Knoten vor diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XNode> NodesBeforeSelf();

        /// <summary>Gibt eine Auflistung der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XElement> ElementsAfterSelf();

        /// <summary>Gibt eine gefilterte Auflistung der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge zurück. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente nach diesem Knoten in Dokumentreihenfolge. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine Übereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> ElementsAfterSelf(XName name);

        /// <summary>Gibt eine Auflistung der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge.</returns>
        IEnumerable<XElement> ElementsBeforeSelf();

        /// <summary>Gibt eine gefilterte Auflistung der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge zurück. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> der nebengeordneten Elemente vor diesem Knoten in Dokumentreihenfolge. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine Übereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> ElementsBeforeSelf(XName name);

        /// <summary>Bestimmt, ob der aktuelle Knoten nach einem angegebenen Knoten in der Dokumentreihenfolge angezeigt wird.</summary>
        /// <returns>true, wenn dieser Knoten nach dem angegebenen Knoten angezeigt wird, andernfalls false.</returns>
        /// <param name="node">Der <see cref="T:System.Xml.Linq.XNode" />, dessen Dokumentreihenfolge verglichen werden soll.</param>
        bool IsAfter(XNode node);

        /// <summary>Bestimmt, ob der aktuelle Knoten vor einem angegebenen Knoten in der Dokumentreihenfolge angezeigt wird.</summary>
        /// <returns>true, wenn dieser Knoten vor dem angegebenen Knoten angezeigt wird, andernfalls false.</returns>
        /// <param name="node">Der <see cref="T:System.Xml.Linq.XNode" />, dessen Dokumentreihenfolge verglichen werden soll.</param>
        bool IsBefore(XNode node);

        /// <summary>Entfernt diesen Knoten aus seinem übergeordneten Element.</summary>
        /// <exception cref="T:System.InvalidOperationException">Das übergeordnete Element ist null.</exception>
        void Remove();

        /// <summary>Ersetzt diesen Knoten durch den angegebenen Inhalt.</summary>
        /// <param name="content">Inhalt, durch den dieser Knoten ersetzt wird.</param>
        void ReplaceWith(object content);

        /// <summary>Ersetzt diesen Knoten durch den angegebenen Inhalt.</summary>
        /// <param name="content">Eine Parameterliste des neuen Inhalts.</param>
        void ReplaceWith(params object[] content);

        /// <summary>Gibt das XML für diesen Knoten zurück, wobei optional die Formatierung deaktiviert wird.</summary>
        /// <returns>Ein <see cref="T:System.String" /> mit dem XML.</returns>
        /// <param name="options">Ein <see cref="T:System.Xml.Linq.SaveOptions" />, das Formatierungsverhalten angibt.</param>
        string ToString(SaveOptions options);

        /// <summary>Fügt den angegebenen Inhalt als untergeordnete Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enthält, die hinzugefügt werden sollen.</param>
        void Add(object content);

        /// <summary>Fügt den angegebenen Inhalt als untergeordnete Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        void Add(params object[] content);

        /// <summary>Fügt den angegebenen Inhalt als erste untergeordnete Elemente dieses Dokuments oder Elements hinzu.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enthält, die hinzugefügt werden sollen.</param>
        void AddFirst(object content);

        /// <summary>Fügt den angegebenen Inhalt als erste untergeordnete Elemente dieses Dokuments oder Elements hinzu.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        /// <exception cref="T:System.InvalidOperationException">Das übergeordnete Element ist null.</exception>
        void AddFirst(params object[] content);

        /// <summary>Erstellt einen <see cref="T:System.Xml.XmlWriter" />, der zum Hinzufügen von Knoten zu dem <see cref="T:System.Xml.Linq.XContainer" /> verwendet werden kann.</summary>
        /// <returns>Ein <see cref="T:System.Xml.XmlWriter" />, in den Inhalt geschrieben werden kann.</returns>
        XmlWriter CreateWriter();

        /// <summary>Gibt eine Auflistung der Nachfolgerknoten für dieses Dokument oder Element in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" />, das die Nachfolgerknoten des <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enthält.</returns>
        IEnumerable<XNode> DescendantNodes();

        /// <summary>Gibt eine Auflistung der Nachfolgerelemente für dieses Dokument oder Element in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" /> mit den Nachfolgerelementen des <see cref="T:System.Xml.Linq.XContainer" />.</returns>
        IEnumerable<XElement> Descendants();

        /// <summary>Gibt eine gefilterte Auflistung der Nachfolgerelemente für dieses Dokument oder Element in Dokumentreihenfolge zurück. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die Nachfolgerelemente des <see cref="T:System.Xml.Linq.XContainer" /> enthält, die mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> übereinstimmen.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine Übereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> Descendants(XName name);

        /// <summary>Ruft das erste (in Dokumentreihenfolge) untergeordnete Element mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> ab.</summary>
        /// <returns>Ein <see cref="T:System.Xml.Linq.XElement" />, das mit dem angegebenen <see cref="T:System.Xml.Linq.XName" /> übereinstimmt, oder null.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine Übereinstimmung gefunden werden soll.</param>
        XElement Element(XName name);

        /// <summary>Gibt eine Auflistung der untergeordneten Elemente dieses Dokuments oder Elements in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die untergeordneten Elemente dieses <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enthält.</returns>
        IEnumerable<XElement> Elements();

        /// <summary>Gibt eine gefilterte Auflistung der untergeordneten Elemente dieses Dokuments oder Elements in Dokumentreihenfolge zurück. Nur Elemente, die über einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> verfügen, sind in der Auflistung enthalten.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XElement" />, das die untergeordneten Elemente des <see cref="T:System.Xml.Linq.XContainer" />, die einen übereinstimmenden <see cref="T:System.Xml.Linq.XName" /> aufweisen, in Dokumentreihenfolge enthält.</returns>
        /// <param name="name">Der <see cref="T:System.Xml.Linq.XName" />, mit dem eine Übereinstimmung gefunden werden soll.</param>
        IEnumerable<XElement> Elements(XName name);

        /// <summary>Gibt eine Auflistung der untergeordneten Knoten dieses Dokuments oder Elements in Dokumentreihenfolge zurück.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerable`1" /> vom Typ <see cref="T:System.Xml.Linq.XNode" />, das die Inhalte dieses <see cref="T:System.Xml.Linq.XContainer" /> in Dokumentreihenfolge enthält.</returns>
        IEnumerable<XNode> Nodes();

        /// <summary>Entfernt die untergeordneten Knoten aus diesem Dokument oder Element.</summary>
        void RemoveNodes();

        /// <summary>Ersetzt die untergeordneten Knoten dieses Dokuments oder Elements durch den angegebenen Inhalt.</summary>
        /// <param name="content">Ein Inhaltsobjekt, das einfache Inhalte oder eine Auflistung von Inhaltsobjekten enthält, die die untergeordneten Knoten ersetzen.</param>
        void ReplaceNodes(object content);

        /// <summary>Ersetzt die untergeordneten Knoten dieses Dokuments oder Elements durch den angegebenen Inhalt.</summary>
        /// <param name="content">Eine Parameterliste von Inhaltsobjekten.</param>
        void ReplaceNodes(params object[] content);

        /// <summary>Serialisieren Sie dieses <see cref="T:System.Xml.Linq.XDocument" /> in eine Datei, und überschreiben Sie dabei eine vorhandene Datei, sofern vorhanden.</summary>
        /// <param name="fileName">Eine Zeichenfolge, die den Namen der Datei enthält.</param>
        void Save(string fileName);

        /// <summary>Serialisiert dieses <see cref="T:System.Xml.Linq.XDocument" /> in eine Datei, wobei optional die Formatierung deaktiviert wird.</summary>
        /// <param name="fileName">Eine Zeichenfolge, die den Namen der Datei enthält.</param>
        /// <param name="options">Ein <see cref="T:System.Xml.Linq.SaveOptions" />, das Formatierungsverhalten angibt.</param>
        void Save(string fileName, SaveOptions options);
    }
}