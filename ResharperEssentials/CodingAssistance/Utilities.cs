using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ResharperEssentials.CodingAssistance
{
    public class Utilities
    {
        public static IEnumerable<string> SearchFiles(bool recursive, string path, string pattern)
        {
            if (Directory.Exists(path))
            {
                var searchOption = recursive
                    ? SearchOption.AllDirectories
                    : SearchOption.TopDirectoryOnly;

                return Directory.EnumerateFiles(path, pattern, searchOption);
            }

            return Enumerable.Empty<string>();
        }

        public void DeleteDirectoryIfExists(string path)
        {
            //if (Directory.Exists(path
        }
    }
}