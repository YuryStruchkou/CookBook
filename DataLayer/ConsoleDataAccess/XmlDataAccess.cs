using System;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataLayer.ConsoleDataAccess
{
    public abstract class XmlDataAccess<T>
    {
        protected readonly string _xmlFileLocation;
        protected readonly XmlSerializer _serializer = new XmlSerializer(typeof(T));
        protected string _rootElementName;

        public XmlDataAccess (string xmlFileLocation, string rootElementName)
        {
            _xmlFileLocation = xmlFileLocation;
            _rootElementName = rootElementName;
        }

        public abstract void Add(T item);

        public abstract void Update(T item, Func<T, bool> predicate);

        public abstract void Delete(Func<T, bool> predicate);

        public abstract T Get(Func<T, bool> predicate);
    }
}
