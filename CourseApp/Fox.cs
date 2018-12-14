using System;

namespace CourseApp
{
    public class Fox
    {
        private int age;

        public Fox()
            : this("Первая", "Рыжая", 3)
        {
        } // 1 конструктор

        public Fox(string name, string color)
            : this(name, color, 3)
        {
        } // 2 конструктор

        public Fox(string name, string color, int age)
        {
            Name = name;
            Color = color;
            this.age = age;
        } // 3 конструктор

        public string Name { get; set; }

        public string Color { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {Name} Цвет: {Color} Возраст: {age}");
        }

        public void Mut()
        {
            Console.WriteLine($"Из-за странного корма все лисы мутировали, покорили мир и сделали людей своими рабами");
        }

        public string GetView()
        {
            return @"   
                                                                   ,-,
                                                             _.-=;~ /_
                                                          _-~   '     ;.
                                                      _.-~     '   .-~-~`-._
                                                _.--~~:.             --.____88
                              ____.........--~~~. .' .  .        _..-------~~
                     _..--~~~~               .' .'             ,'
                 _.-~                        .       .     ` ,'
               .'                                    :.    ./
             .:     ,/          `                   ::.   ,'
           .:'     ,(            ;.                ::. ,-'
          .'     ./'.`.     . . /:::._______.... _/:.o/
         /     ./'. . .)  . _.,'               `88;?88|
       ,'  . .,/'._,-~ /_.o8P'                  88P ?8b
    _,'' . .,/',-~    d888P'                    88'  88|
 _.'~  . .,:oP'        ?88b              _..--- 88.--'8b.--..__
:     ...' 88o __,------.88o ...__..._.=~- .    `~~   `~~      ~-._ Seal _.
`.;;;:='    ~~            ~~~                ~-    -       -   -";
        }
    }
}