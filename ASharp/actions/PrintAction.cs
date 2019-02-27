namespace ASharp.Runtime.Actions
{
    public class PrintAction : Action
    {
        private MathTree mathTree;
        public PrintAction(int next) : base(next) { }
        public void SetMathTree(MathTree mathTree)
        {
            this.mathTree = mathTree;
        }
        public override string Execute()
        {
            try
            {
                ASharp.io.WriteLine(this.mathTree.Solve());
                return "";
            }
            catch (System.DivideByZeroException e)
            {
                return e.Message;
            }
        }
    }
}