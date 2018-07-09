using System.Security.AccessControl;
using JetBrains.Annotations;
using Microsoft.Win32;
using org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32;

namespace org.ek.HandMeAFile.commons.Tools.Registry
{
    public interface IHelpWithRegistry
    {
        [Pure]
        IRegistryKey GetCorrespondingRoot(string keyPath);
        [Pure]
        IRegistryKey OpenKey(string keyPath, RegistryKeyPermissionCheck permissionCheck = default, RegistryRights rights = default);

        IRegistryKey CreateKey(string keyPath, RegistryKeyPermissionCheck permissionCheck = default);
    }
}