using DataLayer.ConsoleDataAccess;
using DataLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.UserManagement
{
    public class UserManager
    {
        private XmlDataAccessUsers xmlDataAccess;

        public UserManager()
        {
            xmlDataAccess = new XmlDataAccessUsers();
        }

        public UserManager(XmlDataAccessUsers _xmlDataAccess)
        {
            xmlDataAccess = _xmlDataAccess;
        }

        public void AddUser(User item)
        {
            xmlDataAccess.Add(item);
        }

        public void UpdateUser(User item, Func<User, bool> predicate)
        {
            xmlDataAccess.Update(item, predicate);
        }

        public void DeleteUser(Func<User, bool> predicate)
        {
            xmlDataAccess.Delete(predicate);
        }

        public List<User> Get(Func<User, bool> predicate)
        {
            return xmlDataAccess.Get(predicate);
        }

        public List<User> GetAll()
        {
            return xmlDataAccess.GetAll();
        }

        public int GetUserCount()
        {
            return xmlDataAccess.GetAll().Count;
        }
    }
}
