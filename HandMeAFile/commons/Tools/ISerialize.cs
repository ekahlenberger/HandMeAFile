using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.Tools
{
    public interface ISerialize<T>
    {
        [Pure]
        Task<string> SerializeAsync(T[] objs, CancellationToken token);
        [Pure]
        Task<string> SerializeAsync(T obj, CancellationToken token);
        [ItemCanBeNull]
        [Pure]
        Task<T[]> DeserializeAsync(string serialized, CancellationToken token);
        [ItemCanBeNull]
        [Pure]
        Task<T> DeserializeSingleAsync(string serialized, CancellationToken token);
        [Pure]
        string Serialize(T[] objs);
        [Pure]
        string Serialize(T obj);
        [Pure]
        [CanBeNull]
        T[] Deserialize(string serialized);
        [Pure]
        [CanBeNull]
        T DeserializeSingle(string serialized);
    }
}