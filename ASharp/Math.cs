using System;
using System.Text.RegularExpressions;

namespace ASharp
{
    class Math
    {
        public static void MathParser(string code)
        {
            string pattern = @"([0-9]+)\s*([\/\+\-\*]+)\s*([0-9]+)";
                Match i = Regex.Match(code, pattern);
                    switch (i.Groups[2].Value)
                    {
                        case "+":
                            Console.WriteLine(Convert.ToInt32(i.Groups[1].Value) + Convert.ToInt32(i.Groups[3].Value));
                            break;
                        case "-":
                            Console.WriteLine(Convert.ToInt32(i.Groups[1].Value) - Convert.ToInt32(i.Groups[3].Value));
                            break;
                        case "*":
                            Console.WriteLine(Convert.ToInt32(i.Groups[1].Value) * Convert.ToInt32(i.Groups[3].Value));
                            break;
                        case "/":
                            Console.WriteLine(Convert.ToInt32(i.Groups[1].Value) / Convert.ToInt32(i.Groups[3].Value));
                            break;
                        default:
                            break;
                    }
        }
    }
}