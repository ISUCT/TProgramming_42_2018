using System;

namespace CourseApp3
{
    class Program4
    {

        static void Main(string[] args)
        {
            double xn = 0.15;
            double xk = 1.37;
            double dx = 0.25;
            double[] xx = { 0.2, 0.3, 0.44, 0.6, 0.56 };

            Console.WriteLine("под А");

            for (double x = xn; x < xk; x += dx)
            {
                Console.WriteLine(Fan(x));

            }
            Console.WriteLine("под B");
            foreach (double x in xx)
            {
                Console.WriteLine(Fan(x));
            }
        }
        static double Fan(double x)
        {
            double a = 0.1;
            double b = 0.5;
            double y;
            y = ((a + (Math.Tan(b * x)) * (Math.Tan(b * x))) / (b + (1 / (Math.Tan(a * x))) * (1 / (Math.Tan(a * x)))));
            return y;
        }

    }
}
