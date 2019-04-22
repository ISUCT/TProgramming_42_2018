using System;

namespace exercise_11
{
    public class Program
    {
        public static int Summa(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void Main()
        {
            int[] Massiv = new int[10];
            Massiv[0] = 4;
            Massiv[1] = 2;
            Massiv[2] = 7;

            for (int i = 3; i < 10; i++)
            {
                Massiv[i] = Summa(Massiv[i - 3], Massiv[i - 2], Massiv[i - 1]);
            }

            Console.Write("Первые 10 элементов ряда: ");

            foreach (int j in Massiv)
            {
                Console.Write($"{j} ");
            }

            Console.ReadLine();
        }
    }
}
