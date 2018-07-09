namespace org.ek.HandMeAFile.commons.Extensions.Convert
{
    public class BoolConvertable  : Convertable<bool>
    {
        private readonly string m_value;

        public BoolConvertable(string value)
        {
            m_value = value;
        }

        protected override bool Convert()
        {
            return bool.Parse(m_value);
        }

        public override bool OrDefault(bool defaultValue)
        {
            if (bool.TryParse(m_value, out bool ret)) return ret;
            return defaultValue;
        }

        public override bool Works()
        {
            return bool.TryParse(m_value, out _);
        }
    }
}