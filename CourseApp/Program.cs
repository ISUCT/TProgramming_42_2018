using System;
using CourseApp;

namespace CourseApp
{
    public class Program
    {
        public static double Func(double x, double a, double b)
        {
            return ((a + (b * x)) * (a + (b * x)) * ((a + (b * x)) / 2)) / (1 + Math.Log10(a + (b * x)));
        }

        private static void Main(string[] args)
        {
            double a = 2.5;
            double b = 4.6;

            Console.WriteLine("ЗАДАНИЕ А");
            for (double x = 1.1; x <= 3.6; x += 0.5)
            {
                Console.WriteLine($"y({x})={Func(x, a, b)}");
            }

            Console.WriteLine("ЗАДАНИЕ В");
            double[] mas = new double[] { 1.2, 1.28, 1.36, 1.46, 2.35 };
            foreach (double x in mas)
            {
                Console.WriteLine($"y({x})={Func(x, a, b)}");
            }

            Ship admiral = new Ship();
            Kater carter = new Kater();
            Console.WriteLine(admiral);
            Console.WriteLine(carter);
            Transport[] transports = new Transport[2];
            transports[0] = new Ship();
            transports[1] = new Kater();
            foreach (Transport i in transports)
            {
                i.Info();
            }

            Console.ReadLine();
        }
    }
}
