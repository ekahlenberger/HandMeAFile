using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;
using org.ek.HandMeAFile.commons.Extensions;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class GenericSerializer<T> : ISerialize<T>
    {
        /// <inheritdoc />
        public Task<string> SerializeAsync(T[] objs, CancellationToken token)
        {
            return Task.Run(() => Serialize(objs), token);
        }
        /// <inheritdoc />
        public string Serialize(T[] objs)
        {
            if (!objs.Any() || objs[0] == null) return null;
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(memStream, objs);
                return Convert.ToBase64String(memStream.ToArray());
            }
        }
        /// <inheritdoc />
        public Task<T[]> DeserializeAsync(string serialized, CancellationToken token)
        {
            return Task.Run(() => Deserialize(serialized), token);
        }
        /// <inheritdoc />
        public T[] Deserialize(string serialized)
        {
            if (string.IsNullOrWhiteSpace(serialized)) return new T[0];
            using (MemoryStream memStream = new MemoryStream(Convert.FromBase64String(serialized)))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                return serializer.Deserialize(memStream) as T[];
            }
        }
        /// <inheritdoc />
        public Task<string> SerializeAsync(T obj, CancellationToken token)
        {
            return SerializeAsync(new T[] {obj}, token);
        }
        /// <inheritdoc />
        public Task<T> DeserializeSingleAsync(string serialized, CancellationToken token)
        {
            return Task.Run(() => DeserializeSingle(serialized), token);
        }
        /// <inheritdoc />
        public string Serialize(T obj)
        {
            return Serialize(new T[] {obj});
        }
        /// <inheritdoc />
        public T DeserializeSingle(string serialized)
        {
            T[] deserialized = Deserialize(serialized);
            if (!deserialized.IsNullOrEmpty()) return deserialized[0];
            return default(T);
        }
    }
}