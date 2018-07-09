using System.Security.AccessControl;

namespace org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32
{
    public class RegistrySecurityWrapper : IRegistrySecurity, IProvideOrgRegistrySecurity
    {
        private readonly RegistrySecurity m_sec;
        public RegistrySecurity OrgSecurity => m_sec;

        public RegistrySecurityWrapper(RegistrySecurity sec)
        {
            m_sec = sec;
        }

        
    }
}