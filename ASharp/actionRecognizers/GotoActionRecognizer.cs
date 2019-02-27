using System;

using ASharp.Runtime.Actions;

namespace ASharp.Runtime.ActionRecognizers
{
    public class GotoActionRecognizer : ActionRecognizer
    {
        private GotoAction Executor { get; set; }
        public override string Regex
        {
            get
            {
                return @"goto";
            }
        }
        public override string ArgsRegex
        {
            get
            {
                return @"[a-z]+";
            }
        }
        public override void ActionFound(int next, string match)
        {
            Executor = new GotoAction(next);
        }
        public override void ArgsFound(string match) {
            Executor.SetLabel(match);
        }
        public override Action GetExecutor()
        {
            return Executor;
        }
    }
}