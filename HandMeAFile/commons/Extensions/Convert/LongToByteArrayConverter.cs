using System;

namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class LongToByteArrayConverter : Convertable<byte[]>
    {
        private readonly long m_value;

        public LongToByteArrayConverter(long value)
        {
            m_value = value;
        }
        protected override byte[] Convert()
        {
            return BitConverter.GetBytes(m_value);
        }

        public override byte[] OrDefault(byte[] defaultValue)
        {
            return Convert();
        }
    }
}