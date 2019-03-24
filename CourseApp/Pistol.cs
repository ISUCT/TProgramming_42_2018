using System;

namespace CourseApp
{
    public class Pistol : Gun, IShoot, IComparable
    {
        public Pistol()
        {
            Name = "Colt";
            Kalibr = 0.45;
            Mass = 1.4f;
            Emkostmag = 7;
         }

        public Pistol(string name, double kalibr, float mass )
            : base(name, kalibr, mass)
        {
            Emkostmag = 7;
        }

        public string Shoot(object o)
        {
            Pistol c = o as Pistol;
            return $" Я выстрелил из пистолета {c.Name} ";
        }

        public int CompareTo(object o)
        {
            Pistol p = o as Pistol;
            if (p != null)
            {
                return this.Name.CompareTo(p.Name);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
            }

        public override string ToString()
        {
            return $"Наименование: {Name}  Калибр: {Kalibr} Масса: {Mass} Емкость магазина: {Emkostmag}\n Пистолет {Name} Выстрелил: \"Бах!\"";
        }

        public override void GetInfo()
        {
            Console.WriteLine(ToString());
            Console.WriteLine(Display());
        }

        public override string Display()
        {
            return @"

      +-'~`---------------------------------/\--
 ||"""""""""""""""""""""""""""""""" \\\\\\  \/~)
 ||                                  \\\\\\  \/_
  |~~~~~~~~-________________-_________________\ ~--_
  !---------|_________       ------~~~~~(--   )--~~
                      \ /~~~~\~~\   )--- \_ /(
                       ||     |  | \   ()   \\
                       \\____/_ / ()\        \\
                        `~~~~~~~~~-. \        \\
                                    \ \  <($)> \\
                                     \ \        \\
                                      \ \        \\
                                       \ \        \\
                                        \ \  ()    \|
                                        _\_\__====~~~
       

";
        }
    }
}
