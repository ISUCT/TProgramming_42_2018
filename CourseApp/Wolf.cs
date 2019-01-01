using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Wolf : Animals
    {
        public Wolf()
    : base()
        {
            Age = 2;
        } // 1 конструктор (перекрытый)

        public Wolf(string name, string color)
            : this(name, color, 3)
        {
        } // 2 конструктор

        public Wolf(string name, string color, int age)
        {
            Name = name;
            Color = color;
            this.Age = age;
        } // 3 конструктор

        public override string ToString()
        {
            return $"Волк {Name} пошёл всех кусать, но его укусила лисица";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name} Цвет: {Color} Возраст: {Age}");
        }

        public override string Mut()
        {
            return $"Волки покорились мутировавшим лисицам";
        }

        public override string GetView()
        {
            return @"   ,     ,
                        |\---/|
                       /  , , |
                  __.-'|  / \ /
         __ ___.-'        ._O|
      .-'  '        :      _/
     / ,    .        .     |
    :  ;    :        :   _/
    |  |   .'     __:   /
    |  :   /'----'| \  |
    \  |\  |      | /| |
     '.'| /       || \ |
     | /|.'       '.l \\_
     || ||             '-'
     '-''-'";
        }
    }
}