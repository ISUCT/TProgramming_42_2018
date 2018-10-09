using System;

namespace exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double a = 1.1;
            double b = 0.09;
            Console.WriteLine("9 вариант");
            Console.WriteLine("Задание 1");
            for (double i = 1.2; i <= 2.2; i = i + 0.2)
            {
                y = Math.Log10(Math.Pow(i, 2) - 1) / Math.Log(a * Math.Pow(i, 2) - b,5);
                Console.WriteLine($"Для шага {i} функция y = {Math.Round(y, 4)}");
            }

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            double[] mass = new double[5] { 1.21, 1.76, 2.53, 3.48, 4.52 };
            for (int j = 0; j < mass.Length; j++)
            {
                y = Math.Log10(Math.Pow(mass[j], 2) - 1) / Math.Log(a * Math.Pow(mass[j], 2) - b,5);
                Console.WriteLine($"Для шага {mass[j]} функция y = {Math.Round(y, 4)}");
            }

            Console.ReadKey();
        }
    }
}