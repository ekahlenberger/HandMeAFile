using System;
using System.IO;
using System.Runtime.Remoting;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public class StreamWrapper : IStream, IProvideOrgStream
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
            return m_orgStream.GetLifetimeService();
        }

        /// <summary>
        /// Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien für diese Instanz gesteuert werden können.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien für diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt für diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime"/>-Eigenschaft initialisiert wurde.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verfügt nicht über die Berechtigung für die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        [CanBeNull]
        public object InitializeLifetimeService()
        {
            return m_orgStream.InitializeLifetimeService();
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
            return m_orgStream.CreateObjRef(requestedType);
        }
        /// <summary>
        /// Liest die Bytes asynchron aus dem aktuellen Stream und schreibt sie in einen anderen Stream.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Kopiervorgang darstellt.
        /// </returns>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder der Zielstream wird freigegeben.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterstützt kein Lesen oder Zielstream unterstützt keine Schreibvorgänge.</exception>
        public Task CopyToAsync(IStream destination)
        {
            return m_orgStream.CopyToAsync(((IProvideOrgStream)destination).OrgStream);
        }
        /// <summary>
        /// Liest die Bytes asynchron aus dem aktuellen Stream und schreibt sie unter Verwendung einer angegebenen Puffergröße in einen anderen Stream.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Kopiervorgang darstellt.
        /// </returns>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><param name="bufferSize">Die Größe des Cookies in Bytes. Dieser Wert muss größer als 0 sein. Die Standardgröße ist 4096.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize"/> ist negativ oder 0 (null).</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder der Zielstream wird freigegeben.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterstützt kein Lesen oder Zielstream unterstützt keine Schreibvorgänge.</exception>
        public Task CopyToAsync(IStream destination, int bufferSize)
        {
            return m_orgStream.CopyToAsync(((IProvideOrgStream)destination).OrgStream, bufferSize);
        }
        /// <summary>
        /// Liest die Bytes asynchron aus dem aktuellen Stream und schreibt sie unter Verwendung einer angegebenen Puffergröße und eines Abbruchtokens in einen anderen Stream.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Kopiervorgang darstellt.
        /// </returns>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><param name="bufferSize">Die Größe des Cookies in Bytes. Dieser Wert muss größer als 0 sein. Die Standardgröße ist 4096.</param><param name="cancellationToken">Das Token zum überwachen von Abbruchanforderungen . Der Standardwert ist <see cref="P:System.Threading.CancellationToken.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize"/> ist negativ oder 0 (null).</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder der Zielstream wird freigegeben.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterstützt kein Lesen oder Zielstream unterstützt keine Schreibvorgänge.</exception>
        public Task CopyToAsync(IStream destination, int bufferSize, CancellationToken cancellationToken)
        {
            return m_orgStream.CopyToAsync(((IProvideOrgStream)destination).OrgStream, bufferSize, cancellationToken);
        }
        /// <summary>
        /// Liest alle Bytes aus dem aktuellen Stream und schreibt sie in einen anderen Datenstrom.
        /// </summary>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterstützt keine Lesevorgänge. -oder- <paramref name="destination"/> unterstützt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder <paramref name="destination"/> wurde geschlossen, bevor die <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)"/>-Methode aufgerufen wurde.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception>
        public void CopyTo(IStream destination)
        {
            m_orgStream.CopyTo(((IProvideOrgStream)destination).OrgStream);
        }
        /// <summary>
        /// Liest alles Bytes aus dem aktuellen Datenstrom und schreibt sie unter Verwendung einer angegebenen Puffergröße in einen anderen Datenstrom.
        /// </summary>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><param name="bufferSize">Die Größe des Puffers. Dieser Wert muss größer als 0 sein. Die Standardgröße ist 4096.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> ist negativ oder 0 (null).</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterstützt keine Lesevorgänge. -oder- <paramref name="destination"/> unterstützt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder <paramref name="destination"/> wurde geschlossen, bevor die <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)"/>-Methode aufgerufen wurde.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception>
        public void CopyTo(IStream destination, int bufferSize)
        {
            m_orgStream.CopyTo(((IProvideOrgStream)destination).OrgStream, bufferSize);
        }
        /// <summary>
        /// Schließt den aktuellen Stream und gibt alle dem aktuellen Stream zugeordneten Ressourcen frei (z. B. Sockets und Dateihandles). Anstatt diese Methode aufzurufen, stellen Sie sicher, dass der Stream ordnungsgemäß freigegeben wird.
        /// </summary>
        public void Close()
        {
            m_orgStream.Close();
        }
        /// <summary>
        /// Löscht beim Überschreiben in einer abgeleiteten Klasse alle Puffer für diesen Stream und veranlasst die Ausgabe aller gepufferten Daten an das zugrunde liegende Gerät.
        /// </summary>
        /// <exception cref="T:System.IO.IOException">E/A-Fehler.</exception>
        public void Flush()
        {
            m_orgStream.Flush();
        }
        /// <summary>
        /// Löscht sämtliche Puffer für diesen Stream asynchron und veranlasst die Ausgabe aller gepufferten Daten an das zugrunde liegende Gerät.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die die asynchrone Leerung darstellt.
        /// </returns>
        /// <exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception>
        public Task FlushAsync()
        {
            return m_orgStream.FlushAsync();
        }
        /// <summary>
        /// Löscht alle Puffer für diesen Stream asynchron und veranlasst die Ausgabe aller gepufferten Daten an das zugrunde liegende Gerät und überwacht Abbruchanforderungen.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die die asynchrone Leerung darstellt.
        /// </returns>
        /// <param name="cancellationToken">Das Token zum überwachen von Abbruchanforderungen . Der Standardwert ist <see cref="P:System.Threading.CancellationToken.None"/>.</param><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception>
        public Task FlushAsync(CancellationToken cancellationToken)
        {
            return m_orgStream.FlushAsync(cancellationToken);
        }
        /// <summary>
        /// Beginnt einen asynchronen Lesevorgang. (Verwenden Sie stattdessen die <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)"/>-Methode. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <returns>
        /// Ein <see cref="T:System.IAsyncResult"/>, das den asynchronen Lesevorgang darstellt, der möglicherweise noch aussteht.
        /// </returns>
        /// <param name="buffer">Der Puffer, in den die Daten gelesen werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="buffer"/>, ab dem aus dem Stream gelesene Daten geschrieben werden.</param><param name="count">Die maximale Anzahl der zu lesenden Bytes.</param><param name="callback">Ein optionaler asynchroner Rückruf, der nach Abschluss des Lesevorgangs aufgerufen werden soll.</param><param name="state">Ein vom Benutzer bereitgestelltes Objekt, das diese asynchrone Leseanforderung von anderen Anforderungen unterscheidet.</param><exception cref="T:System.IO.IOException">Es wurde versucht, einen asynchronen Lesevorgang über das Ende des Streams hinaus durchzuführen, oder es ist ein Datenträgerfehler aufgetreten.</exception><exception cref="T:System.ArgumentException">Mindestens eines der Argumente ist ungültig.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception><exception cref="T:System.NotSupportedException">Die aktuelle Stream-Implementierung unterstützt den Lesevorgang nicht.</exception>
        public IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return m_orgStream.BeginRead(buffer, offset, count, callback, state);
        }
        /// <summary>
        /// Wartet, bis der ausstehende asynchrone Lesevorgang abgeschlossen ist. (Verwenden Sie stattdessen die <see cref="M:System.IO.Stream.ReadAsync(System.Byte[],System.Int32,System.Int32)"/>-Methode. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <returns>
        /// Die Anzahl der aus dem Stream gelesenen Bytes. Diese Anzahl kann zwischen 0 und der Anzahl der angeforderten Bytes liegen. Streams geben nur am Ende des Streams 0 zurück, andernfalls sollten sie blockieren, bis mindestens 1 Byte verfügbar ist.
        /// </returns>
        /// <param name="asyncResult">Der Verweis auf die ausstehende asynchrone Anforderung, die beendet werden soll.</param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult"/> ist null.</exception><exception cref="T:System.ArgumentException">Ein Handle für den ausstehenden Lesevorgang ist nicht verfügbar. -oder- Die anstehende Operation unterstützt keine Lesevorgänge.</exception><exception cref="T:System.InvalidOperationException"><paramref name="asyncResult"/> stammt nicht von einer <see cref="M:System.IO.Stream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"/>-Methode im aktuellen Stream.</exception><exception cref="T:System.IO.IOException">Der Stream ist geschlossen, oder ein interner Fehler ist aufgetreten.</exception>
        public int EndRead(IAsyncResult asyncResult)
        {
            return m_orgStream.EndRead(asyncResult);
        }
        /// <summary>
        /// Liest eine Bytesequenz asynchron aus dem aktuellen Stream und setzt die Position in diesem Stream um die Anzahl der gelesenen Bytes nach vorn.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Lesevorgang darstellt. Der Wert des <paramref name="TResult"/>-Parameters enthält die Gesamtzahl der Bytes, die in den Puffer gelesen werden. Der Ergebniswert kann niedriger als die Anzahl der angeforderten Bytes sein, wenn die Anzahl an derzeit verfügbaren Bytes kleiner ist als die angeforderte Anzahl, oder sie kann 0 (null) sein, wenn das Datenstromende erreicht ist.
        /// </returns>
        /// <param name="buffer">Der Puffer, in den die Daten geschrieben werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="buffer"/>, ab dem Daten aus dem Stream geschrieben werden.</param><param name="count">Die maximale Anzahl der zu lesenden Bytes.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist größer als die Pufferlänge.</exception><exception cref="T:System.NotSupportedException">Lesevorgänge werden vom Stream nicht unterstützt.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird gerade durch einen früheren Lesevorgang.</exception>
        public Task<int> ReadAsync(byte[] buffer, int offset, int count)
        {
            return m_orgStream.ReadAsync(buffer, offset, count);
        }
        /// <summary>
        /// Liest eine Folge von Bytes asynchron aus aktuellen Stream, erhöht die Position im Stream um die Anzahl der gelesenen Bytes und überwacht Abbruchanfragen.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Lesevorgang darstellt. Der Wert des <paramref name="TResult"/>-Parameters enthält die Gesamtzahl der Bytes, die in den Puffer gelesen werden. Der Ergebniswert kann niedriger als die Anzahl der angeforderten Bytes sein, wenn die Anzahl an derzeit verfügbaren Bytes kleiner ist als die angeforderte Anzahl, oder sie kann 0 (null) sein, wenn das Datenstromende erreicht ist.
        /// </returns>
        /// <param name="buffer">Der Puffer, in den die Daten geschrieben werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="buffer"/>, ab dem Daten aus dem Stream geschrieben werden.</param><param name="count">Die maximale Anzahl der zu lesenden Bytes.</param><param name="cancellationToken">Das Token zum überwachen von Abbruchanforderungen . Der Standardwert ist <see cref="P:System.Threading.CancellationToken.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist größer als die Pufferlänge.</exception><exception cref="T:System.NotSupportedException">Lesevorgänge werden vom Stream nicht unterstützt.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird gerade durch einen früheren Lesevorgang.</exception>
        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return m_orgStream.ReadAsync(buffer, offset, count, cancellationToken);
        }
        /// <summary>
        /// Beginnt einen asynchronen Schreibvorgang. (Verwenden Sie stattdessen <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)"/>. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <returns>
        /// Ein IAsyncResult, das den asynchronen Schreibvorgang darstellt, der möglicherweise noch aussteht.
        /// </returns>
        /// <param name="buffer">Der Puffer, aus dem Daten geschrieben werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="buffer"/>, ab dem geschrieben werden soll.</param><param name="count">Die maximale Anzahl der zu schreibenden Bytes.</param><param name="callback">Ein optionaler asynchroner Rückruf, der nach Abschluss des Schreibvorgangs aufgerufen wird.</param><param name="state">Ein vom Benutzer bereitgestelltes Objekt, das diese asynchrone Schreibanforderung von anderen Anforderungen unterscheidet.</param><exception cref="T:System.IO.IOException">Es wurde versucht, einen asynchronen Schreibvorgang über das Ende des Streams hinaus durchzuführen, oder es ist ein Datenträgerfehler aufgetreten.</exception><exception cref="T:System.ArgumentException">Mindestens eines der Argumente ist ungültig.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception><exception cref="T:System.NotSupportedException">Die aktuelle Stream-Implementierung unterstützt den Schreibvorgang nicht.</exception>
        public IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
        {
            return m_orgStream.BeginWrite(buffer, offset, count, callback, state);
        }
        /// <summary>
        /// Beendet einen asynchronen Schreibvorgang. (Verwenden Sie stattdessen <see cref="M:System.IO.Stream.WriteAsync(System.Byte[],System.Int32,System.Int32)"/>. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <param name="asyncResult">Ein Verweis auf die ausstehende asynchrone E/A-Anforderung.</param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult"/> ist null.</exception><exception cref="T:System.ArgumentException">Ein Handle für den ausstehenden Schreibvorgang ist nicht verfügbar. -oder- Die anstehende Operation unterstützt keine Schreibvorgänge.</exception><exception cref="T:System.InvalidOperationException"><paramref name="asyncResult"/> stammt nicht von einer <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"/>-Methode im aktuellen Stream.</exception><exception cref="T:System.IO.IOException">Der Stream ist geschlossen, oder ein interner Fehler ist aufgetreten.</exception>
        public void EndWrite(IAsyncResult asyncResult)
        {
            m_orgStream.EndWrite(asyncResult);
        }
        /// <summary>
        /// Schreibt eine Bytesequenz asynchron in den aktuellen Stream und setzt die aktuelle Position in diesem Stream um die Anzahl der geschriebenen Bytes nach vorn.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Schreibvorgang darstellt.
        /// </returns>
        /// <param name="buffer">Der Puffer, aus dem Daten geschrieben werden sollen.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="buffer"/>, ab dem Bytes in den Stream kopiert werden.</param><param name="count">Die maximale Anzahl der zu schreibenden Bytes.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist größer als die Pufferlänge.</exception><exception cref="T:System.NotSupportedException">Der Stream unterstützt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird derzeit von einem vorherigen Schreibvorgang verwendet.</exception>
        public Task WriteAsync(byte[] buffer, int offset, int count)
        {
            return m_orgStream.WriteAsync(buffer, offset, count);
        }
        /// <summary>
        /// Schreibt beim Überschreiben in einer abgeleiteten Klasse eine Folge von Bytes asynchron in den aktuellen Stream und erhöht die aktuelle Position im Stream um die Anzahl der geschriebenen Bytes und überwacht Abbruchanforderungen.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Schreibvorgang darstellt.
        /// </returns>
        /// <param name="buffer">Der Puffer, aus dem Daten geschrieben werden sollen.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="buffer"/>, ab dem Bytes in den Stream kopiert werden.</param><param name="count">Die maximale Anzahl der zu schreibenden Bytes.</param><param name="cancellationToken">Das Token zum überwachen von Abbruchanforderungen . Der Standardwert ist <see cref="P:System.Threading.CancellationToken.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist größer als die Pufferlänge.</exception><exception cref="T:System.NotSupportedException">Der Stream unterstützt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird derzeit von einem vorherigen Schreibvorgang verwendet.</exception>
        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return m_orgStream.WriteAsync(buffer, offset, count, cancellationToken);
        }
        /// <summary>
        /// Legt beim Überschreiben in einer abgeleiteten Klasse die Position im aktuellen Stream fest.
        /// </summary>
        /// <returns>
        /// Die neue Position innerhalb des aktuellen Streams.
        /// </returns>
        /// <param name="offset">Ein Byteoffset relativ zum <paramref name="origin"/>-Parameter.</param><param name="origin">Ein Wert vom Typ <see cref="T:System.IO.SeekOrigin"/>, der den Bezugspunkt angibt, von dem aus die neue Position ermittelt wird.</param><exception cref="T:System.IO.IOException">E/A-Fehler.</exception><exception cref="T:System.NotSupportedException">Der Stream unterstützt keine Suchvorgänge. Dies ist beispielsweise der Fall, wenn der Stream aus einer Pipe- oder Konsolenausgabe erstellt wird.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public long Seek(long offset, SeekOrigin origin)
        {
            return m_orgStream.Seek(offset, origin);
        }
        /// <summary>
        /// Legt beim Überschreiben in einer abgeleiteten Klasse die Länge des aktuellen Streams fest.
        /// </summary>
        /// <param name="value">Die gewünschte Länge des aktuellen Streams in Bytes.</param><exception cref="T:System.IO.IOException">E/A-Fehler.</exception><exception cref="T:System.NotSupportedException">Der Stream unterstützt nicht sowohl Lese- als auch Schreibvorgänge. Dies ist beispielsweise der Fall, wenn der Stream aus einer Pipe- oder Konsolenausgabe erstellt wird.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public void SetLength(long value)
        {
            m_orgStream.SetLength(value);
        }
        /// <summary>
        /// Liest beim Überschreiben in einer abgeleiteten Klasse eine Folge von Bytes aus dem aktuellen Stream und erhöht die Position im Stream um die Anzahl der gelesenen Bytes.
        /// </summary>
        /// <returns>
        /// Die Gesamtanzahl der in den Puffer gelesenen Bytes. Dies kann weniger als die Anzahl der angeforderten Bytes sein, wenn diese Anzahl an Bytes derzeit nicht verfügbar ist, oder 0, wenn das Ende des Streams erreicht ist.
        /// </returns>
        /// <param name="buffer">Ein Bytearray. Nach dem Beenden dieser Methode enthält der Puffer das angegebene Bytearray mit den Werten zwischen <paramref name="offset"/> und (<paramref name="offset"/> + <paramref name="count"/> - 1), die durch aus der aktuellen Quelle gelesene Bytes ersetzt wurden.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="buffer"/>, ab dem die aus dem aktuellen Stream gelesenen Daten gespeichert werden.</param><param name="count">Die maximale Anzahl an Bytes, die aus dem aktuellen Stream gelesen werden sollen.</param><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist größer als die Pufferlänge.</exception><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.IO.IOException">E/A-Fehler.</exception><exception cref="T:System.NotSupportedException">Lesevorgänge werden vom Stream nicht unterstützt.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public int Read(byte[] buffer, int offset, int count)
        {
            return m_orgStream.Read(buffer, offset, count);
        }
        /// <summary>
        /// Liest ein Byte aus dem Stream und erhöht die Position im Stream um ein Byte, oder gibt -1 zurück, wenn das Ende des Streams erreicht ist.
        /// </summary>
        /// <returns>
        /// Das Byte ohne Vorzeichen, umgewandelt in Int32, oder -1, wenn das Ende des Streams erreicht ist.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">Lesevorgänge werden vom Stream nicht unterstützt.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public int ReadByte()
        {
            return m_orgStream.ReadByte();
        }
        /// <summary>
        /// Schreibt beim Überschreiben in einer abgeleiteten Klasse eine Folge von Bytes in den aktuellen Stream und erhöht die aktuelle Position im Stream um die Anzahl der geschriebenen Bytes.
        /// </summary>
        /// <param name="buffer">Ein Bytearray. Diese Methode kopiert <paramref name="count"/> Bytes aus dem <paramref name="buffer"/> in den aktuellen Stream.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="buffer"/>, ab dem Bytes in den aktuellen Stream kopiert werden.</param><param name="count">Die Anzahl an Bytes, die in den aktuellen Stream geschrieben werden sollen.</param>
        public void Write(byte[] buffer, int offset, int count)
        {
            m_orgStream.Write(buffer, offset, count);
        }
        /// <summary>
        /// Schreibt ein Byte an die aktuellen Position im Stream und erhöht die aktuelle Position im Stream um ein Byte.
        /// </summary>
        /// <param name="value">Das Byte, das in den Stream geschrieben werden soll.</param><exception cref="T:System.IO.IOException">E/A-Fehler.</exception><exception cref="T:System.NotSupportedException">Der Stream unterstützt keine Schreibvorgänge, oder er wurde bereits geschlossen.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public void WriteByte(byte value)
        {
            m_orgStream.WriteByte(value);
        }
        /// <summary>
        /// Ruft beim Überschreiben in einer abgeleiteten Klasse einen Wert ab, der angibt, ob der aktuelle Stream Lesevorgänge unterstützt.
        /// </summary>
        /// <returns>
        /// true, wenn der Stream Lesevorgänge unterstützt, andernfalls false.
        /// </returns>
        public bool CanRead
        {
            get { return m_orgStream.CanRead; }
        }
        /// <summary>
        /// Ruft beim Überschreiben in einer abgeleiteten Klasse einen Wert ab, der angibt, ob der aktuelle Stream Suchvorgänge unterstützt.
        /// </summary>
        /// <returns>
        /// true, wenn der Stream Suchvorgänge unterstützt, andernfalls false.
        /// </returns>
        public bool CanSeek
        {
            get { return m_orgStream.CanSeek; }
        }
        /// <summary>
        /// Ruft einen Wert ab, der bestimmt, ob für den aktuellen Stream ein Timeout möglich ist.
        /// </summary>
        /// <returns>
        /// Ein Wert, der bestimmt, ob für den aktuellen Stream ein Timeout möglich ist.
        /// </returns>
        public bool CanTimeout
        {
            get { return m_orgStream.CanTimeout; }
        }
        /// <summary>
        /// Ruft beim Überschreiben in einer abgeleiteten Klasse einen Wert ab, der angibt, ob der aktuelle Stream Schreibvorgänge unterstützt.
        /// </summary>
        /// <returns>
        /// true, wenn der Stream Schreibvorgänge unterstützt, andernfalls false.
        /// </returns>
        public bool CanWrite
        {
            get { return m_orgStream.CanWrite; }
        }
        /// <summary>
        /// Ruft beim Überschreiben in einer abgeleiteten Klasse die Länge des Streams in Bytes ab.
        /// </summary>
        /// <returns>
        /// Ein Long-Wert, der die Länge des Streams in Bytes darstellt.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">Eine aus Stream abgeleitete Klasse unterstützt keine Suchvorgänge.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public long Length
        {
            get { return m_orgStream.Length; }
        }
        /// <summary>
        /// Ruft beim Überschreiben in einer abgeleiteten Klasse die Position im aktuellen Stream ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Die aktuelle Position innerhalb des Streams.
        /// </returns>
        /// <exception cref="T:System.IO.IOException">E/A-Fehler.</exception><exception cref="T:System.NotSupportedException">Der Stream unterstützt keine Suchvorgänge.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public long Position
        {
            get { return m_orgStream.Position; }
            set { m_orgStream.Position = value; }
        }
        /// <summary>
        /// Ruft einen Wert in Millisekunden ab, der bestimmt, wie lange der Stream versucht, Lesevorgänge durchzuführen, bevor ein Timeout auftritt, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Ein Wert in Millisekunden, der bestimmt, wie lange der Stream versucht, Lesevorgänge durchzuführen, bevor ein Timeout auftritt.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.IO.Stream.ReadTimeout"/>-Methode löst immer eine <see cref="T:System.InvalidOperationException"/> aus.</exception>
        public int ReadTimeout
        {
            get { return m_orgStream.ReadTimeout; }
            set { m_orgStream.ReadTimeout = value; }
        }
        /// <summary>
        /// Ruft einen Wert in Millisekunden ab, der bestimmt, wie lange der Stream versucht, Schreibvorgänge durchzuführen, bevor ein Timeout auftritt, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Ein Wert in Millisekunden, der bestimmt, wie lange der Stream versucht, Schreibvorgänge durchzuführen, bevor ein Timeout auftritt.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.IO.Stream.WriteTimeout"/>-Methode löst immer eine <see cref="T:System.InvalidOperationException"/> aus.</exception>
        public int WriteTimeout
        {
            get { return m_orgStream.WriteTimeout; }
            set { m_orgStream.WriteTimeout = value; }
        }

        private readonly Stream m_orgStream;
        public Stream OrgStream => m_orgStream;
        public StreamWrapper(Stream orgStream)
        {
            if (orgStream == null) throw new ArgumentNullException(nameof(orgStream));
            m_orgStream = orgStream;
        }
        #region IDisposable Support
        private bool m_disposedValue; 
        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposedValue)
            {
                if (disposing)
                {
                    m_orgStream.Dispose();
                }
                m_disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

        public static implicit operator Stream(StreamWrapper stream)
        {
            return stream.m_orgStream;
        }
        public static implicit operator StreamWrapper(Stream stream)
        {
            return new StreamWrapper(stream);
        }
    }
}