namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class IntConvertable : Convertable<int>
    {
        private readonly string m_value;
        public IntConvertable(string value)
        {
            m_value = value;
        }

        protected override int Convert()
        {
            return int.Parse(m_value);
        }
        public override int OrDefault(int defaultValue)
        {
            if (int.TryParse(m_value, out int result)) return result;
            return defaultValue;
        }

        public override bool Works()
        {
            return int.TryParse(m_value, out _);
        }
    }
}