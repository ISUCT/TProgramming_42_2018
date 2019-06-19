using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Ship : Transport, ISwim, IComparable
    {
        private int vodoizmeschenie;

        public Ship()
            : base()
        {
            Name = "Admiral";
            Dlina = 55;
            Vodoizmeschenie = 100;
        }

        public Ship(int dlina)
        {
            Name = "Lucky";
            Dlina = dlina;
            Vodoizmeschenie = 100;
        }

        public Ship(string name, int dlina, int vodoizmeschenie)
        {
            Name = name;
            Dlina = dlina;
            Vodoizmeschenie = vodoizmeschenie;
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

        public string Swim(object o)
        {
            Ship c = o as Ship;
            return $"Корабль {c.Name} остановился у причала";
        }

        public int CompareTo(object o)
        {
            Ship p = o as Ship;
            if (p != null)
            {
                return this.Name.CompareTo(p.Name);
            }
            else
            {
                throw new Exception("Невозможно сравнить");
            }
        }

        public override void Info()
        {
            Console.WriteLine($"Корабль: Имя:{Name} длина:{Dlina} водоизмещение:{Vodoizmeschenie}");
            Console.WriteLine(Predlojenie());
            Console.WriteLine(Ris());
        }

        public override string ToString()
        {
            return $"Корабль с длиной {Dlina}  громко гудит";
        }

        public override string Predlojenie()
        {
            return $"Корабль {Name} вышел в открытое море";
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
