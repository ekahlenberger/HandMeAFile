using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ByteArrayExtensions
    {
        public static Convertable<string> ConvertToBase64String(this byte[] b) => new ByteArrayBase64Converter(b);
        public static Convertable<string> ConvertToUtf8String(this byte[] b) => new ByteArrayUtf8Converter(b);
        public static Convertable<int> ConvertToInt(this byte[] b) => new ByteArrayIntConverter(b);
        public static Convertable<long> ConvertToLong(this byte[] b) => new ByteArrayLongConverter(b);
    }
}