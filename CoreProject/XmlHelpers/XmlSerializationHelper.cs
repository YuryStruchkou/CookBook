using System;
using System.IO;
using System.Xml.Serialization;

namespace CoreProject
{
    public static class XmlSerializationHelper<T>
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(T));

        public static void Serialize(string file, T obj)
        {
            using (var fs = new FileStream(file, FileMode.Create))
            {
                serializer.Serialize(fs, obj);
            }
        }

        public static T Deserialize(string file)
        {
            using (var fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                try
                {
                    return (T) serializer.Deserialize(fs);
                }
                catch (Exception e)
                {
                    return default(T);
                }
                
            }
        }
    }
}
