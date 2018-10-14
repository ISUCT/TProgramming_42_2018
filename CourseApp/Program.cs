using System;

namespace CourseApp
{
    class Program
    {

        static void Main()
        {
            float a = 0.8f;
            float b = 0.4f;
            double y;
            // задание а 
            Console.WriteLine(" a)");
            for (float x = 1.23f; x <= 7.23f; x += 1.2f)
            {
                y = ((Math.Pow((x-a),2.0/3)+Math.Pow(Math.Abs(x+b),1.0/5))/(Math.Pow(x*x-(a+b)*(a+b),1.0/9)));

                Console.WriteLine($" x={x} y={y}");

            }
            Console.WriteLine();
            //задание b 
            Console.WriteLine(" b)");
            double[] Xm = new double[5] { 1.88, 2.26, 3.84, 4.55, 6.21 };
            for (int i = 0; i < Xm.Length; i++)
            {
                y = ((Math.Pow((Xm[i]-a),2.0/3)+Math.Pow(Math.Abs(Xm[i]+b),1.0/5))/(Math.Pow(Xm[i]*Xm[i]-(a+b)*(a+b),1.0/9)));

                Console.WriteLine($" X={Xm[i]} y={y}");
            }
            Console.ReadLine();
        }



    }
}