using System;
using CourseApp;

namespace CourseApp
{
    public class Program
    {
        public static double Func(double x, double a, double b)
        {
            return ((a + (b * x)) * (a + (b * x)) * ((a + (b * x)) / 2)) / (1 + Math.Log10(a + (b * x)));
        }

        private static void Main(string[] args)
        {
            double a = 2.5;
            double b = 4.6;

            Console.WriteLine("ЗАДАНИЕ А");
            for (double x = 1.1; x <= 3.6; x += 0.5)
            {
                Console.WriteLine($"y({x})={Func(x, a, b)}");
            }

            Console.WriteLine("ЗАДАНИЕ В");
            double[] mas = new double[] { 1.2, 1.28, 1.36, 1.46, 2.35 };
            foreach (double x in mas)
            {
                Console.WriteLine($"y({x})={Func(x, a, b)}");
            }

            Ship admiral = new Ship();
            Ship lucky = new Ship(90);
            Ship duty = new Ship("Duty", 75, 300);

            admiral.Info();
            lucky.Info();
            duty.Info();

            admiral.Dlina = 200;
            Console.WriteLine($"Длина Адмирала - {admiral.Dlina} метров");
            Console.WriteLine(admiral);
            admiral.Info();

            Kater carter = new Kater();
            carter.Info();
            Console.WriteLine(carter);

            Transport[] transports = new Transport[2];
            transports[0] = new Ship();
            transports[1] = new Kater();

            Console.WriteLine("\nинфо в массиве\n");
            foreach (Transport i in transports)
            {
                i.Info();
            }

            Console.WriteLine(admiral.Swim(admiral));
            Console.WriteLine(lucky.Swim(lucky));
            Console.WriteLine(carter.Swim(carter));

            Ship[] arrayOfShip = new Ship[] {admiral, lucky, duty };

            Array.Sort(arrayOfShip);
            foreach (Ship o in arrayOfShip)
            {
                Console.WriteLine("{0} - {1} - {2}", o.Name, o.Dlina, o.Vodoizmeschenie);
            }

            Console.ReadLine();
        }
    }
}
