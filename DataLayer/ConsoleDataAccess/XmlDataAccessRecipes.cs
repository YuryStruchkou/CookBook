using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessRecipes : XmlDataAccess<Recipe>
    {
        protected override List<Recipe> XmlList => XmlContext.Recipes;
    }
}
