using System;
using System.IO;
using System.Xml.Serialization;
using CoreProject.LoggingHelpers;
using CoreProject.XmlHelpers;

namespace CoreProject
{
    public static class XmlSerializationHelper<T>
    {
        private static XmlSerializer serializer = new XmlSerializer(typeof(T));

        public static void Serialize(string file, T obj)
        {
            try
            {
                using (var fs = new FileStream(file, FileMode.Create))
                {
                    serializer.Serialize(fs, obj);
                }
            }
            catch (Exception e)
            {
                LoggingHelper.log.Error("Error occured during serialization.", e);
                throw new SerializationException("Error during XMLSerialization.", e);
            }
        }

        public static T Deserialize(string file)
        {
            try
            {
                using (var fs = new FileStream(file, FileMode.OpenOrCreate))
                {
                    try
                    {
                        return (T)serializer.Deserialize(fs);
                    }
                    catch (Exception e)
                    {
                        LoggingHelper.log.Warn("Exception was thrown while deserializing. Returning default value.", e);
                        return default(T);
                    }
                }
            }
            catch (Exception e)
            {
                LoggingHelper.log.Error("Error occured during deserialization.", e);
                throw new SerializationException("Error during XMLDeserialization.", e);
            }
        }
    }
}
