using System.IO;
using System.Reflection;

namespace CoreProject.DataConstants
{
    public class XmlConstants
    {
        public static readonly string DefaultUsersXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Users.xml");

        public static readonly string DefaultRecipesXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Recipes.xml");

        public static readonly string DefaultVotesXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Votes.xml");

        public static readonly string DefaultCommentsXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Comments.xml");

        public static readonly string DefaultRecipeTagsXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\RecipeTags.xml");

        public static readonly string DefaultTagsXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Tags.xml");
    }
}
