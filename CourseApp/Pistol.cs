using System;

namespace Zadanie1
{
    public class Pistol : Arsenal
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

        public override string ToString()
        {
            return $"Наименование: {Name}  Калибр: {Kalibr} Масса: {Mass} Емкость магазина: {Emkostmag}\n Пистолет {Name} выстрелил: \"Бах!\"";
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
