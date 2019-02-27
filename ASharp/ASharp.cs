using System;
using System.Collections.Generic;

using ASharp.Startup;
using ASharp.Core;
using ASharp.Runtime;
using ASharp.Runtime.Exceptions;

namespace ASharp
{
    public class ASharp
    {
        public const string Version = "1.2.5";
        public static Options options
        {
            get
            {
                return _options;
            }
        }
        private static Options _options = new Options("info", "", "console", "");
        public static IO io
        {
            get
            {
                return _io;
            }
        }
        private static IO _io = new IO();
        public static void Main(string[] args)
        {
            ArgumentsParser argumentsParser = new ArgumentsParser();

            try
            {
                _options = argumentsParser.Parse(args);
            }
            catch(ArgumentException)
            {
                io.Write("Bad arguments");
                return;
            }

            // not switch to solve problems with scope
            if (options.Mode == "info")
            {
                io.Write($"ASharp v{ASharp.Version}\nAuthor: @wannabeyourdrug");
            }
            else if (options.Mode == "file")
            {
                string code = io.ReadFile(options.File);

                CodeParser codeParser = new CodeParser();
                Program program = codeParser.Parse(code);
                program.Execute();
            }
            else if (options.Mode == "repl")
            {
                CodeParser codeParser = new CodeParser();
                Program program;
                string code = "";

                io.WriteLine($"ASharp v{ASharp.Version}");
                while (true)
                {
                    try
                    {
                        if (code.Length == 0) io.Write("asharp> ");
                        code += io.Read();
                        if (code.Length == 0 || code.Length > 0 && code[code.Length - 1] == '\\') continue;
                        code = code.TrimEnd('\\');
                        if (code == "exit") break;
                        io.WriteLine(code);
                        program = codeParser.Parse(code);
                        program.Execute();
                    }
                    catch (ArgumentException e)
                    {
                        code = "";
                        io.Write(e.Message);
                    }
                    catch (ParseException e)
                    {
                        code = "";
                        io.Write(e.Message);
                    }
                    catch (RuntimeException e)
                    {
                        code = "";
                        io.Write(e.Message);
                    }
                }
            }
        }
    }
}
