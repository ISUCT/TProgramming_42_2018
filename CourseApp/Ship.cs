using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Ship
    {
        private int passangers;
        private int dlina;
        private int vodoizmeschenie;

        public Ship()
        {
            passangers = 20;
            dlina = 50;
            vodoizmeschenie = 100;
        }

        public Ship(int b)
        {
            passangers = 25;
            dlina = b;
            vodoizmeschenie = 100;
        }

        public Ship(int a, int b, int c)
        {
            passangers = a;
            dlina = b;
            vodoizmeschenie = c;
        }

        public int Passangers
        {
            get
            {
                return passangers;
            }

            set
            {
                if (value > 250 || value < 0)
                {
                    Console.WriteLine("Невозможное количество пассажиров(min:0 max:250)");
                    throw new Exception();
                }
                else
                {
                    passangers = value;
                }
            }
        }

        public int Dlina
        {
            get
            {
                return dlina;
            }

            set
            {
                if (value > 1000 || value < 5)
                {
                    Console.WriteLine("Невозможная длина корабля(min:5 max:1000)");
                    throw new Exception();
                }
                else
                {
                    dlina = value;
                }
            }
        }

        public int Vodoizmeschenie
        {
            get
            {
                return vodoizmeschenie;
            }

            set
            {
                if (value > 2000 || value < 10)
                {
                    Console.WriteLine("Невозможное водоизмещение корабля(min:10 max:2000)");
                    throw new Exception();
                }
                else
                {
                    vodoizmeschenie = value;
                }
            }
        }

        public void Info()
        {
            Console.WriteLine($" пассажиров: {passangers} длина: {dlina} водоизмещение: {vodoizmeschenie}");
            Console.WriteLine(ToString());
            Console.WriteLine(Ris());
        }

        public override string ToString()
        {
            return $"Корабль с длиной {dlina} метров вышел в открытое море";
        }

        public string Ris()
        {
            return @"_¶¶¶
_____________________¶
_____________________¶¶¶¶¶¶¶¶¶¶¶¶¶
_____________________¶¶¶___¶__¶_¶¶¶¶
_____________________¶¶¶___¶¶¶¶___¶¶
_____________________¶¶¶__¶¶¶¶¶___¶¶
_____________________¶¶¶__¶¶¶¶¶___¶
_____________________¶¶¶¶¶¶__¶¶___¶
_____________________¶_________¶¶¶¶
_____________¶¶¶¶¶¶¶¶¶¶¶¶¶
_____________¶¶___________¶¶
______________¶____________¶
______________¶_____________¶
_______________¶____________¶
_______________¶____________¶_¶¶
_______________¶__¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶
_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶______________¶
_____¶____________¶¶_____________¶¶____¶
_____¶¶____________¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶
______¶______¶¶¶¶¶¶¶¶¶¶¶¶¶¶______________¶
______¶¶_____¶¶___________¶______________¶¶
_______¶______¶____________¶______________¶
_______¶______¶¶___________¶_____________¶¶
_______¶_______¶___________¶_____________¶¶
______¶¶_______¶___________¶¶____________¶
______¶¶¶¶¶¶¶¶¶¶¶__________¶¶___________¶¶
___________¶_¶_¶¶________¶¶¶_____¶¶¶¶¶¶¶¶_____¶¶¶
___________¶_¶_¶¶¶¶¶¶¶¶¶¶¶_¶¶¶¶¶¶¶_______¶¶¶¶¶__¶¶
¶¶¶¶¶¶_____¶_¶______¶¶_¶_______¶_¶¶¶¶¶¶¶¶¶___¶¶¶¶¶
¶¶___¶¶¶¶¶¶¶¶¶______¶¶_¶____¶¶¶¶¶¶¶________¶¶
__¶¶________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶____¶¶______¶
____¶____________________________¶¶_¶____¶
_____¶_____¶¶¶_____¶¶_____¶¶¶_____¶¶¶___¶¶
______¶___¶¶_¶¶___¶¶_¶____¶_¶¶__________¶
______¶¶____¶¶_____¶¶¶_____¶¶__________¶¶
_______¶¶_____________________________¶¶
________¶¶___________________________¶¶
_________¶¶________________________¶¶¶
___________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶
";
        }
    }
}
