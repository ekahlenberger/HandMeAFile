using System;
using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class StringComparisonConvertable : Convertable<StringComparison>
    {
        private readonly PathComparison m_pc;

        public StringComparisonConvertable(PathComparison pc)
        {
            m_pc = pc;
        }

        protected override StringComparison Convert()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            return (StringComparison) Enum.Parse(typeof(StringComparison), Enum.GetName(typeof(PathComparison), m_pc));
        }

        public override StringComparison OrDefault(StringComparison defaultValue)
        {
            return Enum.TryParse(Enum.GetName(typeof(PathComparison), m_pc), out StringComparison sc) ? sc : defaultValue;
        }
    }
}