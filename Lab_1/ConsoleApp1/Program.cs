using System;

namespace ConsoleApp3
{
    class Program
    {

        static void formula(double x, double a, double b)
        {
            double y = ((Math.Pow(a, x) - Math.Pow(b, x)) / (Math.Log10(a / b))) * Math.Pow(Math.Sqrt(a * b), 1 / 3);
            Console.WriteLine($"При х = {x} функция y = {Math.Round(y, 4)}");
        }

        static void Main()
        {
            Console.WriteLine("Вариант 7");
            Console.WriteLine();
            Console.WriteLine("Задание А");
            double a = 0.4;
            double b = 0.8;

            for (double x = 3.2; x <= 6.2; x = x + 0.6)
            {
                formula(x, a, b);
            }

            Console.WriteLine();
            Console.WriteLine("Задание B");
            double[] z = new double[5] { 4.48, 3.56, 2.78, 5.28, 3.21 };
            for (int i = 0; i <= z.Length - 1; i++)
            {
                formula(z[i], a, b);
            }


            Console.ReadKey();
        }

    }
}
