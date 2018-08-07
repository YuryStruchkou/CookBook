using DataLayer.ConsoleDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Models;

namespace BusinessLogicLayer.RecipeManagement
{
    public class RecipeManager
    {
        private readonly IXmlDataAccess<Recipe> _xmlDataAccessRecipes;

        private readonly IXmlDataAccess<Vote> _xmlDataAccessVotes;

        public RecipeManager()
        {
            _xmlDataAccessVotes = new XmlDataAccessVotes();
            _xmlDataAccessRecipes = new XmlDataAccessRecipes();
        }

        public RecipeManager(IXmlDataAccess<Recipe> xmlDataAccessRecipes, IXmlDataAccess<Vote> xmlDataAccessVotes)
        {
            _xmlDataAccessRecipes = xmlDataAccessRecipes;
            _xmlDataAccessVotes = xmlDataAccessVotes;
        }

        public void AddRecipe(Recipe item)
        {
            _xmlDataAccessRecipes.Add(item);
        }

        public void UpdateRecipe(Recipe item, Func<Recipe, bool> predicate)
        {
            _xmlDataAccessRecipes.Update(item, predicate);
        }

        public void DeleteRecipe(Func<Recipe, bool> predicate)
        {
            _xmlDataAccessRecipes.Delete(predicate);
        }

        public List<Recipe> Get(Func<Recipe, bool> predicate)
        {
            return _xmlDataAccessRecipes.Get(predicate);
        }

        public List<Recipe> GetAll()
        {
            return _xmlDataAccessRecipes.GetAll();
        }

        public double GetAverageVote(int recipeId)
        {
            var votes = _xmlDataAccessVotes.Get(v => v.RecipeId == recipeId);
            return votes.Count == 0 ? 0.0 : votes.Average(v => v.Value);
        }

        public int GetRecipeCount()
        {
            return _xmlDataAccessRecipes.GetAll().Count;
        }
    }
}
