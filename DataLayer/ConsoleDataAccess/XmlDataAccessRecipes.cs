using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessRecipes : XmlDataAccess<Recipe>
    {
        public XmlDataAccessRecipes(string xmlFileLocation, string rootElementName) : base(xmlFileLocation, rootElementName)
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
                new XAttribute("editDate", item.EditDate.ToString()),
                new XAttribute("deleteDate", item.DeleteDate.ToString()),
                new XAttribute("status", item.RecipeStatus.RecipeStatusName));
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
                EditDate = DateTime.Parse(element.Attribute("editDate").Value),
                DeleteDate = DateTime.Parse(element.Attribute("deleteDate").Value),
                RecipeStatus = new RecipeStatus { RecipeStatusName = element.Attribute("status").Value }
            };
            return recipe;
        }
    }
}
