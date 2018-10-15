using System.Collections.Generic;
using static Solver;
using static IO;

namespace CourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> data = IO.read();
            Dictionary<string, double> answers = Solver.solve(data["a"], data["b"], data["xH"], data["xK"], data["dX"]);
            IO.write(answers);
        }
    }
}
