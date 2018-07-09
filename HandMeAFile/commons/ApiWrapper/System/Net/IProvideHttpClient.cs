using System.Net.Http;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net
{
    public interface IProvideHttpClient
    {
        IHttpClient Provide();
        IHttpClient Provide(HttpClientHandler handler);
    }
}