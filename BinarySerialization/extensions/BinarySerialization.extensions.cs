using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DeepCopyObject.extensions
{
    public static class BinarySerializationExtensions
    {
        private static bool IsSerializable<T>(this T obj)
        {
            if (obj == null)
                return false;

            Type t = obj.GetType();
            return t.IsSerializable;
        }
        public static T BinaryDeepCopy<T>(this T objectToDeepClone)
        {
            if(!objectToDeepClone.IsSerializable())
                throw new SerializationException("class should be Serializable");
            
            using MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter
            {
                Context = new StreamingContext(StreamingContextStates.Clone)
            };
            formatter.Serialize(ms, objectToDeepClone);
            ms.Position = 0;
            return (T)formatter.Deserialize(ms);
        }
    }
}