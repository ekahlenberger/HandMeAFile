using System;
using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Tools
{
    public static class PathComparisonExtension
    {
        public static Convertable<StringComparison> ConvertToStringComparison(this PathComparison pc) => new StringComparisonConvertable(pc);
    }
}