using System.Collections.Generic;
using DomainLayer.Models;
using DomainLayer.Models.Entities;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlRecipeTagsDAC : BaseXmlDAC<RecipeTag>
    {
        protected override List<RecipeTag> XmlList => XmlContext.RecipeTags;
    }
}
