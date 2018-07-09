using System.Threading;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Threading
{
    public class ReaderWriterLockSlimProvider : IProvideReaderWriterLockSlim
    {
        public IReaderWriterLockSlim Provide()
        {
            return new ReaderWriterLockSlimWrapper(new ReaderWriterLockSlim());
        }
    }
}