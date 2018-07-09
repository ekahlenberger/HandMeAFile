using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public interface IStopwatch
    {
        /// <summary>
        /// Startet den Messvorgang der verstrichenen Zeit für ein Intervall oder nimmt diesen wieder auf.
        /// </summary>
        void Start();

        /// <summary>
        /// Beendet das Messen der verstrichenen Zeit für ein Intervall.
        /// </summary>
        void Stop();

        /// <summary>
        /// Beendet die Zeitintervallmessung und setzt die verstrichene Zeit auf 0 (null) zurück.
        /// </summary>
        void Reset();

        /// <summary>
        /// Beendet die Zeitintervallmessung, setzt die verstrichene Zeit auf 0 (null) zurück, und startet die Messung der verstrichenen Zeit.
        /// </summary>
        void Restart();

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob der <see cref="T:System.Diagnostics.Stopwatch"/>-Zeitgeber ausgeführt wird.
        /// </summary>
        /// <returns>
        /// true, wenn die <see cref="T:System.Diagnostics.Stopwatch"/>-Instanz derzeit ausgeführt wird und die verstrichene Zeit für ein Intervall misst, andernfalls false.
        /// </returns>
        bool IsRunning { get; }

        /// <summary>
        /// Ruft die gesamte verstrichene Zeit ab, die von der aktuellen Instanz gemessen wurde.
        /// </summary>
        /// <returns>
        /// Eine schreibgeschützte <see cref="T:System.TimeSpan"/>, die die gesamte, von der aktuellen Instanz gemessene verstrichene Zeit darstellt.
        /// </returns>
        TimeSpan Elapsed { get; }

        /// <summary>
        /// Ruft die gesamte verstrichene Zeit in Millisekunden ab, die von der aktuellen Instanz gemessen wurde.
        /// </summary>
        /// <returns>
        /// Eine schreibgeschützte Long-Integer-Zahl, die die Gesamtanzahl der von der aktuellen Instanz gemessenen Millisekunden angibt.
        /// </returns>
        long ElapsedMilliseconds { get; }

        /// <summary>
        /// Ruft die gesamte verstrichene Zeit, die von der aktuellen Instanz gemessen wurde, in Zeitgeberintervallen (Ticks) ab.
        /// </summary>
        /// <returns>
        /// Eine schreibgeschützte Long-Integer-Zahl, die die Gesamtanzahl der von der aktuellen Instanz gemessenen Zeitgeberintervalle angibt.
        /// </returns>
        long ElapsedTicks { get; }

        /// <summary>
        /// Runft die Frequenz des Zeitgebers als Anzahl der Ticks pro Sekunde ab. Dieses Feld is schreibgeschützt.
        /// </summary>
        long Frequency { get; }
    }
}