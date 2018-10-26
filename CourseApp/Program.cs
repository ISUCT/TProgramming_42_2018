using System.Collections.Generic;
using static Solver;
using static IO;

namespace CourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IO.writeString("Task 1");
            Dictionary<string, double> data = IO.read();
            Dictionary<string, double> answers = Solver.solve(data["a"], data["b"], data["xH"], data["xK"], data["dX"]);
            IO.write(answers);

            IO.writeString("Task 2");
            double[] dataArr = IO.readArray();
            answers = Solver.solveXArray(data["a"], data["b"], dataArr);
            IO.write(answers);
        }
    }
}
