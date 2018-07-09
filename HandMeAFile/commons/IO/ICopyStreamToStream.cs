using System;
using System.Threading;
using System.Threading.Tasks;
using org.ek.HandMeAFile.commons.ApiWrapper.System.IO;

namespace org.ek.HandMeAFile.commons.IO
{
    public interface ICopyStreamToStream<TFrom,TTo> where TFrom : IStream where TTo : IStream
    {
        Task CopyAsync(TFrom from,TTo to, CancellationToken token, IProgress<GenericProgressInfo> progress);
    }
}