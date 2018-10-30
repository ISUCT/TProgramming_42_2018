using System;

namespace ConsoleApp3
{
    class Program
    {

        static void formula(double x, double a, double b)
        {
            double y = Math.Sqrt(Math.Abs(a - b * x) / Math.Pow(Math.Log10(x), 3));
            Console.WriteLine($"При х = {x} функция y = {Math.Round(y, 4)}");
        }

        static void Main()
        {
            Console.WriteLine("Вариант 7");
            Console.WriteLine();
            Console.WriteLine("Задание А");
            double a = 7.2; 
            double b = 4.2;

            for (double x = 1.81; x <= 5.31; x = x + 0.7)
            {
                formula(x, a, b);
            }

            Console.WriteLine();
            Console.WriteLine("Задание B");
            double[] z = new double[5] { 2.4, 2.8, 3.9, 4.7, 3.16 };
            for (int i = 0; i <= z.Length - 1; i++)
            {
                formula(z[i], a, b);
            }


            Console.ReadKey();
        }

    }
}
