using System;
using System.IO;
using System.Collections.Generic;

namespace ASharp
{
    class ActionPrint
    {
        public static void Print(string action)
        {
             if(Program.Variables.ContainsKey(action))
             {
                Console.WriteLine($"{action} = {Program.Variables[action]}");
             }
             else Console.WriteLine($"Переменной {action} не существует");
        }
    }
}