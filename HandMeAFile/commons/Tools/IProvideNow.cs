using System;

namespace org.ek.HandMeAFile.commons.Tools
{
    public interface IProvideNow
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
    }
}