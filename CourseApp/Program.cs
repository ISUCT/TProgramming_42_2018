﻿using System;

namespace CourseApp
{
    public class Program
    {
        public static double Prgrm(double x, float a, float b)
        {
            return (1 + Math.Pow(Math.Log(x / a), 2)) / (b - Math.Pow(Math.E, x / a));
        }

        private static void Main()
        {
            float a = 2.0f;
            float b = 0.95f;
            float xs = 1.25f;
            float xf = 2.75f;
            float dX = 0.3f;

            // задание а
            Console.WriteLine(" a)");
            for (float x = xs; x <= xf; x += dX)
            {
                Console.WriteLine($" x={x} y={Math.Round(Prgrm(x, a, b), 3)}");
            }

            Console.WriteLine();

            // задание b
            Console.WriteLine(" b)");
            double[] xb = new double[5] { 2.2, 3.78, 4.51, 6.58, 1.2 };
            foreach (double i in xb)
            {
                Console.WriteLine($" X={i} y={Math.Round(Prgrm(i, a, b), 3)}");
            }

            Dog snech = new Dog();
            Cat murka = new Cat();
            Console.WriteLine(snech);
            Console.WriteLine(murka);
            Pet[] pet = new Pet[2];
            pet[0] = new Dog();
            pet[1] = new Cat();
            foreach (Pet i in pet)
            {
                i.GetInfo();
                Console.WriteLine(i.Golos());
                Console.WriteLine(i.Picture());
            }

            Date data = new Date();
            DateTime today = DateTime.Today;
            DateTime vremya = new DateTime(1999, 07, 08);
            Console.WriteLine(data.Age(vremya, today));

            Dog nura = new Dog("S");
            Dog sharik = new Dog("S");

            Dog[] homeanimals = new Dog[] { snech, nura, sharik };

            Array.Sort(homeanimals);
            foreach (Dog o in homeanimals)
            {
                Console.WriteLine("{0} - {1}", o.Weight, o.Pol);
            }

            Console.WriteLine(snech.Stroke_dog());
            Console.ReadLine();
        }
    }
}