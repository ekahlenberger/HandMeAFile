namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public abstract class Convertable<T>
    {
        protected abstract T Convert();
        public abstract T OrDefault(T defaultValue);
        public virtual bool Works()
        {
            try
            {
                Convert();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static implicit operator T(Convertable<T> obj)
        {
            return obj.Convert();
        }
    }
}