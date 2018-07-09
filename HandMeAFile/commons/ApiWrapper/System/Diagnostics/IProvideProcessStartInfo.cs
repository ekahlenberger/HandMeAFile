namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public interface IProvideProcessStartInfo
    {
        IProcessStartInfo Provide(string fileName, string arguments);
    }
}