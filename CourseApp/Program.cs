using System;
using CourseApp;

namespace CourseApp
{
    public class Program
    {
        public static double Func(double z, float a, float b)
        {
            return (Math.Pow(z - a, 2.0 / 3) + Math.Pow(Math.Abs(z + b), 1.0 / 5)) / Math.Pow((z * z) - ((a + b) * (a + b)), 1.0 / 9);
        }

        public static void Main()
        {
            float a = 0.8f;
            float b = 0.4f;

            // a
            float xn = 1.23f; // x first
            float xk = 7.23f; // х last
            float dx = 1.2f; // stap
            Console.WriteLine(" a)");
            for (float x = xn; x <= xk; x += dx)
            {
                Console.WriteLine($" x={x} y={Math.Round(Func(x, a, b), 3)}");
            }

            Console.WriteLine();

            // задание b
            Console.WriteLine(" b)");
            double[] xm = new double[5] { 1.88, 2.26, 3.84, 4.55, 6.21 };
            foreach (double i in xm)
            {
                Console.WriteLine($" X={i} y={Math.Round(Func(i, a, b), 3)} ");
            }

            Pig svin = new Pig();
            Cow murka = new Cow();
            Console.WriteLine(svin);
            Console.WriteLine(murka);
            Animal[] animal = new Animal[2];
            animal[0] = new Pig();
            animal[1] = new Cow();
            foreach (Animal i in animal)
            {
                i.Info();
            }

            Pig alkash = new Pig(5);
            Pig pitochok = new Pig(20);

            Pig[] slaughterhouse = new Pig[] { svin, alkash, pitochok };

            Array.Sort(slaughterhouse);
            Console.WriteLine("vasha svinii na uboi");
            Console.WriteLine("Salo-Age");
            foreach (Pig o in slaughterhouse)
            {
                Console.WriteLine("{0} - {1}", o.Salo, o.Age);
            }

            Date dr = new Date();
            DateTime td = DateTime.Today;
            DateTime hbd = new DateTime(1999, 5, 11);
            Console.WriteLine($"vozrast = {dr.Vozrost(hbd, td)}");

            Console.ReadLine();
        }
    }
}
