using System;

using ASharp.Runtime.Exceptions;

namespace ASharp.Runtime.Actions
{
    public class GotoAction : Action
    {
        private string label;
        public void SetLabel(string label)
        {
            this.label = label;
        }
        public GotoAction(int next) : base(next) { }
        public override string Execute()
        {
            if (Program.Labels.ContainsKey(this.label)) {
                nextAction = Program.Labels[this.label];
                return "";
            } else {
                return $"Label {this.label} not found";
            }
        }
    }
}