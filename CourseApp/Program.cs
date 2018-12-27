using System;

namespace Zadanie1
{
    public class Program
    {
        public static object Colt { get; set; }

        public static double Formula(double x)
        {
            double y = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log(x);
            Console.WriteLine($"при х = {x} функция y = {Math.Round(y, 2)}");
            return y;
        }

        private static void Main()
        {
            Console.WriteLine("1 вариант ");
            for (double x = 0.11; x <= 0.36; x = x + 0.05)
            {
                Formula(x);
            }

            Console.WriteLine();
            Console.WriteLine("2 вариант");
            double[] z = new double[5] { 0.2, 0.3, 0.38, 0.43, 0.57 };
            for (int i = 0; i <= 4; i++)
            {
                Formula(z[i]);
            }

            Console.WriteLine();

            Arsenal[] arsenals = new Arsenal[2];
            arsenals[0] = new Pistol();
            arsenals[1] = new Rifles();
            foreach (Arsenal i in arsenals)
            {
                i.GetInfo();
            }

            Console.ReadKey();
        }
    }
}