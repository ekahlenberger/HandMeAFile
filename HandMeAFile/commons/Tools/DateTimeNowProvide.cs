using System;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class DateTimeNowProvide : IProvideNow
    {
        /// <inheritdoc />
        public DateTime Now => DateTime.Now;
        /// <inheritdoc />
        public DateTime UtcNow => DateTime.UtcNow;
    }
}