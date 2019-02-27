using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using ASharp.Runtime.ActionRecognizers;
using ASharp.Runtime.Exceptions;

namespace ASharp.Runtime
{
    public class CodeParser
    {
        private List<ActionRecognizer> ActionRecognizers;
        public CodeParser()
        {
            ActionRecognizers = new List<ActionRecognizer>();
            ActionRecognizers.Add(new PrintActionRecognizer());
            ActionRecognizers.Add(new ReadActionRecognizer());
            ActionRecognizers.Add(new SetActionRecognizer());
            ActionRecognizers.Add(new LabelActionRecognizer());
            ActionRecognizers.Add(new GotoActionRecognizer());
            ActionRecognizers.Add(new IfActionRecognizer());
        }

        private string[] codeLines = {};
        private int stringIndex = 1;
        private int actionIndex = 0;
        private string CompileError(string message = "")
        {
            message += "\n\n";
            if (stringIndex - 2 >= 0) message += $"{stringIndex - 1}|  {codeLines[stringIndex - 2]}\n";
            message += $"{stringIndex}|> {codeLines[stringIndex - 1]}\n";
            if (stringIndex + 1<= codeLines.Length) message += $"{stringIndex + 1}|  {codeLines[stringIndex]}\n";
            message += "\n";
            return message;
        }

        public Program Parse(string code)
        {
            Program program = new Program();
            codeLines = code.Split('\n');

            code = code.TrimEnd();
            code = code.ToLower();
            code = code.Replace('\r', ' ');
            code = Regex.Replace(code, "//.*(\n)?", "$1");
            code += " ";

            bool actionFound = false;
            while (code.Length > 0)
            {
                code = code.TrimStart(' ');
                if (code.IndexOf('\n') == 0)
                {
                    code = code.Substring(1);
                    stringIndex++;
                    continue;
                }
                
                actionFound = false;
                foreach (ActionRecognizer actionRecognizer in ActionRecognizers)
                {
                    Regex regex = new Regex("^(" + actionRecognizer.Regex + ") ");
                    Match match = regex.Match(code);
                    if (match.Success)
                    {
                        actionFound = true;
                        try
                        {
                            code = code.Substring(match.Length);

                            actionRecognizer.ActionFound(actionIndex + 1, match.Value.Trim());
                            
                            Regex argsRegex = new Regex("^(" + actionRecognizer.ArgsRegex + ")");
                            Match argsMatch = argsRegex.Match(code);

                            if (!argsMatch.Success)
                            {
                                throw new ArgumentException("Unexpected input (arguments not found)");
                            }
                            actionRecognizer.ArgsFound(argsMatch.Value.Trim());
                            code = code.Substring(argsMatch.Length);
                            
                            Action action = actionRecognizer.GetExecutor();
                            program.AddAction(action);
                            actionIndex++;
                        }
                        catch(ArgumentException e)
                        {
                            throw new ArgumentException(CompileError($"{e.Message}"));
                        }
                        break;
                    }
                    else
                    {
                        actionFound = false;
                    }
                }

                if (!actionFound && code.Trim().Length != 0)
                {
                    throw new ParseException(CompileError($"Unexpected input"));
                }
            }

            if (ASharp.options.Mode != "repl") program.Compile();

            return program;
        }
    }
}