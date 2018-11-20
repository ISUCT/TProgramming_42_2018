using System;


namespace CourseApp
{
   public class Pig
    {
        public float Salo { get; set; }
        public int Age { get; set; }
        public string Pol { get; set; }
        private byte proverka = 2;//коэфициент проверки
        public Pig()
        {
            Pol = "M";
            Age = 20;
            Salo = 70.0f;
        }
        public Pig(string n )
        {
            Pol = n;
            if (Pol == "F")
            {
                Age = 15; Salo = 45.0f;
            }
            else
            { Age = 20; Salo = 70.0f; }
        }
        public Pig(float s)
        {
            Salo = s;
            if (Salo <= 70.0f && Salo>45.0f)
            {
                Pol = "M";Age = 20;
            }
            if (Salo <= 45.0f && Salo >= 30.0f)
            {
                Pol = "F";Age = 15;
            }
            if (Salo < 30.0f || Salo > 70.0f) { Console.WriteLine("ОШИБКА!Вес должен попадать в диапазон[30.0f;70.0f]"); proverka = 0; }
        }
        public Pig(int a)
        {
            Age = a;
            if (Age > 15 && Age<=20) { Pol = "M";Salo = 65.0f; }
            if (Age<=15 && Age > 1) { Pol = "F";Salo = 45.0f; }
            if (Age < 1 || Age > 20) { Console.WriteLine("ОШИБКА!Возраст должен попадать в диапазон[1;20]"); proverka = 1; }
        }
        public void Info()
        {
            if (proverka != 0 && proverka !=1) { Console.WriteLine($"Пол: {Pol}  Возраст: {Age}  Масса сало: {Salo}"); }
        }
        public void graz()
        {
            Console.WriteLine($"свинья возраста {Age} пошла поваляться в грязи  ");
        }
        public void ris()
        {
            Console.WriteLine(@"     _
         <`--'\>______
         /. .  `'     \
        (`')  ,        @
         `-._,        /
            )-)_/--( >  
           ''''  ''''");
        }
    }

}
