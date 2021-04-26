using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public static class XmlSerialisationExtensions
    {
        public static T XMLDeepClone<T>(this T objectToClone)
        {
            using var ms = new MemoryStream();
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(ms, objectToClone);
            ms.Seek(0, SeekOrigin.Begin);
            return (T) serializer.Deserialize(ms);
        }
    }
}