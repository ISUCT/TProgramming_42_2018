using System.Collections.Generic;

using ASharp.Runtime.Exceptions;

namespace ASharp.Runtime
{
    public class Program
    {
        private static Dictionary<string, Variable> Variables = new Dictionary<string, Variable>();
        public static void SetVariable(string name, int value)
        {
            if (!Program.Variables.ContainsKey(name))
            {
                Variable variable = new Variable(name);
                Variables.Add(name, variable);
            }
            Variables[name].SetValue(value);
        }
        public static int? GetVariable(string name)
        {
            return Variables.ContainsKey(name) ? Variables[name].Value : (int?)null;
        }


        public static Dictionary<string, int> Labels = new Dictionary<string, int>();
        private List<Action> Actions = new List<Action>();

        public void AddAction(Action action)
        {
            if (!compiled) Actions.Add(action);
        }
        private bool compiled = false;
        public void Compile()
        {
            compiled = true;
        }

        public int Execute()
        {
            Action action;
            int nextAction = 0;
            while (nextAction < Actions.Count)
            {
                action = Actions[nextAction];
                string result = action.Execute();
                if (result.Length == 0)
                {
                    nextAction = action.NextAction;
                }
                else
                {
                    throw new RuntimeException(result);
                }
            }
            return 0;
        }
    }
}