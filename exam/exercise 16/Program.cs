using System;

namespace exercise_16
{
    class Program
    {
        public static void Main()
        {
            LengthConverter converter = new LengthConverter();
            double length;
            Console.Write("Введите длину: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Перевести {length} милей в километры: {converter.ConvertMilesToKm(length)}");
            Console.WriteLine($"Перевести {length} километров в мили: {converter.ConvertKmToMiles(length)}");

            Console.ReadLine();
        }
    }
}
