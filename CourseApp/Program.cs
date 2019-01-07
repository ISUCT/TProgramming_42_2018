using System;
using Menu;

namespace Matan
{
    public class Program
    {
        public static double Y(double x, double a, double b)
        {
            return Math.Sqrt(Math.Abs(a - (b * x)) / Math.Pow(Math.Log10(x), 3));
        }

        public static void Main(string[] args)
        {
            double a = 7.2;
            double b = 4.2;
            double xn = 1.81;
            double xk = 5.31;
            double dx = 0.7;

            double[] x = new double[5] { 2.4, 2.8, 3.9, 4.7, 3.16 };

            Console.WriteLine("Задача A:");

            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {Y(xl, a, b):f3}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {Y(i, a, b):f3}");
            }

            Dish salad = new Dish("Cesar", 500, "Salad", 250);
            Dish soup = new Dish("chees", 250);
            salad.GetInfo();
            soup.GetInfo();

            Console.ReadKey();
        }
    }
}