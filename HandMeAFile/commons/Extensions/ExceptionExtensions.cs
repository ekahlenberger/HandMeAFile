using System;
using System.Text;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ExceptionExtensions
    {
        public static string SerializeRecursively(this Exception e)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(e.Message);
            builder.AppendLine();
            builder.AppendLine(e.StackTrace);
            if (e.InnerException != null)
            {
                builder.AppendLine("-------------------------------------------");
                builder.AppendLine(e.InnerException.SerializeRecursively());
            }
            return builder.ToString();
        }
    }
}