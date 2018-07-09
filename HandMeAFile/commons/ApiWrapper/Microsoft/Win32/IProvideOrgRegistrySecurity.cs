using System.Security.AccessControl;

namespace org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32
{
    public interface IProvideOrgRegistrySecurity
    {
        RegistrySecurity OrgSecurity { get; }
    }
}