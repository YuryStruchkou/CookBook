using System.IO;
using System.Reflection;

namespace DomainLayer.DataConstants
{
    public class XmlConstants
    {
        public const string Users = "users";

        public const string Recipes = "recipes";

        public static readonly string DefaultUsersXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Users.xml");

        public static readonly string DefaultRecipesXml = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"XML\Recipes.xml"); 
    }
}
