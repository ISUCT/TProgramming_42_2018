using System;
using System.Text.RegularExpressions;

namespace ASharp
{
    class CodeParser
    {
        public void Parse(string[] code)
        {
            for(int i = 0; i <= code.Length - 1; i++)
            {
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
                        Math.MathParser(code[i]);
                        break;
                }
            }
        }
    }
}
