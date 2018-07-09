using Microsoft.Win32;

namespace org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32
{
    public class RegistryWrapper : IRegistry
    {
        public IRegistryKey LocalMachine => new RegistryKeyWrapper(Registry.LocalMachine);
        public IRegistryKey CurrentUser => new RegistryKeyWrapper(Registry.CurrentUser);
        public IRegistryKey Users => new RegistryKeyWrapper(Registry.Users);
        public IRegistryKey ClassesRoot => new RegistryKeyWrapper(Registry.ClassesRoot);
        public IRegistryKey CurrentConfig => new RegistryKeyWrapper(Registry.CurrentConfig);
        public IRegistryKey PerformanceData => new RegistryKeyWrapper(Registry.PerformanceData);
    }
}