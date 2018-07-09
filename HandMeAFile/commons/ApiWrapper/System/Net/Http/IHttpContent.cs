using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using org.ek.HandMeAFile.commons.ApiWrapper.System.IO;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http
{
    public interface IHttpContent : IDisposable
    {
        Task<string> ReadAsStringAsync();
        Task<byte[]> ReadAsByteArrayAsync();
        Task<IStream> ReadAsStreamAsync();
        Task CopyToAsync(IStream stream, ITransportContext context);
        Task CopyToAsync(IStream stream);
        Task LoadIntoBufferAsync();
        Task LoadIntoBufferAsync(long maxBufferSize);
        HttpContentHeaders Headers { get; }
    }
}