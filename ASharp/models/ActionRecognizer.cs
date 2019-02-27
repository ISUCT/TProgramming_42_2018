using System;

namespace ASharp.Runtime
{
    public abstract class ActionRecognizer
    {
        public abstract string Regex{get;}
        public abstract string ArgsRegex{get;}
        public abstract void ActionFound(int next, string match);
        public abstract void ArgsFound(string match);
        public abstract Action GetExecutor();
        public override string ToString()
        {
            return Regex + " " + ArgsRegex;
        }
    }
}