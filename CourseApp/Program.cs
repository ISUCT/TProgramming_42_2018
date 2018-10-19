﻿using System;

namespace CourseApp
{
    class Program
    {
        static double Func(double z,float a,float b)
        {
            return ((Math.Pow((z - a), 2.0 / 3) + Math.Pow(Math.Abs(z + b), 1.0 / 5)) / (Math.Pow(z * z - (a + b) * (a + b), 1.0 / 9)));
        }

        static void Main()
        {
            float a = 0.8f;
            float b = 0.4f;
            double y;
            // задание а 
            Console.WriteLine(" a)");
            for (float x = 1.23f; x <= 7.23f; x += 1.2f)
            {
                Console.WriteLine($" x={x} y={Func(x,a,b)}");
            }
            Console.WriteLine();
            //задание b 
            Console.WriteLine(" b)");
            double[] Xm = new double[5] { 1.88, 2.26, 3.84, 4.55, 6.21 };
            foreach (double i in Xm)
            {
                
                Console.WriteLine($" X={i} y={Func(i,a,b)}");
            }
            Console.ReadLine();
        }
    }
}
