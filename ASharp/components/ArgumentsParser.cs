using System;
using System.Collections.Generic;

namespace ASharp.Startup
{
    public class ArgumentsParser
    {
        private Argument[] Arguments;
        public ArgumentsParser()
        {
            Arguments = new Argument[4];

            Arguments[0] = new Argument("f", "file", true, 0);
            Arguments[1] = new Argument("i", "info");
            Arguments[2] = new Argument("r", "repl");
            Arguments[3] = new Argument("o", "output", true, 1);
        }

        public Options Parse(string[] args)
        {
            Dictionary<string, string> arguments = new Dictionary<string, string>();

            int index = 0;

            for (int i = 0; i < args.Length; i++)
            {
                for (int j = 0; j < Arguments.Length; j++)
                {
                    if (args[i][0] == '-')
                    {
                        if ((args[i] == "-" + Arguments[j].Short) || (args[i] == "--" + Arguments[j].Full))
                        {
                            if (Arguments[j].HasValue) {
                                arguments.Add(Arguments[j].Full, args[++i]);
                            } else {
                                arguments.Add(Arguments[j].Full, true.ToString());
                            }
                            break;
                        }
                    }
                    else
                    {
                        if (index == Arguments[j].DefaultIndex && Arguments[j].HasValue)
                        {
                            arguments.Add(Arguments[j].Full, args[i]);
                            index++;
                            break;
                        }
                    }
                }
            }
            
            string mode = "info";
            if (arguments.ContainsKey("file")) mode = "file";
            if (arguments.ContainsKey("repl")) mode = "repl";

            string file = "";
            if (mode == "file") file = arguments["file"];

            string outputMode = "console";
            if (arguments.ContainsKey("output") && mode != "repl") outputMode = "file";

            string outputFile = "";
            if (outputMode == "file") outputFile = arguments["output"];
            
            Options options = new Options(mode, file, outputMode, outputFile);
            return options;
        }
    }
}