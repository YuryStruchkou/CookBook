using DataLayer.ConsoleDataAccess;
using System;
using System.Collections.Generic;
using DomainLayer.Models;

namespace BusinessLogicLayer.RecipeManagement
{
    public class RecipeManager
    {
        private readonly XmlDataAccessRecipes _xmlDataAccess;

        public RecipeManager()
        {
            _xmlDataAccess = new XmlDataAccessRecipes();
        }

        public RecipeManager(XmlDataAccessRecipes xmlDataAccess)
        {
            _xmlDataAccess = xmlDataAccess;
        }

        public void AddRecipe(Recipe item)
        {
            _xmlDataAccess.Add(item);
        }

        public void UpdateRecipe(Recipe item, Func<Recipe, bool> predicate)
        {
            _xmlDataAccess.Update(item, predicate);
        }

        public void DeleteRecipe(Func<Recipe, bool> predicate)
        {
            _xmlDataAccess.Delete(predicate);
        }

        public List<Recipe> Get(Func<Recipe, bool> predicate)
        {
            return _xmlDataAccess.Get(predicate);
        }

        public List<Recipe> GetAll()
        {
            return _xmlDataAccess.GetAll();
        }

        public int GetRecipeCount()
        {
            return _xmlDataAccess.GetAll().Count;
        }
    }
}
