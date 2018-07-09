using System;
using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class IntegerExtensions
    {
        public static TimeSpan Seconds(this int seconds)
        {
            return new TimeSpan(0,0,0,seconds);
        }
        public static TimeSpan Minutes(this int minutes)
        {
            return new TimeSpan(0, 0, minutes,0);
        }
        public static TimeSpan Hours(this int hours)
        {
            return new TimeSpan(0, hours, 0, 0);
        }
        public static TimeSpan Days(this int days)
        {
            return new TimeSpan(days, 0, 0, 0);
        }
        public static Convertable<byte[]> ConvertToByteArray(this int i) => new IntToByteArrayConverter(i);
    }
}