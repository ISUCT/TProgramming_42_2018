using System;
using System.Collections.Generic;
using System.Text;

namespace ASharp
{
    class CodeParser
    {
        public string Parse(string[] code)
        {
            foreach(string i in code)
            {
                switch (i)
                {
                    case "read":
                        return "";
                    case "print":
                        return "";
                }
            }

            return "";
        }
    }
}
