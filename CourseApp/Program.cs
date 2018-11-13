using System;

namespace CourseApp
{
   public class Program
    {
        public static double Func(double z,float a,float b)
        {
            return ((Math.Pow((z - a), 2.0 / 3) + Math.Pow(Math.Abs(z + b), 1.0 / 5)) / (Math.Pow(z * z - (a + b) * (a + b), 1.0 / 9)));
        }

        static void Main()
        {
            float a = 0.8f;
            float b = 0.4f;
            // задание а
            float xn = 1.23f;//х начальное
            float xk = 7.23f;//х конечное
            float dx = 1.2f;//шаг
            Console.WriteLine(" a)");
            for (float x = xn; x <= xk; x += dx)
            {
                Console.WriteLine($" x={x} y={Math.Round(Func(x,a,b),3)}");
            }
            Console.WriteLine();
            //задание b 
            Console.WriteLine(" b)");
            double[] Xm = new double[5] { 1.88, 2.26, 3.84, 4.55, 6.21 };
            foreach (double i in Xm)
            {
                
                Console.WriteLine($" X={i} y={Math.Round(Func(i,a,b),3)} ");
            }
            Console.ReadLine();
        }
    }
}
