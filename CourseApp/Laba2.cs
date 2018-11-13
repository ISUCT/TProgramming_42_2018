using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{

    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5;
            double b = 4.6;

            // ЗАДАНИЕ А

            Console.WriteLine("ЗАДАНИЕ А");
            for (double x = 1.1; x <= 3.6; x += 0.5)
            {
                Console.WriteLine($"y({x})={Func(x, a, b)}");
            }

            // ЗАДАНИЕ В

            Console.WriteLine("ЗАДАНИЕ В");
            double[] mas = new double[] { 1.2, 1.28, 1.36, 1.46, 2.35 };
            foreach (double x in mas)
            {
                Console.WriteLine($"y({x})={Func(x, a, b)}");
            }
            Console.ReadKey();
        }
        static double Func(double x, double a, double b)
        {
            return ((a + b * x) * (a + b * x) * ((a + b * x) / 2)) / (1 + Math.Log10(a + b * x));
        }
    }
}
