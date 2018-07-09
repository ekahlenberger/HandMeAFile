using System.Threading;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ReaderWriterLockSlimExtensions
    {
        public static void ExitReadLockIfHeld(this ReaderWriterLockSlim @lock)
        {
            if (@lock.IsReadLockHeld) @lock.ExitReadLock();
        }
        public static void ExitUpgradeableReadLockIfHeld(this ReaderWriterLockSlim @lock)
        {
            if (@lock.IsUpgradeableReadLockHeld) @lock.ExitUpgradeableReadLock();
        }
        public static void ExitWriteLockIfHeld(this ReaderWriterLockSlim @lock)
        {
            if (@lock.IsWriteLockHeld) @lock.ExitWriteLock();
        }
        public static void ExitAllLocksIfHeld(this ReaderWriterLockSlim @lock)
        {
            @lock.ExitWriteLockIfHeld();
            @lock.ExitUpgradeableReadLockIfHeld();
            @lock.ExitReadLockIfHeld();
        }
    }
}