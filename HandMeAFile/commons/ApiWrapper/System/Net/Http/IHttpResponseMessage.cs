using System;
using System.Net;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http.Headers;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http
{
    public interface IHttpResponseMessage : IDisposable
    {
        Version Version { get; set; }
        IHttpContent Content { get; set; }
        HttpStatusCode StatusCode { get; set; }
        string ReasonPhrase { get; set; }
        IHttpResponseHeaders Headers { get; }
        bool IsSuccessStatusCode { get; }
        IHttpResponseMessage EnsureSuccessStatusCode();
    }
}