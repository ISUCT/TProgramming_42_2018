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
       public void GetInfo()
        {
            Console.WriteLine($"Наименование: {name}  Калибр: {kalibr} Масса: {mass} Емкость магазина: {emkostmag}");
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
    }
}