using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataLayer.ConsoleDataAccess
{
    public abstract class XmlDataAccess<T>
    {
        protected readonly string _xmlFileLocation;
        protected readonly XmlSerializer _serializer = new XmlSerializer(typeof(T));
        protected readonly XDocument _xDoc;
        protected string _rootElementName;

        
        public XmlDataAccess (string xmlFileLocation, string rootElementName)
        {
            _xmlFileLocation = xmlFileLocation;
            _rootElementName = rootElementName;
            _xDoc = XDocument.Load(xmlFileLocation);
        }

        public void Add(T item)
        {
            var rootElement = _xDoc.Element(_rootElementName);
            rootElement.Add(ConvertToXml(item));
            _xDoc.Save(_xmlFileLocation);
        }

        public void Update(T item, Func<T, bool> predicate)
        {
            var rootElement = _xDoc.Element(_rootElementName);
            foreach (var elem in rootElement.Elements().ToList())
            {
                if (predicate(CreateFromXml(elem)))
                {
                    rootElement.Add(ConvertToXml(item));
                    elem.Remove();
                }
            }
            _xDoc.Save(_xmlFileLocation);
        }

        public void Delete(Func<T, bool> predicate)
        {
            var rootElement = _xDoc.Element(_rootElementName);
            foreach (var elem in rootElement.Elements().ToList())
            {
                if (predicate(CreateFromXml(elem)))
                {
                    elem.Remove();
                }
            }
            _xDoc.Save(_xmlFileLocation);
        }

        public List<T> Get(Func<T, bool> predicate)
        {
            var rootElement = _xDoc.Element(_rootElementName);
            return rootElement.Elements()
                .Select(el => CreateFromXml(el))
                .Where(item => predicate(item))
                .ToList();
        }

        public List<T> GetAll()
        {
            return Get(item => true);
        }

        protected abstract T CreateFromXml(XElement element);

        protected abstract XElement ConvertToXml(T item);
    }
}
