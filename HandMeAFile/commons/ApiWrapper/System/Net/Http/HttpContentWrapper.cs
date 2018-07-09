using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using org.ek.HandMeAFile.commons.ApiWrapper.System.IO;

// ReSharper disable SuspiciousTypeConversion.Global

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http
{
    public class HttpContentWrapper : IHttpContent, IProvideOrgHttpContent
    {
        public Task<string> ReadAsStringAsync()
        {
            return m_orgContent.ReadAsStringAsync();
        }
        public Task<byte[]> ReadAsByteArrayAsync()
        {
            return m_orgContent.ReadAsByteArrayAsync();
        }
        public Task<IStream> ReadAsStreamAsync()
        {
            return m_orgContent.ReadAsStreamAsync().ContinueWith<IStream>(t => new StreamWrapper(t.Result));
        }
        public Task CopyToAsync(IStream stream, ITransportContext context)
        {
            return m_orgContent.CopyToAsync((Stream)stream, (TransportContext)context);
        }
        public Task CopyToAsync(IStream stream)
        {
            return m_orgContent.CopyToAsync((Stream)stream);
        }
        public Task LoadIntoBufferAsync()
        {
            return m_orgContent.LoadIntoBufferAsync();
        }
        public Task LoadIntoBufferAsync(long maxBufferSize)
        {
            return m_orgContent.LoadIntoBufferAsync(maxBufferSize);
        }
        public HttpContentHeaders Headers => m_orgContent.Headers;
        private readonly HttpContent m_orgContent;
        public HttpContent OrgContent => m_orgContent;
        public HttpContentWrapper(HttpContent orgContent)
        {
            m_orgContent = orgContent;
        }

        #region IDisposable Support
        private bool m_disposedValue; // Dient zur Erkennung redundanter Aufrufe.
        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposedValue)
            {
                if (disposing)
                {
                    m_orgContent.Dispose();
                }
                m_disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
        public static explicit operator HttpContent(HttpContentWrapper wrapper)
        {
            return wrapper.m_orgContent;
        }
        public static implicit operator HttpContentWrapper(HttpContent content)
        {
            return new HttpContentWrapper(content);
        }
    }
}