using System;

namespace CourseApp
{
    public class Fox : Animals
    {
        public Fox()
    : base()
        {
            Age = 2;
        } // 1 конструктор (перекрытый)

        public Fox(string name, string color)
            : this(name, color, 3) // 2 конструктор
        {
        }

        public Fox(string name, string color, int age)
        {
            Name = name;
            Color = color;
            Age = age;
        } // 3 конструктор

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name} Цвет: {Color} Возраст: {Age}");
        }

        public override string Mut()
        {
            return $"Из-за странного корма все лисы мутировали, покорили мир и сделали людей своими рабами";
        }

        public override string GetView()
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