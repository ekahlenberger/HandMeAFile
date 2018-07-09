using System.Diagnostics;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public interface IProvideOrgProcessStartInfo
    {
        ProcessStartInfo OrgInfo { get; }
    }
}