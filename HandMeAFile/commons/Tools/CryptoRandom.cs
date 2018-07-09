using System;
using System.Security.Cryptography;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class CryptoRandom : Random, ICreateRandomValues
    {
        private readonly RNGCryptoServiceProvider m_rng = new RNGCryptoServiceProvider();
        private readonly byte[] m_uint32Buffer = new byte[4];

        public override int Next()
        {
            m_rng.GetBytes(m_uint32Buffer);
            return BitConverter.ToInt32(m_uint32Buffer, 0) & int.MaxValue;
        }

        public override int Next(int maxValue)
        {
            if (maxValue < 0)
                throw new ArgumentOutOfRangeException(nameof(maxValue));
            return Next(0, maxValue);
        }

        public override int Next(int minValue, int maxValue)
        {
            return (int)InternalNextLong(minValue, maxValue);
        }

        public override double NextDouble()
        {
            m_rng.GetBytes(m_uint32Buffer);
            return BitConverter.ToUInt32(m_uint32Buffer, 0) / 4294967296.0;
        }
        public override void NextBytes(byte[] buffer)
        {
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            m_rng.GetBytes(buffer);
        }
        public uint NextUint(uint minValue, uint maxValue)
        {
            return (uint)InternalNextLong(minValue, maxValue);
        }
        protected long InternalNextLong(long minValue, long maxValue)
        {
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException(nameof(minValue));
            if (minValue == maxValue)
                return minValue;
            long num1 = maxValue - minValue;
            uint num2;
            long num3;
            long num4;
            do
            {
                m_rng.GetBytes(m_uint32Buffer);
                num2 = BitConverter.ToUInt32(m_uint32Buffer, 0);
                num3 = 4294967296L;
                num4 = num3 % num1;
            } while (num2 >= num3 - num4);
            return (minValue + num2 % num1);
        }
        public ulong NextULong(ulong minValue, ulong maxValue)
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException(nameof(minValue), "maxValue must be bigger than minValue");

            byte[] bytes = new byte[8];

            if (minValue == maxValue)
                return minValue;
            ulong range = maxValue - minValue;
            ulong value;
            const ulong typeMax = ulong.MaxValue;
            ulong remainings;
            do
            {
                m_rng.GetBytes(bytes);
                value = BitConverter.ToUInt64(bytes, 0);
                remainings = typeMax % range;
            } while (value >= typeMax - remainings);
            return (minValue + value % range);
        }
    }
}
