using System;
using System.Text.RegularExpressions;

using ASharp.Runtime.Actions;

namespace ASharp.Runtime.ActionRecognizers
{
    public class IfActionRecognizer : ActionRecognizer
    {
        private IfAction Executor { get; set; }
        public override string Regex
        {
            get
            {
                return @"if";
            }
        }
        public override string ArgsRegex
        {
            get
            {
                return @"[a-z\d]+\s*(([<>\!\=]?\=)|([<>]))\s*[a-z\d]+";
            }
        }
        public override void ActionFound(int next, string match)
        {
            Executor = new IfAction(next);
        }
        public override void ArgsFound(string match)
        {
            string comparsionSign = new Regex(@"(([<>\!\=]?\=)|([<>]))").Match(match).Value;

            string[] variables = match.Split(comparsionSign);
            string leftVariable = variables[0].Trim();
            string rightVariable = variables[1].Trim();

            if (Program.GetVariable(leftVariable) == null)
            {
                if (new Regex(@"^\d+$").Match(leftVariable).Success) {
                    Program.SetVariable(leftVariable, Int32.Parse(leftVariable));
                } else {
                    throw new ArgumentException($"Variable {leftVariable} does not exists");
                }
            }

            if (Program.GetVariable(rightVariable) == null)
            {
                if (new Regex(@"^\d+$").Match(rightVariable).Success) {
                    Program.SetVariable(rightVariable, Int32.Parse(rightVariable));
                } else {
                    throw new ArgumentException($"Variable {rightVariable} does not exists");
                }
            }

            Executor.Setup(leftVariable, comparsionSign, rightVariable);
        }
        public override Action GetExecutor()
        {
            return Executor;
        }
    }
}