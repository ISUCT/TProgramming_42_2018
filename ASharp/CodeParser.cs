using System;
using System.Text.RegularExpressions;

namespace ASharp
{
    class CodeParser
    {
        public string Parse(string[] code)
        {
            string pattern = @"([a-z]+)\s([a-z]+)";
            foreach (string line in code)
            {
                foreach(Match i in Regex.Matches(line, pattern))
                {
                    switch (i.Groups[0].Value)
                    {
                        case "read":
                            ActionRead.Read(i.Groups[1].Value);
                            break;
                        case "print":
                            return "";
                    }
                }

            }

            return "";
        }
    }
}
