using System;
using System.IO;
using System.Runtime.Remoting;
using System.Threading;
using System.Threading.Tasks;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public class FileStreamWrapper : IFileStream, IProvideOrgStream
    {
        /// <summary>
        /// Ruft das aktuelle Lebensdauerdienstobjekt ab, das die Lebensdauerrichtlinien f�r diese Instanz steuert.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien f�r diese Instanz verwendet wird.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verf�gt nicht �ber die Berechtigung f�r die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        public object GetLifetimeService()
        {
            return m_orgFileStream.GetLifetimeService();
        }
        /// <summary>
        /// Ruft ein Lebensdauerdienstobjekt ab, mit dem die Lebensdauerrichtlinien f�r diese Instanz gesteuert werden k�nnen.
        /// </summary>
        /// <returns>
        /// Ein Objekt vom Typ <see cref="T:System.Runtime.Remoting.Lifetime.ILease"/>, das zur Steuerung der Lebensdauerrichtlinien f�r diese Instanz verwendet wird. Dies ist das aktuelle Lebensdauerdienstobjekt f�r diese Instanz, sofern vorhanden, bzw. ein neues Lebensdauerdienstobjekt, das mit dem Wert der <see cref="P:System.Runtime.Remoting.Lifetime.LifetimeServices.LeaseManagerPollTime"/>-Eigenschaft initialisiert wurde.
        /// </returns>
        /// <exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verf�gt nicht �ber die Berechtigung f�r die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration, Infrastructure"/></PermissionSet>
        public object InitializeLifetimeService()
        {
            return m_orgFileStream.InitializeLifetimeService();
        }
        /// <summary>
        /// Erstellt ein Objekt mit allen relevanten Informationen, die zum Generieren eines Proxys f�r die Kommunikation mit einem Remoteobjekt erforderlich sind.
        /// </summary>
        /// <returns>
        /// Zum Generieren eines Proxys erforderliche Informationen.
        /// </returns>
        /// <param name="requestedType">Der <see cref="T:System.Type"/> des Objekts, auf das der neue <see cref="T:System.Runtime.Remoting.ObjRef"/> verweist.</param><exception cref="T:System.Runtime.Remoting.RemotingException">Diese Instanz ist kein g�ltiges Remoteobjekt.</exception><exception cref="T:System.Security.SecurityException">Der direkte Aufrufer verf�gt nicht �ber die Berechtigung f�r die Infrastruktur.</exception><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure"/></PermissionSet>
        public ObjRef CreateObjRef(Type requestedType)
        {
            return m_orgFileStream.CreateObjRef(requestedType);
        }
        /// <summary>
        /// Liest die Bytes asynchron aus dem aktuellen Stream und schreibt sie in einen anderen Stream.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Kopiervorgang darstellt.
        /// </returns>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder der Zielstream wird freigegeben.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterst�tzt kein Lesen oder Zielstream unterst�tzt keine Schreibvorg�nge.</exception>
        public Task CopyToAsync(IStream destination)
        {
            return m_orgFileStream.CopyToAsync(((IProvideOrgStream)destination).OrgStream);
        }
        /// <summary>
        /// Liest die Bytes asynchron aus dem aktuellen Stream und schreibt sie unter Verwendung einer angegebenen Puffergr��e in einen anderen Stream.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Kopiervorgang darstellt.
        /// </returns>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><param name="bufferSize">Die Gr��e des Cookies in Bytes. Dieser Wert muss gr��er als 0 sein. Die Standardgr��e ist 4096.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize"/> ist negativ oder 0 (null).</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder der Zielstream wird freigegeben.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterst�tzt kein Lesen oder Zielstream unterst�tzt keine Schreibvorg�nge.</exception>
        public Task CopyToAsync(IStream destination, int bufferSize)
        {
            return m_orgFileStream.CopyToAsync(((IProvideOrgStream)destination).OrgStream, bufferSize);
        }
        /// <summary>
        /// Liest die Bytes asynchron aus dem aktuellen Stream und schreibt sie unter Verwendung einer angegebenen Puffergr��e und eines Abbruchtokens in einen anderen Stream.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Kopiervorgang darstellt.
        /// </returns>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><param name="bufferSize">Die Gr��e des Cookies in Bytes. Dieser Wert muss gr��er als 0 sein. Die Standardgr��e ist 4096.</param><param name="cancellationToken">Das Token zum �berwachen von Abbruchanforderungen . Der Standardwert ist <see cref="P:System.Threading.CancellationToken.None"/>.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="buffersize"/> ist negativ oder 0 (null).</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder der Zielstream wird freigegeben.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterst�tzt kein Lesen oder Zielstream unterst�tzt keine Schreibvorg�nge.</exception>
        public Task CopyToAsync(IStream destination, int bufferSize, CancellationToken cancellationToken)
        {
            return m_orgFileStream.CopyToAsync(((IProvideOrgStream)destination).OrgStream, bufferSize, cancellationToken);
        }
        /// <summary>
        /// Liest alle Bytes aus dem aktuellen Stream und schreibt sie in einen anderen Datenstrom.
        /// </summary>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterst�tzt keine Lesevorg�nge. -oder- <paramref name="destination"/> unterst�tzt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder <paramref name="destination"/> wurde geschlossen, bevor die <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)"/>-Methode aufgerufen wurde.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception>
        public void CopyTo(IStream destination)
        {
            m_orgFileStream.CopyTo(((IProvideOrgStream)destination).OrgStream);
        }
        /// <summary>
        /// Liest alles Bytes aus dem aktuellen Datenstrom und schreibt sie unter Verwendung einer angegebenen Puffergr��e in einen anderen Datenstrom.
        /// </summary>
        /// <param name="destination">Der Stream, in den der Inhalt des aktuellen Stream kopiert wird.</param><param name="bufferSize">Die Gr��e des Puffers. Dieser Wert muss gr��er als 0 sein. Die Standardgr��e ist 4096.</param><exception cref="T:System.ArgumentNullException"><paramref name="destination"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> ist negativ oder 0 (null).</exception><exception cref="T:System.NotSupportedException">Der aktuelle Stream unterst�tzt keine Lesevorg�nge. -oder- <paramref name="destination"/> unterst�tzt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Entweder der aktuelle Stream oder <paramref name="destination"/> wurde geschlossen, bevor die <see cref="M:System.IO.Stream.CopyTo(System.IO.Stream)"/>-Methode aufgerufen wurde.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception>
        public void CopyTo(IStream destination, int bufferSize)
        {
            m_orgFileStream.CopyTo(((IProvideOrgStream)destination).OrgStream, bufferSize);
        }
        /// <summary>
        /// Schlie�t den aktuellen Stream und gibt alle dem aktuellen Stream zugeordneten Ressourcen frei (z.�B. Sockets und Dateihandles). Anstatt diese Methode aufzurufen, stellen Sie sicher, dass der Stream ordnungsgem�� freigegeben wird.
        /// </summary>
        public void Close()
        {
            m_orgFileStream.Close();
        }
        /// <summary>
        /// L�scht s�mtliche Puffer f�r diesen Stream asynchron und veranlasst die Ausgabe aller gepufferten Daten an das zugrunde liegende Ger�t.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die die asynchrone Leerung darstellt.
        /// </returns>
        /// <exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception>
        public Task FlushAsync()
        {
            return m_orgFileStream.FlushAsync();
        }
        /// <summary>
        /// Liest eine Bytesequenz asynchron aus dem aktuellen Stream und setzt die Position in diesem Stream um die Anzahl der gelesenen Bytes nach vorn.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Lesevorgang darstellt. Der Wert des <paramref name="TResult"/>-Parameters enth�lt die Gesamtzahl der Bytes, die in den Puffer gelesen werden. Der Ergebniswert kann niedriger als die Anzahl der angeforderten Bytes sein, wenn die Anzahl an derzeit verf�gbaren Bytes kleiner ist als die angeforderte Anzahl, oder sie kann 0 (null) sein, wenn das Datenstromende erreicht ist.
        /// </returns>
        /// <param name="buffer">Der Puffer, in den die Daten geschrieben werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="buffer"/>, ab dem Daten aus dem Stream geschrieben werden.</param><param name="count">Die maximale Anzahl der zu lesenden Bytes.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist gr��er als die Pufferl�nge.</exception><exception cref="T:System.NotSupportedException">Lesevorg�nge werden vom Stream nicht unterst�tzt.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird gerade durch einen fr�heren Lesevorgang.</exception>
        public Task<int> ReadAsync(byte[] buffer, int offset, int count)
        {
            return m_orgFileStream.ReadAsync(buffer, offset, count);
        }
        /// <summary>
        /// Schreibt eine Bytesequenz asynchron in den aktuellen Stream und setzt die aktuelle Position in diesem Stream um die Anzahl der geschriebenen Bytes nach vorn.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Schreibvorgang darstellt.
        /// </returns>
        /// <param name="buffer">Der Puffer, aus dem Daten geschrieben werden sollen.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="buffer"/>, ab dem Bytes in den Stream kopiert werden.</param><param name="count">Die maximale Anzahl der zu schreibenden Bytes.</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist gr��er als die Pufferl�nge.</exception><exception cref="T:System.NotSupportedException">Der Stream unterst�tzt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird derzeit von einem vorherigen Schreibvorgang verwendet.</exception>
        public Task WriteAsync(byte[] buffer, int offset, int count)
        {
            return m_orgFileStream.WriteAsync(buffer, offset, count);
        }
        /// <summary>
        /// Ruft einen Wert ab, der bestimmt, ob f�r den aktuellen Stream ein Timeout m�glich ist.
        /// </summary>
        /// <returns>
        /// Ein Wert, der bestimmt, ob f�r den aktuellen Stream ein Timeout m�glich ist.
        /// </returns>
        public bool CanTimeout
        {
            get { return m_orgFileStream.CanTimeout; }
        }
        /// <summary>
        /// Ruft einen Wert in Millisekunden ab, der bestimmt, wie lange der Stream versucht, Lesevorg�nge durchzuf�hren, bevor ein Timeout auftritt, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Ein Wert in Millisekunden, der bestimmt, wie lange der Stream versucht, Lesevorg�nge durchzuf�hren, bevor ein Timeout auftritt.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.IO.Stream.ReadTimeout"/>-Methode l�st immer eine <see cref="T:System.InvalidOperationException"/> aus.</exception>
        public int ReadTimeout
        {
            get { return m_orgFileStream.ReadTimeout; }
            set { m_orgFileStream.ReadTimeout = value; }
        }
        /// <summary>
        /// Ruft einen Wert in Millisekunden ab, der bestimmt, wie lange der Stream versucht, Schreibvorg�nge durchzuf�hren, bevor ein Timeout auftritt, oder legt diesen fest.
        /// </summary>
        /// <returns>
        /// Ein Wert in Millisekunden, der bestimmt, wie lange der Stream versucht, Schreibvorg�nge durchzuf�hren, bevor ein Timeout auftritt.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">Die <see cref="P:System.IO.Stream.WriteTimeout"/>-Methode l�st immer eine <see cref="T:System.InvalidOperationException"/> aus.</exception>
        public int WriteTimeout
        {
            get { return m_orgFileStream.WriteTimeout; }
            set { m_orgFileStream.WriteTimeout = value; }
        }
        /// <summary>
        /// L�scht die Puffer f�r diesen Datenstrom und veranlasst die Ausgabe aller gepufferten Daten in die Datei.
        /// </summary>
        /// <exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception><exception cref="T:System.ObjectDisposedException">Der Stream ist geschlossen.</exception>
        public void Flush()
        {
            m_orgFileStream.Flush();
        }
        /// <summary>
        /// L�scht die Puffer f�r diesen Datenstrom, veranlasst die Ausgabe aller gepufferten Daten in die Datei und l�scht zudem alle Zwischendateipuffer.
        /// </summary>
        /// <param name="flushToDisk">true, um alle Zwischendateipuffer zu leeren, andernfalls false.</param>
        public void Flush(bool flushToDisk)
        {
            m_orgFileStream.Flush(flushToDisk);
        }
        /// <summary>
        /// Legt die L�nge dieses Streams auf den angegebenen Wert fest.
        /// </summary>
        /// <param name="value">Die neue L�nge des Streams.</param><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception><exception cref="T:System.NotSupportedException">Der Stream unterst�tzt weder Schreib- noch Suchvorg�nge.</exception><exception cref="T:System.ArgumentOutOfRangeException">Es wurde versucht, den <paramref name="value"/>-Parameter auf einen kleineren Wert als 0 festzulegen.</exception>
        public void SetLength(long value)
        {
            m_orgFileStream.SetLength(value);
        }
        /// <summary>
        /// Liest einen Byteblock aus dem Stream und schreibt die Daten in einen angegebenen Puffer.
        /// </summary>
        /// <returns>
        /// Die Gesamtanzahl der in den Puffer gelesenen Bytes. Dies kann weniger als die Anzahl der angeforderten Bytes sein, wenn diese Anzahl an Bytes derzeit nicht verf�gbar ist, oder null, wenn das Streamende erreicht ist.
        /// </returns>
        /// <param name="array">Enth�lt nach dem Beenden dieser Methode das angegebene Bytearray mit den Werten zwischen <paramref name="offset"/> und (<paramref name="offset"/> + <paramref name="count"/> - 1<paramref name=")"/>), die durch die aus der aktuellen Quelle gelesenen Bytes ersetzt wurden.</param><param name="offset">Das Byteoffset in <paramref name="array"/>, an dem die gelesenen Bytes platziert werden.</param><param name="count">Die maximale Anzahl der zu lesenden Bytes.</param><exception cref="T:System.ArgumentNullException"><paramref name="array"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.NotSupportedException">Lesevorg�nge werden vom Stream nicht unterst�tzt.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception><exception cref="T:System.ArgumentException"><paramref name="offset"/> und <paramref name="count"/> bezeichnen einen ung�ltigen Bereich in <paramref name="array"/>.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public int Read(byte[] array, int offset, int count)
        {
            return m_orgFileStream.Read(array, offset, count);
        }
        /// <summary>
        /// Legt die aktuelle Position dieses Streams auf den angegebenen Wert fest.
        /// </summary>
        /// <returns>
        /// Die neue Position im Stream.
        /// </returns>
        /// <param name="offset">Der Punkt relativ zu <paramref name="origin"/>, ab dem gesucht werden soll.</param><param name="origin">Bestimmt den Anfang, das Ende oder die aktuelle Position als Bezugspunkt f�r <paramref name="origin"/> unter Verwendung eines Werts vom Typ <see cref="T:System.IO.SeekOrigin"/>.</param><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception><exception cref="T:System.NotSupportedException">Der Stream unterst�tzt keine Suchvorg�nge. Dies ist beispielsweise der Fall, wenn FileStream aus einer Pipe- oder Konsolenausgabe erstellt wird.</exception><exception cref="T:System.ArgumentException">Es wurde versucht, eine Suche vor dem Anfang des Streams auszuf�hren.</exception><exception cref="T:System.ObjectDisposedException">Es wurden Methoden aufgerufen, nachdem der Stream geschlossen wurde.</exception>
        public long Seek(long offset, SeekOrigin origin)
        {
            return m_orgFileStream.Seek(offset, origin);
        }
        /// <summary>
        /// Schreibt einen Block von Bytes in den Dateistream.
        /// </summary>
        /// <param name="array">Der Puffer mit den Daten, die in den Stream geschrieben werden sollen.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="array"/>, ab dem Bytes in den Stream kopiert werden.</param><param name="count">Die maximale Anzahl der zu schreibenden Bytes.</param><exception cref="T:System.ArgumentNullException"><paramref name="array"/> ist null.</exception><exception cref="T:System.ArgumentException"><paramref name="offset"/> und <paramref name="count"/> bezeichnen einen ung�ltigen Bereich in <paramref name="array"/>.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.  -�oder�- Ein anderer Thread hat ggf. eine unerwartete �nderung an der Position des vom Betriebssystem verwendeten Dateihandles bewirkt.</exception><exception cref="T:System.ObjectDisposedException">Der Stream ist geschlossen.</exception><exception cref="T:System.NotSupportedException">Die aktuelle Instanz des Streams unterst�tzt keine Schreibvorg�nge.</exception>
        public void Write(byte[] array, int offset, int count)
        {
            m_orgFileStream.Write(array, offset, count);
        }
        /// <summary>
        /// Beginnt einen asynchronen Lesevorgang. (Verwenden Sie stattdessen <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)"/>. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <returns>
        /// Ein Objekt, das auf den asynchronen Lesevorgang verweist.
        /// </returns>
        /// <param name="array">Der Puffer, in den Daten gelesen werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="array"/>, ab dem gelesen werden soll.</param><param name="numBytes">Die maximale Anzahl der zu lesenden Bytes.</param><param name="userCallback">Die Methode, die aufgerufen werden soll, wenn der asynchrone Lesevorgang abgeschlossen ist.</param><param name="stateObject">Ein vom Benutzer bereitgestelltes Objekt, das diese asynchrone Leseanforderung von anderen Anforderungen unterscheidet.</param><exception cref="T:System.ArgumentException">Die L�nge des Arrays minus <paramref name="offset"/> ist kleiner als <paramref name="numBytes"/>.</exception><exception cref="T:System.ArgumentNullException"><paramref name="array"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="numBytes"/> ist negativ.</exception><exception cref="T:System.IO.IOException">Es wurde ein asynchroner Lesevorgang �ber das Dateiende hinaus versucht.</exception>
        public IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            return m_orgFileStream.BeginRead(array, offset, numBytes, userCallback, stateObject);
        }
        /// <summary>
        /// Wartet, bis der ausstehende asynchrone Lesevorgang abgeschlossen ist. (Verwenden Sie stattdessen <see cref="M:System.IO.FileStream.ReadAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)"/>. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <returns>
        /// Die Anzahl der aus dem Stream gelesenen Bytes. Diese Anzahl kann zwischen 0 und der Anzahl der angeforderten Bytes liegen. Streams geben nur am Ende des Streams 0 zur�ck, andernfalls sollten sie blockieren, bis mindestens 1 Byte verf�gbar ist.
        /// </returns>
        /// <param name="asyncResult">Der Verweis auf die ausstehende asynchrone Anforderung, die abgewartet werden soll.</param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult"/> ist null.</exception><exception cref="T:System.ArgumentException">Dieses <see cref="T:System.IAsyncResult"/>-Objekt wurde nicht durch Aufruf von <see cref="M:System.IO.FileStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"/> in dieser Klasse erstellt.</exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.IO.FileStream.EndRead(System.IAsyncResult)"/> wurde mehrmals aufgerufen.</exception><exception cref="T:System.IO.IOException">Der Stream ist geschlossen, oder ein interner Fehler ist aufgetreten.</exception>
        public int EndRead(IAsyncResult asyncResult)
        {
            return m_orgFileStream.EndRead(asyncResult);
        }
        /// <summary>
        /// Liest ein Byte aus der Datei und erh�ht die Leseposition um ein Byte.
        /// </summary>
        /// <returns>
        /// Das Byte, das in <see cref="T:System.Int32"/> umgewandelt wurde, oder�-1, wenn das Ende des Streams erreicht wurde.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">Der aktuelle Stream unterst�tzt keine Lesevorg�nge.</exception><exception cref="T:System.ObjectDisposedException">Der aktuelle Stream ist geschlossen.</exception>
        public int ReadByte()
        {
            return m_orgFileStream.ReadByte();
        }
        /// <summary>
        /// Beginnt einen asynchronen Schreibvorgang. (Verwenden Sie stattdessen <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)"/>. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <returns>
        /// Ein Objekt, das auf den asynchronen Schreibvorgang verweist.
        /// </returns>
        /// <param name="array">Der Puffer mit den Daten, die in den aktuellen Stream geschrieben werden sollen.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="array"/>, ab dem Bytes in den aktuellen Stream kopiert werden.</param><param name="numBytes">Die maximale Anzahl der zu schreibenden Bytes.</param><param name="userCallback">Die Methode, die aufgerufen werden soll, wenn der asynchrone Schreibvorgang abgeschlossen ist.</param><param name="stateObject">Ein vom Benutzer bereitgestelltes Objekt, das diese asynchrone Schreibanforderung von anderen Anforderungen unterscheidet.</param><exception cref="T:System.ArgumentException">Die L�nge von <paramref name="array"/> minus <paramref name="offset"/> ist kleiner als <paramref name="numBytes"/>.</exception><exception cref="T:System.ArgumentNullException"><paramref name="array"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="numBytes"/> ist negativ.</exception><exception cref="T:System.NotSupportedException">Der Stream unterst�tzt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Der Stream ist geschlossen.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.</exception>
        public IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            return m_orgFileStream.BeginWrite(array, offset, numBytes, userCallback, stateObject);
        }
        /// <summary>
        /// Beendet einen asynchronen Schreibvorgang und blockiert, bis die E/A-Operation abgeschlossen wurde. (Verwenden Sie stattdessen <see cref="M:System.IO.FileStream.WriteAsync(System.Byte[],System.Int32,System.Int32,System.Threading.CancellationToken)"/>. Weitere Informationen finden Sie im Abschnitt "Hinweise".)
        /// </summary>
        /// <param name="asyncResult">Die ausstehende asynchrone E/A-Anforderung.</param><exception cref="T:System.ArgumentNullException"><paramref name="asyncResult"/> ist null.</exception><exception cref="T:System.ArgumentException">Dieses <see cref="T:System.IAsyncResult"/>-Objekt wurde nicht durch Aufruf von <see cref="M:System.IO.Stream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)"/> in dieser Klasse erstellt.</exception><exception cref="T:System.InvalidOperationException"><see cref="M:System.IO.FileStream.EndWrite(System.IAsyncResult)"/> wurde mehrmals aufgerufen.</exception><exception cref="T:System.IO.IOException">Der Stream ist geschlossen, oder ein interner Fehler ist aufgetreten.</exception>
        public void EndWrite(IAsyncResult asyncResult)
        {
            m_orgFileStream.EndWrite(asyncResult);
        }
        /// <summary>
        /// Schreibt ein Byte an die aktuelle Position im Dateistream.
        /// </summary>
        /// <param name="value">Ein Byte, das in den Stream geschrieben werden soll.</param><exception cref="T:System.ObjectDisposedException">Der Stream ist geschlossen.</exception><exception cref="T:System.NotSupportedException">Der Stream unterst�tzt das Schreiben nicht.</exception>
        public void WriteByte(byte value)
        {
            m_orgFileStream.WriteByte(value);
        }
        /// <summary>
        /// Verhindert, dass andere Prozesse im <see cref="T:System.IO.FileStream"/> lesen oder schreiben.
        /// </summary>
        /// <param name="position">Der Anfang des zu sperrenden Bereichs. Der Wert dieses Parameters muss gr��er oder gleich 0 sein.</param><param name="length">Der zu sperrende Bereich.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position"/> oder <paramref name="length"/> ist negativ.</exception><exception cref="T:System.ObjectDisposedException">Die Datei ist geschlossen.</exception><exception cref="T:System.IO.IOException">Der Prozess kann nicht auf die Datei zugreifen, weil ein Teil der Datei von einem anderen Prozess gesperrt wird.</exception>
        public void Lock(long position, long length)
        {
            m_orgFileStream.Lock(position, length);
        }
        /// <summary>
        /// Erm�glicht anderen Prozessen den Zugriff auf die gesamte Datei oder einen Teil der Datei, die zuvor gesperrt war.
        /// </summary>
        /// <param name="position">Der Anfang des zu entsperrenden Bereichs.</param><param name="length">Der zu entsperrende Bereich.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position"/> oder <paramref name="length"/> ist negativ.</exception>
        public void Unlock(long position, long length)
        {
            m_orgFileStream.Unlock(position, length);
        }
        /// <summary>
        /// Liest eine Folge von Bytes asynchron aus aktuellen Stream, erh�ht die Position im Stream um die Anzahl der gelesenen Bytes und �berwacht Abbruchanfragen.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Lesevorgang darstellt. Der Wert des <paramref name="TResult"/>-Parameters enth�lt die Gesamtzahl der Bytes, die in den Puffer gelesen werden. Der Ergebniswert kann niedriger als die Anzahl der angeforderten Bytes sein, wenn die Anzahl an derzeit verf�gbaren Bytes kleiner ist als die angeforderte Anzahl, oder sie kann 0 (null) sein, wenn das Datenstromende erreicht ist.
        /// </returns>
        /// <param name="buffer">Der Puffer, in den die Daten geschrieben werden sollen.</param><param name="offset">Der Byteoffset im <paramref name="buffer"/>, ab dem Daten aus dem Stream geschrieben werden.</param><param name="count">Die maximale Anzahl der zu lesenden Bytes.</param><param name="cancellationToken">Das Token zum �berwachen von Abbruchanforderungen .</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist gr��er als die Pufferl�nge.</exception><exception cref="T:System.NotSupportedException">Lesevorg�nge werden vom Stream nicht unterst�tzt.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird gerade durch einen fr�heren Lesevorgang.</exception>
        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return m_orgFileStream.ReadAsync(buffer, offset, count, cancellationToken);
        }
        /// <summary>
        /// Schreibt beim �berschreiben in einer abgeleiteten Klasse eine Folge von Bytes asynchron in den aktuellen Stream und erh�ht die aktuelle Position im Stream um die Anzahl der geschriebenen Bytes und �berwacht Abbruchanforderungen.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die den asynchronen Schreibvorgang darstellt.
        /// </returns>
        /// <param name="buffer">Der Puffer, aus dem Daten geschrieben werden sollen.</param><param name="offset">Der nullbasierte Byteoffset im <paramref name="buffer"/>, ab dem Bytes in den Stream kopiert werden.</param><param name="count">Die maximale Anzahl der zu schreibenden Bytes.</param><param name="cancellationToken">Das Token zum �berwachen von Abbruchanforderungen .</param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> ist null.</exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> oder <paramref name="count"/> ist negativ.</exception><exception cref="T:System.ArgumentException">Die Summe aus <paramref name="offset"/> und <paramref name="count"/> ist gr��er als die Pufferl�nge.</exception><exception cref="T:System.NotSupportedException">Der Stream unterst�tzt das Schreiben nicht.</exception><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception><exception cref="T:System.InvalidOperationException">Der Stream wird derzeit von einem vorherigen Schreibvorgang verwendet.</exception>
        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return m_orgFileStream.WriteAsync(buffer, offset, count, cancellationToken);
        }
        /// <summary>
        /// L�scht alle Puffer f�r diesen Stream asynchron und veranlasst die Ausgabe aller gepufferten Daten an das zugrunde liegende Ger�t und �berwacht Abbruchanforderungen.
        /// </summary>
        /// <returns>
        /// Eine Aufgabe, die die asynchrone Leerung darstellt.
        /// </returns>
        /// <param name="cancellationToken">Das Token zum �berwachen von Abbruchanforderungen .</param><exception cref="T:System.ObjectDisposedException">Der Stream wurde freigegeben.</exception>
        public Task FlushAsync(CancellationToken cancellationToken)
        {
            return m_orgFileStream.FlushAsync(cancellationToken);
        }
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob der aktuelle Stream Lesevorg�nge unterst�tzt.
        /// </summary>
        /// <returns>
        /// true, wenn der Stream Lesevorg�nge unterst�tzt, false, wenn der Stream geschlossen ist oder ausschlie�lich mit Schreibzugriff ge�ffnet wurde.
        /// </returns>
        public bool CanRead
        {
            get { return m_orgFileStream.CanRead; }
        }
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob der aktuelle Stream Schreibvorg�nge unterst�tzt.
        /// </summary>
        /// <returns>
        /// true, wenn der Stream Schreibvorg�nge unterst�tzt, false, wenn der Stream geschlossen ist oder mit schreibgesch�tztem Zugriff ge�ffnet wurde.
        /// </returns>
        public bool CanWrite
        {
            get { return m_orgFileStream.CanWrite; }
        }
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob der aktuelle Stream Suchvorg�nge unterst�tzt.
        /// </summary>
        /// <returns>
        /// true, wenn der Stream Suchvorg�nge unterst�tzt, false, wenn der Stream geschlossen ist oder der FileStream von einem Betriebssystemhandle, z.�B. einem Pipe oder einer Ausgabe in der Konsole, erstellt wurde.
        /// </returns>
        public bool CanSeek
        {
            get { return m_orgFileStream.CanSeek; }
        }
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob FileStream asynchron oder synchron ge�ffnet wurde.
        /// </summary>
        /// <returns>
        /// true, wenn FileStream asynchron ge�ffnet wurde, andernfalls false.
        /// </returns>
        public bool IsAsync
        {
            get { return m_orgFileStream.IsAsync; }
        }
        /// <summary>
        /// Ruft die L�nge des Streams in Bytes ab.
        /// </summary>
        /// <returns>
        /// Ein Long-Wert, der die L�nge des Streams in Bytes darstellt.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException"><see cref="P:System.IO.FileStream.CanSeek"/> ist f�r diesen Stream false.</exception><exception cref="T:System.IO.IOException">Es ist ein E/A-Fehler aufgetreten, beispielsweise das Schlie�en der Datei.</exception>
        public long Length
        {
            get { return m_orgFileStream.Length; }
        }
        /// <summary>
        /// Ruft den Namen des FileStream ab, der an den Konstruktor �bergeben wurde.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge, die den Namen von FileStream darstellt.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        public string Name
        {
            get { return m_orgFileStream.Name; }
        }
        /// <summary>
        /// Ruft die aktuelle Position dieses Streams ab oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Die aktuelle Position dieses Streams.
        /// </returns>
        /// <exception cref="T:System.NotSupportedException">Der Stream unterst�tzt keine Suchvorg�nge.</exception><exception cref="T:System.IO.IOException">Ein E/A-Fehler ist aufgetreten.  -�oder�- In Windows�98 oder fr�her wurde die Position auf einen sehr gro�en Wert nach dem Ende des Streams festgelegt.</exception><exception cref="T:System.ArgumentOutOfRangeException">Es wurde versucht, die Position auf einen negativen Wert festzulegen.</exception><exception cref="T:System.IO.EndOfStreamException">Es wurde versucht, eine Suche �ber ein Ende eines Streams hinaus auszuf�hren, der diesen Vorgang nicht unterst�tzt.</exception>
        public long Position
        {
            get { return m_orgFileStream.Position; }
            set { m_orgFileStream.Position = value; }
        }
        public Stream OrgStream => m_orgFileStream;
        private readonly FileStream m_orgFileStream;
        public FileStreamWrapper(FileStream orgFileStream)
        {
            m_orgFileStream = orgFileStream;
        }
        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    m_orgFileStream.Dispose();
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {

            Dispose(true);
            
        }
        #endregion
        
    }
}