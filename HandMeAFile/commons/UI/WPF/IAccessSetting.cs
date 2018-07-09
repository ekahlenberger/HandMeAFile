namespace org.ek.HandMeAFile.commons.UI.WPF
{
    public interface IAccessSetting<T>
    {
        void Set(T value);
        T Get();
    }
}