using System;

namespace Zadanie1
{
    public class Program
    {

        public static double Formula(double x)
        {
            double y = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log(x);
            Console.WriteLine($"при х = {x} функция y = {Math.Round(y, 2)}");
            return y;
        }
        static void Main()
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
        
            Pistol Colt = new Pistol
            {
                name = "Colt",
                kalibr = 0.45,
                mass = 1.4f,
                emkostmag = 7
            };
            Colt.GetInfo();
            Colt.display();
         
}
    }
}