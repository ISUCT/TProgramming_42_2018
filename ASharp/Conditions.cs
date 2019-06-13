using System;
using System.Text.RegularExpressions;

namespace ASharp
{
    class Conditions
    {
        public static int ParseConditions(string code, int counter)
        {
            string pattern = @"([if]+)\s([\w]+)\s([\><!=]+)\s([\w]+)\s([goto]+)\s([\w]+)";
            Match i = Regex.Match(code, pattern);

            switch (i.Groups[3].Value)
            {
                case ">":
                    if(Math.Converter(i.Groups[2].Value) > Math.Converter(i.Groups[4].Value))
                    {
                        return Program.Marks[i.Groups[6].Value] - 1;
                    }
                    else
                    {
                        return counter;
                    }
                case ">=":
                    if(Math.Converter(i.Groups[2].Value) >= Math.Converter(i.Groups[4].Value))
                    {
                        return Program.Marks[i.Groups[6].Value] - 1;
                    }
                    else
                    {
                        return counter;
                    }
                case "<":
                    if(Math.Converter(i.Groups[2].Value) < Math.Converter(i.Groups[4].Value))
                    {
                        return Program.Marks[i.Groups[6].Value] - 1;
                    }
                    else
                    {
                        return counter;
                    }
                case "<=":                    
                    if(Math.Converter(i.Groups[2].Value) <= Math.Converter(i.Groups[4].Value))
                    {
                        return Program.Marks[i.Groups[6].Value] - 1;
                    }
                    else
                    {
                        return counter;
                    }
                case "==":
                    if(Math.Converter(i.Groups[2].Value) == Math.Converter(i.Groups[4].Value))
                    {
                        return Program.Marks[i.Groups[6].Value] - 1;
                    }
                    else
                    {
                        return counter;
                    }
                case "!=":
                    if(Math.Converter(i.Groups[2].Value) != Math.Converter(i.Groups[4].Value))
                    {
                        return Program.Marks[i.Groups[6].Value] - 1;
                    }
                    else
                    {
                        return counter;
                    }
                default:
                    return 0;
            } 
        }
    }
}