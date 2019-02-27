using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using ASharp.Runtime.Actions;

namespace ASharp.Runtime.ActionRecognizers
{
    class SetActionRecognizer : ActionRecognizer
    {
        private SetAction Executor { get; set; }
        public override string Regex
        {
            get
            {
                return @"[a-z]+\s*=";
            }
        }
        public override string ArgsRegex
        {
            get
            {
                return @"([a-z0-9]+)(\s*[\+\-\*\/\^\&\|]\s*[a-z0-9]+)*";
            }
        }
        public override void ActionFound(int next, string match)
        {
            Executor = new SetAction(next);
            string varname = new Regex("[a-z]+").Match(match).Value;

            Program.SetVariable(varname, 0);

            Executor.SetVariableName(varname);
        }
        public override void ArgsFound(string match) {
            MathTree mathTree = MathTree.Parse(match);

            Executor.SetMathTree(mathTree);
        }
        public override Action GetExecutor()
        {
            return Executor;
        }
    }
}