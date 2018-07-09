using System;

namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class ByteArrayLongConverter : Convertable<long>
    {
        private readonly byte[] m_value;

        public ByteArrayLongConverter(byte[] value)
        {
            m_value = value;
        }
        protected override long Convert()
        {
            return BitConverter.ToInt64(m_value, 0);
        }

        public override long OrDefault(long defaultValue)
        {
            if (m_value == null || m_value.Length != 4) return defaultValue;
            return BitConverter.ToInt64(m_value, 0);
        }

        public override bool Works()
        {
            return m_value != null && m_value.Length == 8;
        }
    }
}