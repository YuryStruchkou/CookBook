using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.XmlContext;

namespace DataLayer.ConsoleDataAccess
{
    public abstract class XmlDataAccess<T> : IXmlDataAccess<T>
    {
        protected XmlContext XmlContext = new XmlContext();

        protected abstract List<T> XmlList { get; }

        public virtual void Add(T item)
        {
            XmlList.Add(item);
            XmlContext.Save();
        }

        public virtual void Update(T item, Func<T, bool> predicate)
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

        public virtual void Delete(Func<T, bool> predicate)
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

        public virtual List<T> Get(Func<T, bool> predicate)
        {
            return XmlList.Where(item => predicate(item)).ToList();
        }

        public virtual List<T> GetAll()
        {
            return XmlList.ToList();
        }
    }
}
