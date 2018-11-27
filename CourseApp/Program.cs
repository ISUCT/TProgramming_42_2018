﻿using System;
namespace ConsoleApp1
{
    public class Program
    {

        
        public static double Formula(double x, double a, double b)
        {

            double y = Math.Log(Math.Abs(Math.Pow(b, a) - Math.Pow(x, 2))) / Math.Pow(Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2)), 0.2);
            return y;
        }

        static void Main()
        {
            double a = 2.0;
            double b = 1.1;

            double[] z = new double[5] { 0.1, 0.3, 0.4, 0.45, 0.65 };
            Console.WriteLine("Задание А");
            for (double x = 0.08; x <= 1.08; x = x + 0.2)
            {
                Console.WriteLine(Formula(x,a,b));
            }

            Console.WriteLine();
            Console.WriteLine("Задание Б");
            int i = -1;
            foreach (int x in z)
            {
                i ++;
                Console.WriteLine(Formula(z[i],a,b));
            }

            Console.WriteLine();


            Country tom = new Country();
            Country dom = new Country(146880432, 17125191, "Russia");
            Country bom = new Country(30316, 12.6);


         tom.GetInfo();

        tom.People = 34140800;
        tom.GetInfo();
        tom.People = -1;
        tom.GetInfo();
        dom.GetInfo();
        bom.GetInfo();
        


            Console.Read();
        }
    }
}
