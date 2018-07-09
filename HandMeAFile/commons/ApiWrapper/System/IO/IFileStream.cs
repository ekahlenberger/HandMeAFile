namespace org.ek.HandMeAFile.commons.ApiWrapper.System.IO
{
    public interface IFileStream : IStream
    {

        /// <summary>
        /// Löscht die Puffer für diesen Datenstrom, veranlasst die Ausgabe aller gepufferten Daten in die Datei und löscht zudem alle Zwischendateipuffer.
        /// </summary>
        /// <param name="flushToDisk">true, um alle Zwischendateipuffer zu leeren, andernfalls false.</param>
        void Flush(bool flushToDisk);
        /// <summary>
        /// Verhindert, dass andere Prozesse im <see cref="T:System.IO.FileStream"/> lesen oder schreiben.
        /// </summary>
        /// <param name="position">Der Anfang des zu sperrenden Bereichs. Der Wert dieses Parameters muss größer oder gleich 0 sein.</param><param name="length">Der zu sperrende Bereich.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position"/> oder <paramref name="length"/> ist negativ.</exception><exception cref="T:System.ObjectDisposedException">Die Datei ist geschlossen.</exception><exception cref="T:System.IO.IOException">Der Prozess kann nicht auf die Datei zugreifen, weil ein Teil der Datei von einem anderen Prozess gesperrt wird.</exception>
        void Lock(long position, long length);
        /// <summary>
        /// Ermöglicht anderen Prozessen den Zugriff auf die gesamte Datei oder einen Teil der Datei, die zuvor gesperrt war.
        /// </summary>
        /// <param name="position">Der Anfang des zu entsperrenden Bereichs.</param><param name="length">Der zu entsperrende Bereich.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="position"/> oder <paramref name="length"/> ist negativ.</exception>
        void Unlock(long position, long length);
        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob FileStream asynchron oder synchron geöffnet wurde.
        /// </summary>
        /// <returns>
        /// true, wenn FileStream asynchron geöffnet wurde, andernfalls false.
        /// </returns>
        bool IsAsync { get; }
        /// <summary>
        /// Ruft den Namen des FileStream ab, der an den Konstruktor übergeben wurde.
        /// </summary>
        /// <returns>
        /// Eine Zeichenfolge, die den Namen von FileStream darstellt.
        /// </returns>
        /// <PermissionSet><IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true"/></PermissionSet>
        string Name { get; }
    }
}