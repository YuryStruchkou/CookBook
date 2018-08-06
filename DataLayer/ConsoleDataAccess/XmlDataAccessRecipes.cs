using DataLayer.Models;
using System;
using System.Xml.Linq;

namespace DataLayer.ConsoleDataAccess
{
    public class XmlDataAccessRecipes : XmlDataAccess<Recipe>
    {
        public XmlDataAccessRecipes(string xmlFileLocation, string rootElementName) : base(xmlFileLocation, rootElementName)
        {
        }

        public override void Add(Recipe item)
        {
            var xdoc = XDocument.Load(_xmlFileLocation);
            var rootElement = xdoc.Element(_rootElementName);
            rootElement.Add(new XElement("user",
                new XAttribute("id", item.Id),
                new XAttribute("name", item.Name),
                new XAttribute("content", item.Content),
                new XAttribute("description", item.Description),
                new XAttribute("creationDate", item.CreationDate.ToString()),
                new XAttribute("editDate", item.EditDate.ToString()),
                new XAttribute("deleteDate", item.DeleteDate.ToString()),
                new XAttribute("status", item.RecipeStatus.RecipeStatusName)));
            xdoc.Save(_xmlFileLocation);
        }

        public override void Delete(Func<Recipe, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override Recipe Get(Func<Recipe, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public override void Update(Recipe item, Func<Recipe, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
