using System;
using System.Text.RegularExpressions;

using ASharp.Runtime.Actions;

namespace ASharp.Runtime.ActionRecognizers
{
    class ReadActionRecognizer : ActionRecognizer
    {
        private ReadAction Executor { get; set; }
        public override string Regex
        {
            get
            {
                return @"read";
            }
        }
        public override string ArgsRegex
        {
            get
            {
                return @"[A-z]+";
            }
        }
        public override void ActionFound(int next, string match)
        {
            Executor = new ReadAction(next);
        }
        public override void ArgsFound(string name)
        {
            Program.SetVariable(name, 0);
            Executor.SetVariableName(name);
        }
        public override Action GetExecutor()
        {
            return Executor;
        }
    }
}