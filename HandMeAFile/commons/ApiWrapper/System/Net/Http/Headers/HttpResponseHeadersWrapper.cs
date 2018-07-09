using System.Net.Http.Headers;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http.Headers
{
    public class HttpResponseHeadersWrapper : IHttpResponseHeaders
    {
        private readonly HttpResponseHeaders m_orgHeaders;
        public HttpResponseHeadersWrapper(HttpResponseHeaders orgHeaders)
        {
            m_orgHeaders = orgHeaders;
        }

        public static implicit operator HttpResponseHeaders(HttpResponseHeadersWrapper wrapper)
        {
            return wrapper.m_orgHeaders;
        }
        public static implicit operator HttpResponseHeadersWrapper(HttpResponseHeaders headers)
        {
            return new HttpResponseHeadersWrapper(headers);
        }
    }
}