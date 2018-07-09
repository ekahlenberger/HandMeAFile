using System;
using System.Diagnostics;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System.Diagnostics
{
    public class ProcessStarter : IStartProcesses
    {
        public IProcess Start(IProcessStartInfo psi)
        {
            IProvideOrgProcessStartInfo orgProvider = psi as IProvideOrgProcessStartInfo;
            if (orgProvider == null) throw new ArgumentException("Missing Implementation of IProvideOrgProcessStartInfo to provide interoperability with the framework", nameof(psi));
            return new ProcessWrapper(Process.Start(orgProvider.OrgInfo));
        }

        public IProcess Start(string fileName, string arguments)
        {
            return new ProcessWrapper(Process.Start(fileName,arguments));
        }
    }
}