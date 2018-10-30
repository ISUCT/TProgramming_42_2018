using System;

namespace CourseApp
{
    public class Program
    {
        public static double prgrm(double x, float a, float b)
        {
            return ((1 + Math.Pow(Math.Log(x / a), 2)) / (b - Math.Pow(Math.E, (x / a))));
        }
        static void Main()
        {
            float a = 2.0f;
            float b = 0.95f;
            float Xs = 1.25f;
            float Xf = 2.75f;
            float dX = 0.3f;

            // задание а 
            Console.WriteLine(" a)");
            for (float x = Xs; x <= Xf; x += dX)
            {

                Console.WriteLine($" x={x} y={Math.Round(prgrm(x, a, b), 3)}");

            }
            Console.WriteLine();
            //задание b 
            Console.WriteLine(" b)");
            double[] xb = new double[5] { 2.2, 3.78, 4.51, 6.58, 1.2 };
            foreach (double i in xb)
            {

                Console.WriteLine($" X={i} y={Math.Round(prgrm(i, a, b), 3)}");
            }
            Console.ReadLine();
        }



    }
}
