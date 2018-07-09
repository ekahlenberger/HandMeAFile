using System;

namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class ByteArrayIntConverter : Convertable<int>
    {
        private readonly byte[] m_value;

        public ByteArrayIntConverter(byte[] value)
        {
            m_value = value;
        }
        protected override int Convert()
        {
            return BitConverter.ToInt32(m_value, 0);
        }

        public override int OrDefault(int defaultValue)
        {
            if (m_value == null || m_value.Length != 4) return defaultValue;
            return BitConverter.ToInt32(m_value, 0);
        }

        public override bool Works()
        {
            return m_value != null && m_value.Length == 4;
        }
    }
}