using System;

namespace CourseApp
{
    public class Program
    {
        public static double Formula(double x, double a, double b)
        {
            return Math.Pow((a * x) + b, 1 / 3) / Math.Pow(Math.Log10(x), 2);
        }

        private static void Main()
        {
            Console.WriteLine("2 вариант");
            Console.WriteLine();
            Console.WriteLine("Задание А");
            double a = 1.35;
            double b = 0.98;
            double xn = 1.14;
            double xk = 4.24;
            double dx = 0.62;
            for (double x = xn; x <= xk; x = x + dx)
            {
                Console.WriteLine($" x={x} y={Math.Round(Formula(x, a, b), 3)}");
            }

            Console.WriteLine();
            Console.WriteLine("Задание B");
            double[] z = new double[] { 0.35, 1.28, 3.51, 5.21, 4.16 };
            foreach (double element in z)
            {
                Console.WriteLine($" X={element} y={Math.Round(Formula(element, a, b), 3)} ");
            }

            Fox one = new Fox(); // вызов 1-ого
            Fox two = new Fox("Вторая", "Черная"); // вызов 2-ого

            Wolf three = new Wolf("Злой", "Многоцветный", 4); // вызов 3-ого

            one.GetInfo();
            two.GetInfo();
            Console.WriteLine(one.Mut());
            three.GetInfo();
            Console.WriteLine(three.ToString());
            Console.WriteLine(three.Mut());
            Console.WriteLine(one.GetView());
            Console.WriteLine(three.GetView());
            Animals[] animals = new Animals[2];
            animals[0] = new Fox("Первая", "Рыжая", 3);
            animals[1] = new Wolf("Покусанный", "Облезлый", 5);
            foreach (Animals i in animals)
            {
                i.GetInfo();
            }

            Console.Read();
        }
    }
}