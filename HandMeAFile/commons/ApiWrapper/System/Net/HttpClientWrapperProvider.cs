using System.Net.Http;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net
{
    public class HttpClientWrapperProvider : IProvideHttpClient
    {
        public IHttpClient Provide(HttpClientHandler handler)
        {
            return new HttpClientWrapper(new HttpClient(handler));
        }
        public IHttpClient Provide()
        {
            return new HttpClientWrapper(new HttpClient());
        }

    }
}