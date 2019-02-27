using System;

namespace ASharp.Runtime.Actions
{
    public class SetAction : Action
    {
        private string variable;
        private MathTree mathTree;
        public SetAction(int next) : base(next) {}
        public void SetVariableName(string variable)
        {
            this.variable = variable;
        }
        public void SetMathTree(MathTree mathTree)
        {
            this.mathTree = mathTree;
        }
        public override string Execute()
        {
            try
            {
                Program.SetVariable(variable, this.mathTree.Solve());
                return "";
            }
            catch(System.DivideByZeroException e)
            {
                return e.Message;
            }
        }
    }
}