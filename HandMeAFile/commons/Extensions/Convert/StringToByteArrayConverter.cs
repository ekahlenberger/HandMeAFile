using System.Text;

namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class StringToByteArrayConverter : Convertable<byte[]>
    {
        private readonly string m_value;
        private static readonly Encoding Enc = Encoding.UTF8;

        public StringToByteArrayConverter(string value)
        {
            m_value = value;
        }
        protected override byte[] Convert()
        {
            return Enc.GetBytes(m_value);
        }

        public override byte[] OrDefault(byte[] defaultValue)
        {
            if (m_value == null) return defaultValue;
            return Convert();
        }

        public override bool Works()
        {
            return m_value != null;
        }
    }
}