using System.Diagnostics;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public class ProcessStartInfoProvider : IProvideProcessStartInfo
    {
        public IProcessStartInfo Provide(string fileName, string arguments)
        {
            return new ProcessStartInfoWrapper(new ProcessStartInfo(fileName,arguments));
        }
    }
}