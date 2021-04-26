using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerialization
{
    public static class BinarySerializationExtensions
    {
        public static T BinaryDeepClone<T>(this T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", nameof(source));
            }

            if (ReferenceEquals(source, null)) return default;

            using Stream stream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T) formatter.Deserialize(stream);
        }
    }
}