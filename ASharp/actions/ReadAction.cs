using System;

namespace ASharp.Runtime.Actions
{
    public class ReadAction : Action
    {
        private string variable;
        public ReadAction(int next) : base(next) { }
        public void SetVariableName(string variable)
        {
            this.variable = variable;
        }
        public override string Execute()
        {
            ASharp.io.Write($"{this.variable.ToUpper()} = ");

            string rawValue = ASharp.io.Read();
            int value;
            if (Int32.TryParse(rawValue, out value))
            {
                Program.SetVariable(this.variable, value);
                return "";
            }
            else
            {
                return $"{rawValue} is not a number";
            }
        }
    }
}