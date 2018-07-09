using System.Collections.Concurrent;

namespace org.ek.HandMeAFile.commons.Extensions
{
    public static class ConcurrentDictionaryExtensions
    {
        public static void AddOrUpdate<TKey, TValue>(this ConcurrentDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            dict.AddOrUpdate(key, value, (updateKey, updateValue) => value);
        }
    }
}