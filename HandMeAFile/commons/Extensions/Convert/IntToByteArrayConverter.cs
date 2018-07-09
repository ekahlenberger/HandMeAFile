using System;

namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class IntToByteArrayConverter : Convertable<byte[]>
    {
        private readonly int m_value;

        public IntToByteArrayConverter(int value)
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