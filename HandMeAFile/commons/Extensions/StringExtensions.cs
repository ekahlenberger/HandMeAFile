using System;
using System.Linq;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.Extensions.Convert;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class StringExtensions
    {
        [ContractAnnotation("null=>true")]
        public static bool IsNullOrWhitespace(this string s) => string.IsNullOrWhiteSpace(s);
        [ContractAnnotation("null=>true")]
        public static bool IsNullOrWhitespace(this NaturalString s) => string.IsNullOrWhiteSpace(s);

        [ContractAnnotation("null=>true")]
        public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);
        [ContractAnnotation("null=>true")]
        public static bool IsNullOrEmpty(this NaturalString s) => string.IsNullOrEmpty(s);

        [ContractAnnotation("s:null => null; s:notnull => notnull")]
        public static string Substitute(this string s, params object[] substitutes)
        {
            return s.IsNull() ? null : String.Format(s, substitutes);
        }

        public static Convertable<int> ConvertToInt(this string s) => new IntConvertable(s);
        public static Convertable<bool> ConvertToBool(this string s) => new BoolConvertable(s);
        public static Convertable<long> ConvertToLong(this string s) => new LongConvertable(s);
        public static Convertable<byte[]> ConvertToByteArray(this string s) => new StringToByteArrayConverter(s);
        public static Path AsRegistryPath(this string s) => new Path(s, "\\", StringComparison.OrdinalIgnoreCase);
        public static Path AsWindowsFilePath(this string s) => new Path(s, "\\", StringComparison.OrdinalIgnoreCase);

        [ContractAnnotation("s:null => null; s:notnull => notnull")]
        public static string Remove(this string s, string remove) => s?.Replace(remove ?? string.Empty, string.Empty);

        public static string JoinWith(this string s, string separator, params string[] partners)
        {
            if (s == null) s = string.Empty;
            return partners?.Where(p => p != null).Aggregate(s, (aggregate, partner) => aggregate.EndsWith(separator) ? aggregate + partner : aggregate + separator + partner) ?? s;
        }

        public static string MustEndWith(this string s, string suffix)
        {
            if (s == null) return null;  
            if (s.EndsWith(suffix)) return s;
            return s + suffix;
        }
    }
}