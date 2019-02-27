namespace ASharp.Runtime
{
    public abstract class Action
    {
        public int NextAction
        {
            get
            {
                return nextAction;
            }
        }
        protected int nextAction;
        public Action(int nextAction)
        {
            this.nextAction = nextAction;
        }
        public abstract string Execute();
    }
}