using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Skateboarder : HumanBeing
    {
        public Skateboarder()
            : base()
        {
            Stance = "goofy";
        } // 1 конструктор (перекрытый)

        public Skateboarder(string name, string surname, int age, string stance)
            : this(name, surname, "Mr.", age, 150, 55, stance) // 2 конструктор
        {
        }

        public Skateboarder(string name, string surname, string title, int age, int height, int weight, string stance)
        {
            Name = name;
            Surname = surname;
            Title = Title;
            Age = age;
            Height = height;
            Weight = weight;
            Stance = stance;
        } // 3 конструктор

        public string Stance { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname}. {Age} years old.");
            Console.WriteLine($"Weight {Weight}, height {Height}.");
            Console.WriteLine($"Stance {Stance}.");
            Console.WriteLine();
        }

        public override void Injury()
        {
            Weight = (int)Math.Floor(Weight * 0.9);
            Height = (int)Math.Floor(Height * 0.9);
            Stance = "none";
            Console.WriteLine($"Скейтер жутко травмирован.");
            Console.WriteLine();
        }

        public override string GetHireDate()
        {
            return $"Skateboarders cannot be hired.";
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
