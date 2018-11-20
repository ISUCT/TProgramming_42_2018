using System;
using CourseApp;

namespace CourseApp
{
    public class Program
    {
        private static object x;

        public static double Func(double z)
        {
            return Math.Pow(Math.Abs((z * z) - 2.5), 1.0 / 4) + Math.Pow(Math.Log(z * z), 1.0 / 3);
        }

        private static void Main()
        {
            // задание а
            float xn = 1.25f;//х начальное
            float xk = 3.25f;//х конечное
            float dx = 0.4f;//шаг
            for (float x = xn; x <= xk; x += dx)
            {
                Console.WriteLine($" x={x} y={Math.Round(Func(x), 3)}");
            }
            Console.WriteLine();
            //задание b           
            double[] Xm = new double[5] { 1.84, 2.71, 3.81, 4.56, 5.62 };
            foreach (double i in Xm)
            {

                Console.WriteLine($" X={i} y={Math.Round(Func(i, x), 3)} ");
            }
            Console.ReadLine();
        }

        private static double Func(double i, object z)
        {
            throw new NotImplementedException();
        }
    }
}