namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class ByteArrayBase64Converter : Convertable<string>
    {
        private readonly byte[] m_value;

        public ByteArrayBase64Converter(byte[] value)
        {
            m_value = value;
        }
        protected override string Convert()
        {
            return System.Convert.ToBase64String(m_value);
        }

        public override string OrDefault(string defaultValue)
        {
            if (m_value == null) return defaultValue;
            return System.Convert.ToBase64String(m_value);
        }

        public override bool Works()
        {
            return m_value != null;
        }
    }
}