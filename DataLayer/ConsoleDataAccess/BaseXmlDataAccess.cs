using System;
using System.Collections.Generic;
using System.Linq;
using CoreProject.LoggingHelpers;
using DomainLayer.XmlContext;

namespace DataLayer.ConsoleDataAccess
{
    public abstract class BaseXmlDataAccess<T> : IXmlDataAccess<T>
    {
        protected XmlContext XmlContext = XmlContext.GetInstance();

        protected abstract List<T> XmlList { get; }

        public void Add(T item)
        {
            if (item != null)
            {
                XmlList.Add(item);
                XmlContext.Save();
                LoggingHelper.log.Info($"Object of type {typeof(T)} has been added.");
            }
        }

        public void Update(T item, Func<T, bool> predicate)
        {
            if (item != null)
            {
                for (int i = 0; i < XmlList.Count; i++)
                {
                    if (predicate(XmlList[i]))
                    {
                        XmlList[i] = item;
                    }
                }
                XmlContext.Save();
                LoggingHelper.log.Info($"Objects of type {typeof(T)} has been updated.");
            }
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
            LoggingHelper.log.Info($"Objects of type {typeof(T)} has been deleted.");
        }

        public List<T> Get(Func<T, bool> predicate)
        {
            LoggingHelper.log.Info($"Objects of type {typeof(T)} has been queried.");
            return XmlList.Where(item => predicate(item)).ToList();
        }

        public List<T> GetAll()
        {
            LoggingHelper.log.Info($"Objects of type {typeof(T)} has been queried.");
            return XmlList.ToList();
        }
    }
}
