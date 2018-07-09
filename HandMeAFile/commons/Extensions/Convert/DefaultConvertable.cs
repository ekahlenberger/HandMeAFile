namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class DefaultConvertable<T> : Convertable<T>
    {
        private readonly T m_value;

        public DefaultConvertable(T value)
        {
            m_value = value;
        }
        protected override T Convert()
        {
            return m_value;
        }

        public override T OrDefault(T defaultValue)
        {
            return defaultValue;
        }
    }
}