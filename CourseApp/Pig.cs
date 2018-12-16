using System;

namespace CourseApp
{
    public class Pig : AnimalFarm
    {
        public Pig()
            : base()
        {
            Age = 20;
            Salo = Ves;
        }

        public Pig(string n)
        {
            Pol = n;
            if (Pol == "F")
            {
                Age = 15;
                Salo = 45.0f;
            }
            else
            {
                Age = 20;
                Salo = 70.0f;
            }
        }

        public Pig(float s)
        {
            Salo = s;
            if (Salo <= 70.0f && Salo > 45.0f)
            {
                Pol = "M";
                Age = 20;
            }

            if (Salo <= 45.0f && Salo >= 30.0f)
            {
                Pol = "F";
                Age = 15;
            }

            if (Salo < 30.0f || Salo > 70.0f)
            {
                Console.WriteLine("ОШИБКА!Вес должен попадать в диапазон[30.0f;70.0f]");
                throw new Exception();
            }
        }

        public Pig(int a)
        {
            Age = a;
            if (Age > 15 && Age <= 20)
            {
                Pol = "M";
                Salo = 65.0f;
            }

            if (Age <= 15 && Age > 1)
            {
                Pol = "F";
                Salo = 45.0f;
            }

            if (Age < 1 || Age > 20)
            {
                Console.WriteLine("ОШИБКА!Возраст должен попадать в диапазон[1;20]");
                throw new Exception();
            }
        }

        public float Salo { get; set; }

        public override string ToString()
        {
            return "это Свинья";
        }

        public override void Info()
        {
            Console.WriteLine($"Пол: {Pol}  Возраст: {Age}  Масса сало: {Salo}");
            Console.WriteLine(Graz());
            Console.WriteLine(Voice());
            Console.WriteLine(Ris());
        }

        public string Graz()
        {
            return $"свинья возраста {Age} пошла поваляться в грязи  ";
        }

        public override string Ris()
        {
            return @"     _
         <`--'\>______
         /. .  `'     \
        (`')  ,        @
         `-._,        /
            )-)_/--( >  
           ''''  ''''";
        }

        public override string Voice()
        {
            return $"свинья пола {Pol} издала звук хрю хрю";
        }
    }
}
