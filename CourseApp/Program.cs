using System;
using CourseApp;

namespace Zadanie1
{
    public class Program
    {
        public static object Colt { get; set; }

        public static object Pm { get; set; }

        public static object Walter { get; set; }

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

            Gun[] arsenals = new Gun[2];
            arsenals[0] = new Pistol();
            arsenals[1] = new Rifles();
            foreach (Gun i in arsenals)
            {
                i.GetInfo();
            }

            DateTime data1 = new DateTime(1999, 05, 13);
            DateTime data2 = new DateTime(2019, 03, 05);
            Console.WriteLine("человек прожил - " + Date.Calc(data1, data2 ));

            Pistol colt = new Pistol();
            Pistol walter = new Pistol("walter", 7.92, 3.5f );
            Console.WriteLine(colt.Shoot(colt));
            Console.WriteLine(walter.Shoot(walter));

            Pistol[] arrayOfPistol = new Pistol[] { colt, walter };

            Array.Sort(arrayOfPistol);
            foreach (Pistol o in arrayOfPistol)
            {
                Console.WriteLine("{0} - {1} - {2}", o.Name, o.Kalibr, o.Mass);
            }

            Console.ReadKey();
        }
    }
}