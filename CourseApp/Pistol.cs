using System;
namespace Zadanie1
{
    public class Pistol
    {
        public string name; // имя
        public double kalibr;
        public float mass;
        public int emkostmag;
        public Pistol() { name = "Colt";kalibr = 0.45;mass = 1.4f;emkostmag = 7; }
       public string GetInfo()
        {
            return($"Наименование: {name}  Калибр: {kalibr} Масса: {mass} Емкость магазина: {emkostmag}\n Пистолет {name} выстрелил: \"Бах!\"");
        }

        public string display()
        {
            return(@"

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
       

");
         
        }

        public static implicit operator string(Pistol v)
        {
            throw new NotImplementedException();
        }
    }
}