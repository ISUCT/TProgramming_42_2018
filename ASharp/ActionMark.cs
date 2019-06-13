using System;

namespace ASharp
{
    class ActionMark
    {
        public static void Mark(string mark)
        {
            int line = Program.Marks[mark];
        }
    }
}