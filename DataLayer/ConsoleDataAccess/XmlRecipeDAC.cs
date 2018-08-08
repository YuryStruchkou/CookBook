using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlRecipeDAC : BaseXmlDAC<Recipe>
    {
        protected override List<Recipe> XmlList => XmlContext.Recipes;
    }
}
