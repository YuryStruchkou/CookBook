using DataLayer.ConsoleDataAccess;
using System;
using System.Collections.Generic;
using DomainLayer.Models;

namespace BusinessLogicLayer.UserManagement
{
    public class UserManager
    {
        private readonly XmlDataAccessUsers _xmlDataAccess;

        public UserManager()
        {
            _xmlDataAccess = new XmlDataAccessUsers();
        }

        public UserManager(XmlDataAccessUsers xmlDataAccess)
        {
            _xmlDataAccess = xmlDataAccess;
        }

        public void AddUser(User item)
        {
            _xmlDataAccess.Add(item);
        }

        public void UpdateUser(User item, Func<User, bool> predicate)
        {
            _xmlDataAccess.Update(item, predicate);
        }

        public void DeleteUser(Func<User, bool> predicate)
        {
            _xmlDataAccess.Delete(predicate);
        }

        public List<User> Get(Func<User, bool> predicate)
        {
            return _xmlDataAccess.Get(predicate);
        }

        public List<User> GetAll()
        {
            return _xmlDataAccess.GetAll();
        }

        public int GetUserCount()
        {
            return _xmlDataAccess.GetAll().Count;
        }
    }
}
