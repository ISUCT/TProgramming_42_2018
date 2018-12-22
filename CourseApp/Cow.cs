using System;

namespace CourseApp
{
    public class Cow : Animal
    {
        public Cow()
            : base()
        {
            Age = 15;
            Meat = Ves;
        }

        public Cow(float m)
        {
            Meat = m;
            Age = 13;
            Pol = "M";

            if (Meat < 50.0f || Meat > 100.0f)
            {
                Console.WriteLine("ОШИБКА!Вес должен попадать в диапазон[50.0f;100.0f]");
                throw new Exception();
            }
        }

        public Cow(int age)
        {
            Age = age;
            Pol = "F";
            Meat = 75.0f;
            if (Age < 1 || Age > 15)
            {
                Console.WriteLine("ОШИБКА!Возраст должен попадать в диапазон[1;20]");
                throw new Exception();
            }
        }

        public Cow(string pol)
        {
            Pol = pol;
            if (Pol == "F")
            {
                Age = 15;
                Meat = 75.0f;
            }
            else
            {
                Age = 13;
                Meat = 80.0f;
            }
        }

        public float Meat { get; set; }

        public override string ToString()
        {
            return $"это Корова возраста {Age} и массой {Meat}";
        }

        public override string Voice()
        {
            return $"Корова пола {Pol} издала звук Мууу";
        }

        public override void Info()
        {
            Console.WriteLine($"Пол: {Pol}  Возраст: {Age}  масса мяса: {Meat}");
            Console.WriteLine(Voice());
            Console.WriteLine(Ris());
        }

        public override string Ris()
        {
            return @"

░░░░░░▄░░░░░░░░░░░░░░░░░░▄░░░░░░░░░░░░
░░░░░░█▄░░░░░░░░░░░░░░░▄██░░░░░░░░░░░░
███▄░░███▄░░░░▄▄▄▄░░░▄████░░░░░░░░░░░░
▀█████▄██████████████████░░░░▄▄██░░░░░
░████████▀▀▀█████░░░▀████▄▄▄█████░░░░░
░░▀█████▀░▄██████░░░██████████▀██░░░░░
░░░░░░██░░▀████▀░░░░▀███▀▀▀▀▀▄██░░░░░░
░░░░░▄██▄░░░░░░░▄████▀░░▄▄███▀▀░░░░░░░
░░░░░░███░░░░░░█████▀░░░▀███▄▄░░░░░░░░
░░░░░░▀█▀░░░░░░▀██▀▀░░░░▄▄██████▄▄░░░░
░░░░░▄▀░░░░░░░░░░░░░░░░████████████░▄░
░░░▄███▄▄▄███▄░░░░░░░░█████████████░██
░░░█▀▀▀██▀▀▀▀█▄░░░░░░░▀███████████░██░
░░░█▀█░░░▀█░░█░█░░░░░░░▀▀▀▀█████▀▄██░░
░░░▀▄▄▄██▄▄▄██▀░░░░░░░░░░░█████▀▄█▀░░░
░░░░▀▀███████▀██▄░░░░░░░▄████▀▄██▀░░░░
░░░░░░░░░░░░░░░▀███▄░░▄████▀▄██▀░░░░░░
░░░░░░░░░░░░░░░██████████▀▄██▀░░░░░░░░
░░░░░░░░░░░░░░█████████▀▄██▀░░░░░░░░░░
░░░░░░░░░░░░░████████▀▄██▀░░░░░░░░░░░░";
        }
    }
}
