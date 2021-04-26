using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;
using AuxiliaryProjects.Core.extensions;

namespace CloneObject
{
    public static class CloneExtensions
    {
        public static T BinaryDeepClone<T>(this T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", nameof(source));
            }

            if (source.IsNullOrEmpty()) return default;

            using Stream stream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            return (T) formatter.Deserialize(stream);
        }
        
        public static T XMLDeepClone<T>(this T source)
        {
            if (source.IsNullOrEmpty()) return default;
            using var ms = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(ms, source);
            ms.Seek(0, SeekOrigin.Begin);
            return (T) serializer.Deserialize(ms);
        }
        
        public static T JsonDeepClone<T>(this T source)
        {
            if (source.IsNullOrEmpty()) return default;

            return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(source));
        }
    }
}