using System.IO;
using System.Reflection;
using CoreProject.Extensions;

namespace CoreProject.DataConstants
{
    public static class PathConstants
    {
        public static readonly string DefaultUsersXml;

        public static readonly string DefaultRecipesXml;

        public static readonly string DefaultVotesXml;

        public static readonly string DefaultCommentsXml;

        public static readonly string DefaultRecipeTagsXml;

        public static readonly string DefaultTagsXml;

        static PathConstants()
        {
            Directory.CreateDirectory("XML".CreateFilePathInsideExecutingDirectory());
            DefaultUsersXml = @"XML\Users.xml".CreateFilePathInsideExecutingDirectory();
            DefaultRecipesXml = @"XML\Recipes.xml".CreateFilePathInsideExecutingDirectory();
            DefaultVotesXml = @"XML\Votes.xml".CreateFilePathInsideExecutingDirectory();
            DefaultCommentsXml = @"XML\Comments.xml".CreateFilePathInsideExecutingDirectory();
            DefaultRecipeTagsXml = @"XML\RecipeTags.xml".CreateFilePathInsideExecutingDirectory();
            DefaultTagsXml = @"XML\Tags.xml".CreateFilePathInsideExecutingDirectory();
        }
    }
}
