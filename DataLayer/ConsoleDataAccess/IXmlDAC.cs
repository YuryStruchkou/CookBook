using System;
using System.Collections.Generic;

namespace DataLayer.ConsoleDataAccess
{
    public interface IXmlDAC<T>
    {
        void Add(T item);

        void Update(T item, Func<T, bool> predicate);

        void Delete(Func<T, bool> predicate);

        List<T> Get(Func<T, bool> predicate);

        List<T> GetAll();
    }
}
