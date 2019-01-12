using System;

namespace ConsoleApp1
{
    public class Island : Land
    {
        public Island()
            : base()
        {
            People = 24140800;
            Square = 7692024;
        }

        public Island(int people, float square, string name)
        {
            People = people;
            Square = square;
            Name = name;
        }

        public override void GetInfo()
        {
            Console.WriteLine("Земля - остров");
            Console.WriteLine($"Имя: {Name}, население: {People}, площадь: {Square} ");
            Console.WriteLine(Voice());
        }

        public override string ToString()
        {
            return $"Остров {Name} находится в Тихом океане";
        }

        public override string Voice()
        {
            return $"Остров {Name} сказал \'Dhou!\', потонув в океане";
        }
    }
}