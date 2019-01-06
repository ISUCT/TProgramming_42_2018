using System;

namespace CourseApp
{
    public class Kater : Transport
    {
        public Kater()
            : base()
        {
            Passangers = 5;
            Dlina = 10;
            Vodoizmeschenie = 15;
        }

        public override void Info()
        {
            Console.WriteLine($"Катер: пассажиров:{Passangers} длина:{Dlina} водоизмещение:{Vodoizmeschenie}");
            Console.WriteLine(Predlojenie());
            Console.WriteLine(Picture());
        }

        public override string ToString()
        {
            return $"У катера с длиной {Dlina} громко ревет мотор";
        }

        public override string Predlojenie()
        {
            return $"Катер с длиной {Dlina} метров поплыл вдоль реки";
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
