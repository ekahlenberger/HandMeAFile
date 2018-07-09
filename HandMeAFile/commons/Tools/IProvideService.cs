using System;

namespace org.ek.HandMeAFile.commons.Tools
{
    public interface IProvideService<T>
    {
        event EventHandler<T> ServiceSet;
        T Get();
        void Set(T service);
    }
}