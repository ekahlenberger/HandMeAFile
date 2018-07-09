using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System
{
    public class EnvironmentWrapper : IEnvironment
    {
        public string GetFolderPath(Environment.SpecialFolder folder)
        {
            return Environment.GetFolderPath(folder);
        }
    }
}