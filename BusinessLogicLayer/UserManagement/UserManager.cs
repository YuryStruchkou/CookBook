using DataLayer.ConsoleDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;
using DomainLayer.Models.Entities;

namespace BusinessLogicLayer.UserManagement
{
    public class UserManager
    {
        private readonly IXmlDAC<User> _xmlDataAccessUsers;
        private readonly IXmlDAC<Recipe> _xmlDataAccessRecipes;

        public UserManager()
        {
            _xmlDataAccessRecipes = new XmlRecipeDAC();
            _xmlDataAccessUsers = new XmlUsersDAC();
        }

        public UserManager(IXmlDAC<User> xmlDataAccessUsers, IXmlDAC<Recipe> xmlDataAccessRecipes)
        {
            _xmlDataAccessUsers = xmlDataAccessUsers;
            _xmlDataAccessRecipes = xmlDataAccessRecipes;
        }

        public void AddUser(User item)
        {
            _xmlDataAccessUsers.Add(item);
        }

        public void UpdateUser(User item, Func<User, bool> predicate)
        {
            _xmlDataAccessUsers.Update(item, predicate);
        }

        public void DeleteUser(Func<User, bool> predicate)
        {
            _xmlDataAccessUsers.Delete(predicate);
        }

        public List<User> Get(Func<User, bool> predicate)
        {
            return _xmlDataAccessUsers.Get(predicate);
        }

        public List<User> GetAll()
        {
            return _xmlDataAccessUsers.GetAll();
        }

        public List<Recipe> GetRecipesOfUser(int userId)
        {
            return _xmlDataAccessRecipes.Get(r => r.UserId == userId);
        }

        public User GetUserByUsername(string username)
        {
            return _xmlDataAccessUsers.Get(u => u.Username == username).FirstOrDefault();
        }

        public Recipe GetRecipeByName(int userId, string name)
        {
            return _xmlDataAccessRecipes.Get(r => r.Name == name && userId == r.UserId).FirstOrDefault();
        }

        public int GetUserCount()
        {
            return _xmlDataAccessUsers.GetAll().Count;
        }
    }
}
