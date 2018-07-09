using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class LongExtensions
    {
        public static Convertable<int> ConvertToInt(this long l) => new LongIntConvertable(l);
        public static Convertable<byte[]> ConvertToByteArray(this long l) => new LongToByteArrayConverter(l);
    }
}