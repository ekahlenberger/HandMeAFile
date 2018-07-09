namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public interface IStartProcesses
    {
        IProcess Start(IProcessStartInfo psi);
        IProcess Start(string fileName, string arguments);
    }
}