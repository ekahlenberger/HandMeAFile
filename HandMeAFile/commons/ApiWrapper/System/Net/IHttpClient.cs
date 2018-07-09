using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net
{
    public interface IHttpClient
    {
        /// <summary>
        /// Eine GET-Anforderung für den angegebenen URI mit einem Abbruchtoken als asynchronen Vorgang senden.
        /// </summary>
        /// <returns>
        /// Gibt <see cref="T:System.Threading.Tasks.Task`1"/> zurück.
        /// </returns>
        /// <param name="requestUri">Der URI, an den die Anforderung gesendet wird.</param><param name="cancellationToken">Ein Abbruchtoken, das von anderen Objekten oder Threads verwendet werden kann, um Nachricht vom Abbruch zu empfangen.</param><exception cref="T:System.ArgumentNullException"><paramref name="requestUri"/> war null.</exception>
        Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken);
        /// <summary>
        /// Eine POST-Anforderung mit einem Abbruchtoken als asynchronen Vorgang senden.
        /// </summary>
        /// <returns>
        /// Gibt <see cref="T:System.Threading.Tasks.Task`1"/> zurück. Das Aufgabenobjekt, das den asynchronen Vorgang darstellt.
        /// </returns>
        /// <param name="requestUri">Der URI, an den die Anforderung gesendet wird.</param><param name="content">Der Inhalt der HTTP-Anforderung, die an den Server gesendet wird.</param><param name="cancellationToken">Ein Abbruchtoken, das von anderen Objekten oder Threads verwendet werden kann, um Nachricht vom Abbruch zu empfangen.</param><exception cref="T:System.ArgumentNullException"><paramref name="requestUri"/> war null.</exception>
        Task<HttpResponseMessage> PostAsync(string requestUri, IHttpContent content, CancellationToken cancellationToken);
        /// <summary>
        /// Ruft die Basisadresse des URI (Uniform Resource Identifier) der Internetressource ab, die verwendet wird, wenn Anforderungen gesendet werden, oder legt diese fest.
        /// </summary>
        /// <returns>
        /// Gibt <see cref="T:System.Uri"/> zurück. Die Basisadresse des URI (Uniform Resource Identifier) der Internetressource, die verwendet wird, wenn Anforderungen gesendet werden.
        /// </returns>
        Uri BaseAddress { get; set; }
        /// <summary>
        /// Eine GET-Anforderung an den angegebenen URI mit einer HTTP-Abschlussoption und einem Abbruchtoken als asynchronen Vorgang senden.
        /// </summary>
        /// <returns>
        /// Gibt <see cref="T:System.Threading.Tasks.Task`1"/> zurück.
        /// </returns>
        /// <param name="requestUri">Der URI, an den die Anforderung gesendet wird.</param><param name="completionOption">Ein HTTP-Abschlussoptions-Wert, der angibt, wann die Operation als abgeschlossen betrachtet werden soll.</param><param name="cancellationToken">Ein Abbruchtoken, das von anderen Objekten oder Threads verwendet werden kann, um Nachricht vom Abbruch zu empfangen.</param><exception cref="T:System.ArgumentNullException"><paramref name="requestUri"/> war null.</exception>
        Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken);
    }
}