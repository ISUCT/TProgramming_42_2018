using System;
using CourseApp;

namespace CourseApp
{
    public class Program
    {
        public static double Formula(double x, double a, double b)
        {
            return ((Math.Pow(a, x) - Math.Pow(b, x)) / Math.Log10(a / b)) * Math.Pow(a * b, 1 / 3);
        }

        private static void Main()
        {
            Console.WriteLine("Вариант 7");
            Console.WriteLine();
            Console.WriteLine("Задание А");
            double a = 0.4;
            double b = 0.8;

            for (double x = 3.2; x <= 6.2; x += 0.6)
            {
                Console.WriteLine($"При x = {x} y = {Formula(x, a, b)}");
            }

            Console.WriteLine();
            Console.WriteLine("Задание B");
            double[] z = new double[5] { 4.48, 3.56, 2.78, 5.28, 3.21 };
            for (int i = 0; i <= z.Length - 1; i++)
            {
                Console.WriteLine($"При x = {z[i]} y = {Formula(z[i], a, b)}");
            }

            Appliances[] appliances = new Appliances[2];
            appliances[0] = new Television(1, 2, 3, false);
            appliances[1] = new Refrigerator(1, 1, 3, false);
            foreach (Appliances i in appliances)
            {
                i.GetInfo();
            }

            GetAge getAge = new GetAge();
            DateTime birthDate = new DateTime(1975, 10, 30);
            DateTime nowDate = new DateTime(2019, 03, 11);
            Console.WriteLine(getAge.GetInfo(birthDate, nowDate));
            Console.ReadKey();
        }
    }
}
