using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System
{
    public interface IEnvironment
    {
        string GetFolderPath(Environment.SpecialFolder folder);
    }
}