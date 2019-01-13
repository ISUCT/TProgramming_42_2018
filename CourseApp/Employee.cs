using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Employee : HumanBeing
    {
        public Employee()
            : base()
        {
             HireDateTime = new DateTime(2018, 9, 27, 0, 0, 0, 0);
        } // 1 конструктор (перекрытый)

        public Employee(string name, string surname, int age, DateTime hireDateTime)
            : this(name, surname, "Mr.", age, 150, 55, hireDateTime) // 2 конструктор
        {
        }

        public Employee(string name, string surname, string title, int age, int height, int weight, DateTime hireDateTime)
        {
            Name = name;
            Surname = surname;
            Title = title;
            Age = age;
            Height = height;
            Weight = weight;
            HireDateTime = hireDateTime;
        } // 3 конструктор

        public DateTime HireDateTime { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"{Title} {Surname}, {Name}. {Age} years old.");
            Console.WriteLine($"Weight {Weight}, height {Height}.");
            Console.WriteLine($"Hired {HireDateTime.ToString("dd MMMM yyyy")}");
            Console.WriteLine();
        }

        public override void Injury()
        {
            Weight = (int)Math.Floor(Weight * 0.95);
            Console.WriteLine($"Работник жутко травмирован.");
            Console.WriteLine();
        }

        public override string GetHireDate()
        {
            return $"Hired {HireDateTime.ToString("dd MMMM yyyy")}";
        }

        public override string ToString()
        {
            return $"{Title} {Surname}, {Name}";
        }
    }
}
