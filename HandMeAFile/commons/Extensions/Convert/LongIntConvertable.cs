namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class LongIntConvertable : Convertable<int>
    {
        private readonly long m_value;

        public LongIntConvertable(long value)
        {
            m_value = value;
        }

        protected override int Convert()
        {
            return (int) m_value;
        }

        public override int OrDefault(int defaultValue)
        {
            if (m_value > int.MaxValue || m_value < int.MinValue) return defaultValue;
            return Convert();
        }

        public override bool Works()
        {
            return m_value <= int.MaxValue && m_value >= int.MinValue;
        }
    }
}