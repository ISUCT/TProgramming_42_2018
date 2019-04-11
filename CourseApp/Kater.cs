using System;

namespace CourseApp
{
    public class Kater : Transport, ISwim
    {
        private int maxspeed;

        public Kater()
            : base()
        {
            Name = "Carter";
            Dlina = 10;
            Maxspeed = 50;
        }

        public int Maxspeed
        {
            get
            {
                return maxspeed;
            }

            set
            {
                if (value > 400 || value < 1)
                {
                    Console.WriteLine("Невозможное водоизмещение корабля(min:10 max:2000)");
                    throw new Exception();
                }
                else
                {
                    maxspeed = value;
                }
            }
        }

        public string Swim(object o)
        {
            Kater c = o as Kater;
            return $"{Name} плывет по течению";
        }

        public override void Info()
        {
            Console.WriteLine($"Катер: Имя:{Name} длина:{Dlina}, максимальная скорость:{Maxspeed}");
            Console.WriteLine(Predlojenie());
            Console.WriteLine(Picture());
        }

        public override string ToString()
        {
            return $"У катера с длиной {Dlina} громко ревет мотор";
        }

        public override string Predlojenie()
        {
            return $"Катер {Name} поплыл вдоль реки";
        }

        public string Picture()
        {
            return @"

░░░░░░░░░░░░░█▀▀▀█████████▄▄▄░░░░░░░░░░░
░░░░░░░░░░░▄█▀░░░░░█▀░░░░░█▀░░░░░░░░░░░░
███████▄▄▄██▄▄▄▄░░░█░░░░░░█░░▀████▄▄▄▄▄▄
░▄░░░▀▀▀▀▀▀▀▀███████████████▄▄▄█▄▄▄█░░██
░▀█████████▄▄▄▄▄▄▄▄▄░░▀▀▀▀▀▀▀▀▀████████░
░░░▀█████████████████████████▄▄▄▄▄▄▄▄▄░░
░░░░░▀▀███████████████████████████████░░
░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀░░░
";
        }
    }
}
