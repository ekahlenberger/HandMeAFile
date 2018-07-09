namespace org.ek.HandMeAFile.commons.ApiWrapper.Microsoft.Win32
{
    public interface IRegistry
    {
        IRegistryKey LocalMachine { get; }
        IRegistryKey CurrentUser { get; }
        IRegistryKey Users { get; }
        IRegistryKey ClassesRoot { get; }
        IRegistryKey CurrentConfig { get; }
        IRegistryKey PerformanceData { get; }
    }
}