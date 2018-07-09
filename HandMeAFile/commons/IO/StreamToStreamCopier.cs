using System;
using System.Threading;
using System.Threading.Tasks;
using org.ek.HandMeAFile.commons.ApiWrapper.System.IO;

namespace org.ek.HandMeAFile.commons.IO
{
    public class StreamToStreamCopier<TFrom,TTo> : ICopyStreamToStream<TFrom,TTo> where TFrom : IStream where TTo : IStream
    { 
        public async Task CopyAsync(TFrom from, TTo to, CancellationToken token, IProgress<GenericProgressInfo> progress)
        {
            int readCount;
            long totalCopiedCount = 0;
            long totalCount = 0;
            byte[] buffer1 = new byte[81920];
            byte[] buffer2 = new byte[81920];
            byte[] buffer = buffer1;
            if (from.CanSeek)
                totalCount = from.Length;
            Task writeTask = null;
            while ((readCount = await from.ReadAsync(buffer, 0, 4096, token)) != 0)
            {
                if (writeTask != null) await writeTask;
                writeTask = to.WriteAsync(buffer, 0, readCount, token);
                totalCopiedCount += readCount;
                progress.Report(new GenericProgressInfo(readCount, totalCopiedCount, totalCount));
                buffer = buffer == buffer1 ? buffer2 : buffer1;
            }
        }
    }
}