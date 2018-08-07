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

        public List<Vote> Votes { get; }

        public List<Comment> Comments { get; }

        public List<RecipeTag> RecipeTags { get; }

        public List<Tag> Tags { get; }

        private static XmlContext _instance;

        private XmlContext()
        {
            Users = XmlSerializationHelper<List<User>>.Deserialize(XmlConstants.DefaultUsersXml) ?? new List<User>();
            Recipes = XmlSerializationHelper<List<Recipe>>.Deserialize(XmlConstants.DefaultRecipesXml) ?? new List<Recipe>();
            Votes = XmlSerializationHelper<List<Vote>>.Deserialize(XmlConstants.DefaultVotesXml) ?? new List<Vote>();
            Comments = XmlSerializationHelper<List<Comment>>.Deserialize(XmlConstants.DefaultCommentsXml) ?? new List<Comment>();
            RecipeTags = XmlSerializationHelper<List<RecipeTag>>.Deserialize(XmlConstants.DefaultRecipeTagsXml) ?? new List<RecipeTag>();
            Tags = XmlSerializationHelper<List<Tag>>.Deserialize(XmlConstants.DefaultTagsXml) ?? new List<Tag>();
        }

        public static XmlContext GetInstance()
        {
            return _instance ?? (_instance = new XmlContext());
        }

        public void Save()
        {
            XmlSerializationHelper<List<User>>.Serialize(XmlConstants.DefaultUsersXml, Users);
            XmlSerializationHelper<List<Recipe>>.Serialize(XmlConstants.DefaultRecipesXml, Recipes);
            XmlSerializationHelper<List<Vote>>.Serialize(XmlConstants.DefaultVotesXml, Votes);
            XmlSerializationHelper<List<Comment>>.Serialize(XmlConstants.DefaultCommentsXml, Comments);
            XmlSerializationHelper<List<Tag>>.Serialize(XmlConstants.DefaultTagsXml, Tags);
            XmlSerializationHelper<List<RecipeTag>>.Serialize(XmlConstants.DefaultRecipeTagsXml, RecipeTags);
        }
    }
}
