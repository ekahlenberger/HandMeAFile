using System;
using System.Diagnostics;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public class StopwatchWrapper : IStopwatch
    {
        /// <summary>
        /// Startet den Messvorgang der verstrichenen Zeit für ein Intervall oder nimmt diesen wieder auf.
        /// </summary>
        public void Start()
        {
            m_orgStopwatch.Start();
        }

        /// <summary>
        /// Beendet das Messen der verstrichenen Zeit für ein Intervall.
        /// </summary>
        public void Stop()
        {
            m_orgStopwatch.Stop();
        }

        /// <summary>
        /// Beendet die Zeitintervallmessung und setzt die verstrichene Zeit auf 0 (null) zurück.
        /// </summary>
        public void Reset()
        {
            m_orgStopwatch.Reset();
        }

        /// <summary>
        /// Beendet die Zeitintervallmessung, setzt die verstrichene Zeit auf 0 (null) zurück, und startet die Messung der verstrichenen Zeit.
        /// </summary>
        public void Restart()
        {
            m_orgStopwatch.Restart();
        }

        /// <summary>
        /// Ruft einen Wert ab, der angibt, ob der <see cref="T:System.Diagnostics.Stopwatch"/>-Zeitgeber ausgeführt wird.
        /// </summary>
        /// <returns>
        /// true, wenn die <see cref="T:System.Diagnostics.Stopwatch"/>-Instanz derzeit ausgeführt wird und die verstrichene Zeit für ein Intervall misst, andernfalls false.
        /// </returns>
        public bool IsRunning
        {
            get { return m_orgStopwatch.IsRunning; }
        }

        /// <summary>
        /// Ruft die gesamte verstrichene Zeit ab, die von der aktuellen Instanz gemessen wurde.
        /// </summary>
        /// <returns>
        /// Eine schreibgeschützte <see cref="T:System.TimeSpan"/>, die die gesamte, von der aktuellen Instanz gemessene verstrichene Zeit darstellt.
        /// </returns>
        public TimeSpan Elapsed
        {
            get { return m_orgStopwatch.Elapsed; }
        }

        /// <summary>
        /// Ruft die gesamte verstrichene Zeit in Millisekunden ab, die von der aktuellen Instanz gemessen wurde.
        /// </summary>
        /// <returns>
        /// Eine schreibgeschützte Long-Integer-Zahl, die die Gesamtanzahl der von der aktuellen Instanz gemessenen Millisekunden angibt.
        /// </returns>
        public long ElapsedMilliseconds
        {
            get { return m_orgStopwatch.ElapsedMilliseconds; }
        }

        /// <summary>
        /// Ruft die gesamte verstrichene Zeit, die von der aktuellen Instanz gemessen wurde, in Zeitgeberintervallen (Ticks) ab.
        /// </summary>
        /// <returns>
        /// Eine schreibgeschützte Long-Integer-Zahl, die die Gesamtanzahl der von der aktuellen Instanz gemessenen Zeitgeberintervalle angibt.
        /// </returns>
        public long ElapsedTicks
        {
            get { return m_orgStopwatch.ElapsedTicks; }
        }
        /// <summary>
        /// Runft die Frequenz des Zeitgebers als Anzahl der Ticks pro Sekunde ab. Dieses Feld is schreibgeschützt.
        /// </summary>
        public long Frequency => Stopwatch.Frequency;

        private readonly Stopwatch m_orgStopwatch;

        public StopwatchWrapper(Stopwatch orgStopwatch)
        {
            m_orgStopwatch = orgStopwatch;
        }
    }
}