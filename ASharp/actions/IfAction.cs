using System;

namespace ASharp.Runtime.Actions
{
    public class IfAction : Action
    {
        public const string COMPARSION_L = "<";
        public const string COMPARSION_LE = "<=";
        public const string COMPARSION_G = ">";
        public const string COMPARSION_GE = ">=";
        public const string COMPARSION_E = "==";
        public const string COMPARSION_NE = "!=";
        private string leftVariable;
        private string rightVariable;
        private string comparsionSign;
        public IfAction(int next) : base(next) { }
        public void Setup(string leftVariable, string comparsionSign, string rightVariable)
        {
            this.leftVariable = leftVariable;
            this.comparsionSign = comparsionSign;
            this.rightVariable = rightVariable;
        }
        public override string Execute()
        {
            switch (comparsionSign)
            {
                case COMPARSION_E:
                    if (Program.GetVariable(this.leftVariable) != Program.GetVariable(this.rightVariable))
                    {
                        nextAction++;
                    }
                    break;
                case COMPARSION_NE:
                    if (Program.GetVariable(this.leftVariable) == Program.GetVariable(this.rightVariable))
                    {
                        nextAction++;
                    }
                    break;
                case COMPARSION_L:
                    if (Program.GetVariable(this.leftVariable) >= Program.GetVariable(this.rightVariable))
                    {
                        nextAction++;
                    }
                    break;
                case COMPARSION_LE:
                    if (Program.GetVariable(this.leftVariable) > Program.GetVariable(this.rightVariable))
                    {
                        nextAction++;
                    }
                    break;
                case COMPARSION_G:
                    if (Program.GetVariable(this.leftVariable) <= Program.GetVariable(this.rightVariable))
                    {
                        nextAction++;
                    }
                    break;
                case COMPARSION_GE:
                    if (Program.GetVariable(this.leftVariable) < Program.GetVariable(this.rightVariable))
                    {
                        nextAction++;
                    }
                    break;
            }
            return "";
        }
    }
}