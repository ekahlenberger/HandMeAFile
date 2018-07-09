using System;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.UI.WPF
{
    public class GenericFunctionsSettingsAccessor<T> : IAccessSetting<T>
    {
        public Action<T> Setter { get; [UsedImplicitly] set; }
        public Func<T> Getter { get; [UsedImplicitly] set; }
        public void Set(T value)
        {
            Setter(value);
        }

        public T Get()
        {
            return Getter();
        }
    }
}