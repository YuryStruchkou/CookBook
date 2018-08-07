using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.XmlContext;

namespace DataLayer.ConsoleDataAccess
{
    public abstract class BaseXmlDataAccess<T> : IXmlDataAccess<T>
    {
        protected XmlContext XmlContext = XmlContext.GetInstance();

        protected abstract List<T> XmlList { get; }

        public void Add(T item)
        {
            XmlList.Add(item);
            XmlContext.Save();
        }

        public void Update(T item, Func<T, bool> predicate)
        {
            for (int i = 0; i < XmlList.Count; i++)
            {
                if (predicate(XmlList[i]))
                {
                    XmlList[i] = item;
                }
            }
            XmlContext.Save();
        }

        public void Delete(Func<T, bool> predicate)
        {
            for (int i = 0; i < XmlList.Count; )
            {
                if (predicate(XmlList[i]))
                {
                    XmlList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            XmlContext.Save();
        }

        public List<T> Get(Func<T, bool> predicate)
        {
            return XmlList.Where(item => predicate(item)).ToList();
        }

        public List<T> GetAll()
        {
            return XmlList.ToList();
        }
    }
}
