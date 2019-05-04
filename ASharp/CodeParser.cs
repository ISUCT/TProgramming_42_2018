using System;
using System.Text.RegularExpressions;

namespace ASharp
{
    class CodeParser
    {
        public void Parse(string[] code)
        {
            int stringCounter = -1;
            
            for(int i = 0; i <= code.Length - 1; i++)
            {
                stringCounter++;

                string[] splitedString = code[i].Split(' ');

                switch (splitedString[0])
                {   
                   case "read":
                        ActionRead.Read(splitedString[1]);
                        break;
                    case "print":
                        ActionPrint.Print(splitedString[1]);
                        break;
                    default:
                        break;
                }

                if(code[i].Contains("+") || code[i].Contains("-") || code[i].Contains("*") || code[i].Contains("/") || code[i].Contains("="))
                {
                    Math.MathParser(code[i]);
                }
                else if(code[i].Contains("if"))
                {
                    i = Conditions.ParseConditions(code[i], stringCounter);
                    stringCounter = i;
                }
                else if(code[i].Contains(":"))
                {
                    string[] mark = code[i].Split(':');
                    Program.SetMark(mark[0], stringCounter);
                }
            }
        }
    }
}
