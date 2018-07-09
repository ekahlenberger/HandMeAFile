using System;
using System.Security.AccessControl;
using JetBrains.Annotations;
using Microsoft.Win32;
using org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32;
using org.ek.HandMeAFile.commons.Extensions;

namespace org.ek.HandMeAFile.commons.Tools.Registry
{
    public class RegistryHelper : IHelpWithRegistry
    {
        private readonly IRegistry m_registry;
        public readonly string RegistryPathDelimiter = "\\";

        public RegistryHelper([NotNull] IRegistry registry)
        {
            m_registry = registry ?? throw new ArgumentNullException(nameof(registry));
        }
        [Pure]
        public IRegistryKey GetCorrespondingRoot(string keyPath)
        {
            IRegistryKey match = null;
            foreach (IRegistryKey rootKey in new[] { m_registry.ClassesRoot, m_registry.CurrentUser, m_registry.LocalMachine, m_registry.Users, m_registry.CurrentConfig })
            {
                if (match == null && keyPath.StartsWith(rootKey.Name))
                    match = rootKey;
                else
                    rootKey.Dispose();
            }
            return match;
        }
        [Pure]
        public IRegistryKey OpenKey(string keyPath, RegistryKeyPermissionCheck permissionCheck = default, RegistryRights rights = default)
        {
            IRegistryKey cleanUpKey = null;
            try
            {
                IRegistryKey root        = GetCorrespondingRoot(keyPath);
                string       openKeyName = keyPath.MustEndWith(RegistryPathDelimiter).Remove(root.Name.MustEndWith(RegistryPathDelimiter));
                if (openKeyName.IsNullOrWhitespace()) return root;
                cleanUpKey = root;
                IRegistryKey key = root.OpenSubKey(openKeyName, permissionCheck, rights);
                return key;
            }
            finally
            {
                cleanUpKey?.Dispose();
            }
        }
        [Pure]
        public IRegistryKey CreateKey(string keyPath, RegistryKeyPermissionCheck permissionCheck = default)
        {
            IRegistryKey cleanUpKey = null;
            if (!keyPath.Contains(RegistryPathDelimiter)) throw new ArgumentException("Can not create a root key itself", nameof(keyPath));
            try
            {
                IRegistryKey root        = GetCorrespondingRoot(keyPath);
                string       openKeyName = keyPath.MustEndWith(RegistryPathDelimiter).Remove(root.Name.MustEndWith(RegistryPathDelimiter));
                cleanUpKey = root;
                if (openKeyName.IsNullOrWhitespace()) throw new ArgumentException("Can not create a root key itself",nameof(keyPath));
                IRegistryKey key = root.CreateSubKey(openKeyName,permissionCheck);
                return key;
            }
            finally
            {
                cleanUpKey?.Dispose();
            }
        }
    }
}