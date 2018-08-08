using System.IO;
using System.Reflection;

namespace CoreProject.Extensions
{
    public static class StringExtensions
    {
        public static string CreateFilePathInsideExecutingDirectory(this string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName);
        }
    }
}
