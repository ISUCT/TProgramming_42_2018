using System;

namespace CourseApp
{
    class Program
    {
        static double Func(double z)
        {
            float a = 0.8f;
            float b = 0.4f;
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
                Console.WriteLine($" x={x} y={Func(x)}");
            }
            Console.WriteLine();
            //задание b 
            Console.WriteLine(" b)");
            double[] Xm = new double[5] { 1.88, 2.26, 3.84, 4.55, 6.21 };
            for (int i = 0; i < Xm.Length; i++)
            {

                Console.WriteLine($" X={Xm[i]} y={Func(Xm[i])}");
            }
            Console.ReadLine();
        }



    }
}
