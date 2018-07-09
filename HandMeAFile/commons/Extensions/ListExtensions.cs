using System.Collections.Generic;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ListExtensions
    {
        public static bool AddSafe<T>(this List<T> l, T item)
        {
            if (item.IsNull() || l.IsNull() || !l.IsEmpty() && l.Contains(item)) return false;
            l.Add(item);
            return true;
        }
        public static void AddSafe<T>(this List<T> l, T[] items)
        {
            foreach (T item in items)
            {
                l.AddSafe(item);
            }
        }
    }
}