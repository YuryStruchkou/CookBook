using System.Collections.Generic;
using CoreProject;
using CoreProject.DataConstants;
using DomainLayer.Models;

namespace DomainLayer.XmlContext
{
    public class XmlContext
    {
        public List<User> Users { get; }
        public List<Recipe> Recipes { get; }

        public XmlContext()
        {
            Users = XmlSerializationHelper<List<User>>.Deserialize(XmlConstants.DefaultUsersXml) ?? new List<User>();
            Recipes = XmlSerializationHelper<List<Recipe>>.Deserialize(XmlConstants.DefaultRecipesXml) ?? new List<Recipe>();
        }

        public void Save()
        {
            XmlSerializationHelper<List<User>>.Serialize(XmlConstants.DefaultUsersXml, Users);
            XmlSerializationHelper<List<Recipe>>.Serialize(XmlConstants.DefaultRecipesXml, Recipes);
        }
    }
}
