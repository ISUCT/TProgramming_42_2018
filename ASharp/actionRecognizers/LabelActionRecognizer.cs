using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using ASharp.Runtime.Actions;

namespace ASharp.Runtime.ActionRecognizers
{
    class LabelActionRecognizer : ActionRecognizer
    {
        private LabelAction Executor { get; set; }
        public override string Regex
        {
            get
            {
                return @"[a-z]+\:";
            }
        }
        public override string ArgsRegex
        {
            get
            {
                return @"";
            }
        }
        public override void ActionFound(int next, string match)
        {
            Executor = new LabelAction(next);
            match = match.TrimEnd(':');
            if (!Program.Labels.ContainsKey(match))
            {
                Program.Labels.Add(match, next);
            }
            else
            {
                throw new ArgumentException($"Label {match} already exists");
            }
        }
        public override void ArgsFound(string match) {}
        public override Action GetExecutor()
        {
            return Executor;
        }
    }
}