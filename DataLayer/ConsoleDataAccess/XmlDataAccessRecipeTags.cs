using System.Collections.Generic;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessRecipeTags : BaseXmlDataAccess<RecipeTag>
    {
        protected override List<RecipeTag> XmlList => XmlContext.RecipeTags;
    }
}
