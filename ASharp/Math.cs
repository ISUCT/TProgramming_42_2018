using System;
using System.Text.RegularExpressions;

namespace ASharp
{
    class Math
    {
        public static int Converter(string line)
        {
            int res;
            if(Program.Variables.ContainsKey(line))
            {
                res = Program.Variables[line];
                return res;
            }
            else if(Int32.TryParse(line, out res))
            {
                return res;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        }

        public static void MathParser(string code)
        {
            string pattern = @"(\w+)\s*(=)\s*(\w+)\s*([\/\+\-\*]+)\s*(\w+)";
                Match i = Regex.Match(code, pattern);
                    switch (i.Groups[4].Value)
                    {
                        case "+":
                            if (Program.Variables.ContainsKey(i.Groups[1].Value))
                            {
                                Program.Variables[i.Groups[1].Value] = Converter(i.Groups[3].Value) + Converter(i.Groups[5].Value);
                            }                    
                            else
                            {
                                Program.Variables.Add(i.Groups[1].Value, Converter(i.Groups[3].Value) + Converter(i.Groups[5].Value));
                            }                                                  
                            break;
                        case "-":
                            if (Program.Variables.ContainsKey(i.Groups[1].Value))
                            {
                                Program.Variables[i.Groups[1].Value] = Converter(i.Groups[3].Value) - Converter(i.Groups[5].Value); 
                            }                    
                            else
                            {
                                Program.Variables.Add(i.Groups[1].Value, Converter(i.Groups[3].Value) - Converter(i.Groups[5].Value));
                            }
                            break;
                        case "*":
                            if (Program.Variables.ContainsKey(i.Groups[1].Value))
                            {
                                Program.Variables[i.Groups[1].Value] = Converter(i.Groups[3].Value) * Converter(i.Groups[5].Value); 
                            }                    
                            else
                            {
                                Program.Variables.Add(i.Groups[1].Value, Converter(i.Groups[3].Value) * Converter(i.Groups[5].Value));
                            }                                                  
                            break;
                        case "/":
                            if (Program.Variables.ContainsKey(i.Groups[1].Value))
                            {
                                Program.Variables[i.Groups[1].Value] = Converter(i.Groups[3].Value) / Converter(i.Groups[5].Value); 
                            }                    
                            else
                            {
                                Program.Variables.Add(i.Groups[1].Value, Converter(i.Groups[3].Value) / Converter(i.Groups[5].Value));
                            }                            
                            break;
                        default:
                            string[] splitedString = code.Split(' ');
                            if (Program.Variables.ContainsKey(splitedString[0]))
                            {
                                Program.Variables[splitedString[0]] = Converter(splitedString[2]);
                            }
                            else
                            {
                                Program.Variables.Add(splitedString[0], Converter(splitedString[2]));
                            }
                    break;
                    }
        }
    }
}