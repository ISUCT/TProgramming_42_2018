using System;

namespace Zadanie1
{
    public class Pistol
    {
        private string name; // имя
        private double kalibr;
        private float mass;
        private byte emkostmag;

        public Pistol()
        {
            name = "Colt";
            kalibr = 0.45;
            mass = 1.4f;
            emkostmag = 7;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Слишком длинное название");
                }
                else if (value.Length < 0)
                {
                    name = "Без названия";
                }
                else
                {
                    name = value;
                }
            }
        }

        public double Kalibr
        {
            get
            {
                return kalibr;
            }

            set
            {
                if (value > 1)
                {
                    Console.WriteLine("Ствол не расчитан на этот калибр");
                }
                else if (value < 0)
                {
                    name = "оружие повреждено";
                }
                else
                {
                    kalibr = value;
                }
            }
        }

        public float Mass
        {
            get
            {
                return mass;
            }

            set
            {
                if (value > 10)
                {
                    Console.WriteLine("Оружие слишком тяжелое для совего класса");
                }
                else if (value < 0)
                {
                    name = "оружие уничтожено";
                }
                else
                {
                    mass = value;
                }
            }
        }

        public byte Emkostmag
        {
            get
            {
                return emkostmag;
            }

            set
            {
                if (value > 20)
                {
                    Console.WriteLine("таких магазинов не существует");
                }
                else if (value < 0)
                {
                    name = "магазин отсутсвует";
                }
                else
                {
                    emkostmag = value;
                }
            }
        }

        public string GetInfo()
        {
            return $"Наименование: {name}  Калибр: {kalibr} Масса: {mass} Емкость магазина: {emkostmag}\n Пистолет {name} выстрелил: \"Бах!\"";
        }

        public string Display()
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
