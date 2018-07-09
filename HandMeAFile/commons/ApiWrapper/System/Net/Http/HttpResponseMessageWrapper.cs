using System;
using System.Net;
using System.Net.Http;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http.Headers;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http
{
    public class HttpResponseMessageWrapper : IHttpResponseMessage
    {
        public Version Version
        {
            get { return m_orgMessage.Version; }
            set { m_orgMessage.Version = value; }
        }
        public IHttpContent Content
        {
            get { return (HttpContentWrapper)m_orgMessage.Content; }
            // ReSharper disable once SuspiciousTypeConversion.Global
            set { m_orgMessage.Content = (HttpContent)value; }
        }
        public HttpStatusCode StatusCode
        {
            get { return m_orgMessage.StatusCode; }
            set { m_orgMessage.StatusCode = value; }
        }
        public string ReasonPhrase
        {
            get { return m_orgMessage.ReasonPhrase; }
            set { m_orgMessage.ReasonPhrase = value; }
        }
        public IHttpResponseHeaders Headers => (HttpResponseHeadersWrapper)m_orgMessage.Headers;
        public bool IsSuccessStatusCode => m_orgMessage.IsSuccessStatusCode;
        private readonly HttpResponseMessage m_orgMessage;
        public HttpResponseMessageWrapper(HttpResponseMessage orgMessage)
        {
            m_orgMessage = orgMessage;

        }
        public IHttpResponseMessage EnsureSuccessStatusCode()
        {
            return new HttpResponseMessageWrapper(m_orgMessage.EnsureSuccessStatusCode());
        }
        #region IDisposable Support
        private bool disposedValue; // Dient zur Erkennung redundanter Aufrufe.
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    m_orgMessage.Dispose();
                }
                disposedValue = true;
            }
        }
        // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
            Dispose(true);
            
        }
        #endregion
        public static implicit operator HttpResponseMessage(HttpResponseMessageWrapper wrapper)
        {
            return wrapper.m_orgMessage;
        }
        public static implicit operator HttpResponseMessageWrapper(HttpResponseMessage message)
        {
            return new HttpResponseMessageWrapper(message);
        }
    }
}