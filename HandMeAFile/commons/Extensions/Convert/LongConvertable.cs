namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class LongConvertable : Convertable<long>
    {
        private readonly string m_value;

        public LongConvertable(string value)
        {
            m_value = value;
        }
        protected override long Convert()
        {
            return long.Parse(m_value);
        }

        public override long OrDefault(long defaultValue)
        {
            if (long.TryParse(m_value, out long val)) return val;
            return defaultValue;
        }

        public override bool Works()
        {
            return long.TryParse(m_value, out _);
        }
    }
}