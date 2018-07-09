using System.Text;

namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class ByteArrayUtf8Converter : Convertable<string>
    {
        private readonly byte[] m_value;
        private static readonly Encoding Enc = Encoding.UTF8;

        public ByteArrayUtf8Converter(byte[] value)
        {
            m_value = value;
        }
        protected override string Convert()
        {
            return Enc.GetString(m_value);
        }

        public override string OrDefault(string defaultValue)
        {
            try
            {
                return Enc.GetString(m_value);
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}