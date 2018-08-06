using DataLayer.ConsoleDataAccess;
using DataLayer.Models;
using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.RecipeManagement
{
    public class RecipeManager
    {
        private XmlDataAccessRecipes xmlDataAccess;

        public RecipeManager(XmlDataAccessRecipes _xmlDataAccess)
        {
            xmlDataAccess = _xmlDataAccess;
        }

        public void AddRecipe(Recipe item)
        {
            xmlDataAccess.Add(item);
        }

        public void UpdateRecipe(Recipe item, Func<Recipe, bool> predicate)
        {
            xmlDataAccess.Update(item, predicate);
        }

        public void DeleteRecipe(Func<Recipe, bool> predicate)
        {
            xmlDataAccess.Delete(predicate);
        }

        public List<Recipe> Get(Func<Recipe, bool> predicate)
        {
            return xmlDataAccess.Get(predicate);
        }

        public List<Recipe> GetAll()
        {
            return xmlDataAccess.GetAll();
        }

        public int GetRecipeCount()
        {
            return xmlDataAccess.GetAll().Count;
        }
    }
}
