using System;

namespace CourseApp
{
    public class Cat : Pet
    {
        public Cat()
            : base()
        {
            Weight = 15.0f;
        }

        public Cat(string n)
        {
            Pol = n;
            if (Pol == "K")
            {
                Age = 9;
                Weight = 10.0f;
            }
            else
            {
                Age = 11;
                Weight = 12.0f;
            }
        }

        public override float Weight { get; set; }

        public override int Age { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Пол: {Pol} Возраст: {Age} Вес: {Weight}");
        }

        public override string Golos()
        {
            return $"кот возраста {Age} подал голос мяу ";
        }

        public override string Picture()
        {
            return @" 
    /\___/\
   (  o o  )
   /   *   \
   \__\_/__/ meow!
     /   \
    / ___ \
    \/___\/";
        }

        public override string ToString()
        {
            return $"кот возраста {Age} и полом {Pol}";
        }
    }
}