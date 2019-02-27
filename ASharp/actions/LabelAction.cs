using System;

namespace ASharp.Runtime.Actions
{
    public class LabelAction : Action
    {
        public LabelAction(int next) : base(next) {}
        public override string Execute()
        {
            return "";
        }
    }
}