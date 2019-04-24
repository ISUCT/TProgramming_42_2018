using System;
using System.Collections.Generic;

namespace ASharp
{
    class Program
    {
        public static Dictionary<string, int> Variables = new Dictionary<string, int>();

        public static void SetVariable(string key, int value)
        {
            if(!Program.Variables.ContainsKey(key))
            {
                Program.Variables.Add(key, value);
            }
        }

        static void Main(string[] args)
        {
            string path = "D:/ASharp/code.txt";

            string[] code = CodeReader.ReadFile(path);

            Console.ReadKey();
        }
    }
}
