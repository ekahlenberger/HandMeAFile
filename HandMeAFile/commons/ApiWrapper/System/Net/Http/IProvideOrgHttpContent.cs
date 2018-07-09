using System.Net.Http;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Net.Http
{
    public interface IProvideOrgHttpContent
    {
        HttpContent OrgContent { get; }
    }
}