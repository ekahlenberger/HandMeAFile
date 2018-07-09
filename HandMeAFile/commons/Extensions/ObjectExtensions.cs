using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ObjectExtensions
    {
        [ContractAnnotation("null=>true")]
        public static bool IsNull(this object o)
        {
            return o == null;
        }
        [ContractAnnotation("null=>false")]
        public static bool IsNotNull(this object o)
        {
            return !o.IsNull();
        }

        public static Convertable<int> ConvertToInt(this object o) => new IntConvertable(o?.ToString());
        public static Convertable<bool> ConvertToBool(this object o)  => new BoolConvertable(o?.ToString());
        public static Convertable<long> ConvertToLong(this object o) => new LongConvertable(o?.ToString());
    }
}