using System;

namespace exercise_14
{
    class Program
    {
        static void Main()
        {
            Car car = new Car();
            double howlong = 200;
            Console.WriteLine(car.start());
            Console.WriteLine($"За время равное {howlong} минутам, расстроение пройденное машиной будет равно {car.drive(200)}");
            Console.WriteLine(car.stop());
            Console.ReadKey();
        }
    }
}
