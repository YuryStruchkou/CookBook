using System;
using System.Xml.Linq;
using DomainLayer.DataConstants;
using DomainLayer.Models;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessRecipes : XmlDataAccess<Recipe>
    {
        public XmlDataAccessRecipes() : base(XmlConstants.DefaultRecipesXml, XmlConstants.Recipes)
        {
        }

        protected override XElement ConvertToXml(Recipe item)
        {
            return new XElement("recipe",
                new XAttribute("id", item.Id),
                new XAttribute("name", item.Name),
                new XAttribute("content", item.Content),
                new XAttribute("description", item.Description),
                new XAttribute("creationDate", item.CreationDate.ToString()),
                new XAttribute("editDate", item.EditDate?.ToString() ?? ""),
                new XAttribute("deleteDate", item.DeleteDate?.ToString() ?? ""),
                new XAttribute("status", item.RecipeStatus.RecipeStatusName),
                new XAttribute("userId", item.UserId));
        }

        protected override Recipe CreateFromXml(XElement element)
        {
            var recipe = new Recipe
            {
                Id = element.Attribute("id").Value,
                Name = element.Attribute("name").Value,
                Content = element.Attribute("content").Value,
                Description = element.Attribute("description").Value,
                CreationDate = DateTime.Parse(element.Attribute("creationDate").Value),
                EditDate = !string.IsNullOrEmpty(element.Attribute("editDate").Value) ? (DateTime?)DateTime.Parse(element.Attribute("editDate").Value) : null,
                DeleteDate = !string.IsNullOrEmpty(element.Attribute("deleteDate").Value) ? (DateTime?)DateTime.Parse(element.Attribute("deleteDate").Value) : null,
                RecipeStatus = new RecipeStatus { RecipeStatusName = element.Attribute("status").Value },
                UserId = element.Attribute("userId").Value
            };
            return recipe;
        }
    }
}
