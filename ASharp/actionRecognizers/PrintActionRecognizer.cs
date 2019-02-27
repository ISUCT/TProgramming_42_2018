using System;
using System.Text.RegularExpressions;

using ASharp.Runtime.Actions;

namespace ASharp.Runtime.ActionRecognizers
{
    class PrintActionRecognizer : ActionRecognizer
    {
        private PrintAction Executor{get; set;}
        public override string Regex
        {
            get
            {
                return @"print";
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
            Executor = new PrintAction(next);
        }
        public override void ArgsFound(string match)
        {
            MathTree mathTree = MathTree.Parse(match);

            Executor.SetMathTree(mathTree);
        }
        public override Action GetExecutor()
        {
            return Executor;
        }
    }
}