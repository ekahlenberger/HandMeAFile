using System;
using System.Threading;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Threading
{
    public interface IReaderWriterLockSlim : IDisposable
    {
        /// <summary>Versucht, die Sperre im Lesemodus zu erhalten.</summary>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread befindet sich bereits im Lesemodus.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Diese Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        void EnterReadLock();

        /// <summary>Versucht, die Sperre im Lesemodus zu erhalten. Optional wird ein Timeout berücksichtigt.</summary>
        /// <returns>true, wenn der aufrufende Thread den Lesemodus erhalten hat, andernfalls false.</returns>
        /// <param name="timeout">Der Zeitintervall bis zum Timeout, oder -1 Millisekunden, um unbegrenzt zu warten.</param>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread hat die Sperre bereits erhalten.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Der Wert von <paramref name="timeout" /> ist negativ, aber ungleich -1 Millisekunden. (Dies ist der einzige zulässige negative Wert.) -oder- Der Wert von <paramref name="timeout" /> ist größer als <see cref="F:System.Int32.MaxValue" /> Millisekunden.</exception>
        bool TryEnterReadLock(TimeSpan timeout);

        /// <summary>Versucht, die Sperre im Lesemodus zu erhalten. Optional wird ein ganzzahliger Timeout berücksichtigt.</summary>
        /// <returns>true, wenn der aufrufende Thread den Lesemodus erhalten hat, andernfalls false.</returns>
        /// <param name="millisecondsTimeout">Die Zeit in Millisekunden, die gewartet wird, oder -1 (<see cref="F:System.Threading.Timeout.Infinite" />), um unbegrenzt zu warten.</param>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread hat die Sperre bereits erhalten.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Der Wert von <paramref name="millisecondsTimeout" /> ist negativ, aber ungleich <see cref="F:System.Threading.Timeout.Infinite" /> (-1), der den einzigen zulässigen negativen Wert darstellt.</exception>
        bool TryEnterReadLock(int millisecondsTimeout);

        /// <summary>Versucht, die Sperre im Schreibmodus zu erhalten.</summary>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und dem aktuellen Thread wurde die Sperre bereits in einem der Modi zugewiesen.  -oder- Der aktuelle Thread befindet sich im Lesemodus, sodass durch eine Zuweisung des Schreibmodus die Möglichkeit eines Deadlocks entstehen würde.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        void EnterWriteLock();

        /// <summary>Versucht, die Sperre im Schreibmodus zu erhalten. Optional wird ein Timeout berücksichtigt.</summary>
        /// <returns>true, wenn der aufrufende Thread den Schreibmodus erhalten hat, andernfalls false.</returns>
        /// <param name="timeout">Der Zeitintervall bis zum Timeout, oder -1 Millisekunden, um unbegrenzt zu warten.</param>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread hat die Sperre bereits erhalten.  -oder- Der aktuelle Thread befindet sich bereits im Lesemodus, sodass durch eine Zuweisung des Schreibmodus die Möglichkeit eines Deadlocks entstehen würde.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Der Wert von <paramref name="timeout" /> ist negativ, aber ungleich -1 Millisekunden. (Dies ist der einzige zulässige negative Wert.) -oder- Der Wert von <paramref name="timeout" /> ist größer als <see cref="F:System.Int32.MaxValue" /> Millisekunden.</exception>
        bool TryEnterWriteLock(TimeSpan timeout);

        /// <summary>Versucht, die Sperre im Schreibmodus zu erhalten. Optional wird ein Timeout berücksichtigt.</summary>
        /// <returns>true, wenn der aufrufende Thread den Schreibmodus erhalten hat, andernfalls false.</returns>
        /// <param name="millisecondsTimeout">Die Zeit in Millisekunden, die gewartet wird, oder -1 (<see cref="F:System.Threading.Timeout.Infinite" />), um unbegrenzt zu warten.</param>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread hat die Sperre bereits erhalten.  -oder- Der aktuelle Thread befindet sich bereits im Lesemodus, sodass durch eine Zuweisung des Schreibmodus die Möglichkeit eines Deadlocks entstehen würde.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Der Wert von <paramref name="millisecondsTimeout" /> ist negativ, aber ungleich <see cref="F:System.Threading.Timeout.Infinite" /> (-1), der den einzigen zulässigen negativen Wert darstellt.</exception>
        bool TryEnterWriteLock(int millisecondsTimeout);

        /// <summary>Versucht, die Sperre im erweiterbaren Modus zu erhalten.</summary>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und dem aktuellen Thread wurde die Sperre bereits in einem der Modi zugewiesen.  -oder- Der aktuelle Thread befindet sich im Lesemodus, sodass durch eine Zuweisung des erweiterbaren Modus die Möglichkeit eines Deadlocks entstehen würde.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        void EnterUpgradeableReadLock();

        /// <summary>Versucht, die Sperre im erweiterbaren Modus zu erhalten. Optional wird ein Timeout berücksichtigt.</summary>
        /// <returns>true, wenn der aufrufende Thread den erweiterbaren Modus erhalten hat, andernfalls false.</returns>
        /// <param name="timeout">Der Zeitintervall bis zum Timeout, oder -1 Millisekunden, um unbegrenzt zu warten.</param>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread hat die Sperre bereits erhalten.  -oder- Der aktuelle Thread befindet sich bereits im Lesemodus, sodass durch eine Zuweisung des erweiterbaren Modus die Möglichkeit eines Deadlocks entstehen würde.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Der Wert von <paramref name="timeout" /> ist negativ, aber ungleich -1 Millisekunden. (Dies ist der einzige zulässige negative Wert.) -oder- Der Wert von <paramref name="timeout" /> ist größer als <see cref="F:System.Int32.MaxValue" /> Millisekunden.</exception>
        bool TryEnterUpgradeableReadLock(TimeSpan timeout);

        /// <summary>Versucht, die Sperre im erweiterbaren Modus zu erhalten. Optional wird ein Timeout berücksichtigt.</summary>
        /// <returns>true, wenn der aufrufende Thread den erweiterbaren Modus erhalten hat, andernfalls false.</returns>
        /// <param name="millisecondsTimeout">Die Zeit in Millisekunden, die gewartet wird, oder -1 (<see cref="F:System.Threading.Timeout.Infinite" />), um unbegrenzt zu warten.</param>
        /// <exception cref="T:System.Threading.LockRecursionException">Die <see cref="P:System.Threading.ReaderWriterLockSlim.RecursionPolicy" />-Eigenschaft ist <see cref="F:System.Threading.LockRecursionPolicy.NoRecursion" />, und der aktuelle Thread hat die Sperre bereits erhalten.  -oder- Der aktuelle Thread befindet sich bereits im Lesemodus, sodass durch eine Zuweisung des erweiterbaren Modus die Möglichkeit eines Deadlocks entstehen würde.  -oder- Die Rekursionszahl würde die Kapazität des Zählers übersteigen. Die Kapazität ist so groß, dass Anwendungen diese Grenze niemals erreichen dürften.</exception>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Der Wert von <paramref name="millisecondsTimeout" /> ist negativ, aber ungleich <see cref="F:System.Threading.Timeout.Infinite" /> (-1), der den einzigen zulässigen negativen Wert darstellt.</exception>
        bool TryEnterUpgradeableReadLock(int millisecondsTimeout);

        /// <summary>Verringert die Rekursionszahl für den Lesemodus oder beendet den Lesemodus, wenn das Rekursionsergebnis 0 (null) ist.</summary>
        /// <exception cref="T:System.Threading.SynchronizationLockException">Der aktuelle Thread befindet sich nicht im Lesemodus.</exception>
        void ExitReadLock();

        /// <summary>Verringert die Rekursionszahl für den Schreibmodus oder beendet den Schreibmodus, wenn das Rekursionsergebnis 0 (null) ist.</summary>
        /// <exception cref="T:System.Threading.SynchronizationLockException">Der aktuelle Thread befindet sich nicht im Schreibmodus.</exception>
        void ExitWriteLock();

        /// <summary>Verringert die Rekursionszahl für den erweiterbaren Modus oder beendet den erweiterbaren Modus, wenn das Rekursionsergebnis 0 (null) ist.</summary>
        /// <exception cref="T:System.Threading.SynchronizationLockException">Der aktuelle Thread befindet sich nicht im erweiterbaren Modus.</exception>
        void ExitUpgradeableReadLock();

        /// <summary>Ruft einen Wert ab, der angibt, ob die Sperre dem aktuellen Thread im Lesemodus zugewiesen ist.</summary>
        /// <returns>true, wenn sich der aktuelle Thread im Lesemodus befindet, andernfalls false.</returns>
        bool IsReadLockHeld { get; }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Sperre dem aktuellen Thread im erweiterbaren Modus zugewiesen ist.</summary>
        /// <returns>true, wenn sich der aktuelle Thread im erweiterbaren Modus befindet, andernfalls false.</returns>
        bool IsUpgradeableReadLockHeld { get; }

        /// <summary>Ruft einen Wert ab, der angibt, ob die Sperre dem aktuellen Thread im Schreibmodus zugewiesen ist.</summary>
        /// <returns>true, wenn sich der aktuelle Thread im Schreibmodus befindet, andernfalls false.</returns>
        bool IsWriteLockHeld { get; }

        /// <summary>Ruft einen Wert ab, der die Rekursionsrichtlinie für das aktuelle <see cref="T:System.Threading.ReaderWriterLockSlim" />-Objekt angibt.</summary>
        /// <returns>Einer der Enumerationswerte, der die Rekursionsrichtlinie für die Sperre angibt.</returns>
        LockRecursionPolicy RecursionPolicy { get; }

        /// <summary>Ruft die Gesamtzahl von eindeutigen Threads ab, denen die Sperre im Lesemodus zugewiesen ist.</summary>
        /// <returns>Die Anzahl von eindeutigen Threads, denen die Sperre im Lesemodus zugewiesen ist.</returns>
        int CurrentReadCount { get; }

        /// <summary>Ruft einen Wert ab, der als Indikator für eine Rekursion angibt, wie oft dem aktuellen Thread die Sperre im Lesemodus zugewiesen ist.</summary>
        /// <returns>0 (null), wenn sich der aktuelle Thread nicht im Lesemodus befindet, 1, wenn sich der Thread im Lesemodus befindet und diesen nicht rekursiv angefordert hat, oder n, wenn der Thread die Sperre n - 1 Mal rekursiv angefordert hat.</returns>
        int RecursiveReadCount { get; }

        /// <summary>Ruft einen Wert ab, der als Indikator für eine Rekursion angibt, wie oft dem aktuellen Thread die Sperre im erweiterbaren Modus zugewiesen ist.</summary>
        /// <returns>0 (null), wenn sich der aktuelle Thread nicht im erweiterbaren Modus befindet, 1, wenn sich der Thread im erweiterbaren Modus befindet und diesen nicht rekursiv angefordert hat, oder n, wenn der Thread die Sperre n - 1 Mal rekursiv angefordert hat.</returns>
        int RecursiveUpgradeCount { get; }

        /// <summary>Ruft einen Wert ab, der als Indikator für eine Rekursion angibt, wie oft dem aktuellen Thread die Sperre im Schreibmodus zugewiesen ist.</summary>
        /// <returns>0 (null), wenn sich der aktuelle Thread nicht im Schreibmodus befindet, 1, wenn sich der Thread im Schreibmodus befindet und diesen nicht rekursiv angefordert hat, oder n, wenn der Thread die Sperre n - 1 Mal rekursiv angefordert hat.</returns>
        int RecursiveWriteCount { get; }

        /// <summary>Ruft die Gesamtzahl von Threads ab, die auf eine Zuweisung des Lesemodus warten.</summary>
        /// <returns>Die Gesamtzahl von Threads, die auf eine Zuweisung des Lesemodus warten.</returns>
        int WaitingReadCount { get; }

        /// <summary>Ruft die Gesamtzahl von Threads ab, die auf eine Zuweisung des erweiterbaren Modus warten.</summary>
        /// <returns>Die Gesamtzahl von Threads, die auf eine Zuweisung des erweiterbaren Modus warten.</returns>
        int WaitingUpgradeCount { get; }

        /// <summary>Ruft die Gesamtzahl von Threads ab, die auf eine Zuweisung des Schreibmodus warten.</summary>
        /// <returns>Die Gesamtzahl von Threads, die auf eine Zuweisung des Schreibmodus warten.</returns>
        int WaitingWriteCount { get; }
    }
}