using System.IO;

namespace ASharp
{
    class CodeReader
    {
        public static string[] ReadFile(string path)
        {
            if (Path.HasExtension(path))
            {
                string[] code = File.ReadAllLines(path);
                return code;
            }

            return null;
        }
    }
}
