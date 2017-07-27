using System.IO;

namespace EnsureGuardClause.Extensions
{
    public static class DirectoryExtensions
    {
        public static void DirectoryExists(this Param<string> param)
        {
            if (Directory.Exists(param.Value))
            {
                return;
            }

            throw new DirectoryNotFoundException("Directory not found");
        }
    }
}
