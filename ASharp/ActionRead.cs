using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ASharp
{
    class ActionRead
    {
        public static void Read(string action)
        {
            Console.Write($"{action} = ");
            int number = Convert.ToInt32(Console.ReadLine());
            Program.SetVariable(action, number);
        }
    }
}
