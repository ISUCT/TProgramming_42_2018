using System;
using System.Collections.Generic;

namespace ASharp
{
    class Program
    {
        public static Dictionary<string, int> Variables = new Dictionary<string, int>();
        public static Dictionary<string, int> Marks = new Dictionary<string, int>();

        public static void SetVariable(string key, int value)
        {
            if(!Variables.ContainsKey(key))
            {
                Variables.Add(key, value);
            }
        }

        public static void SetMark(string key, int value)
        {
            if(!Marks.ContainsKey(key))
            {
                Marks.Add(key, value);
            }
        }

        static void Main(string[] args)
        {
            string path = "./code.txt";

            string[] code = CodeReader.ReadFile(path);
            CodeParser parser = new CodeParser();
            parser.Parse(code);

            Console.ReadKey();
        }
    }
}
