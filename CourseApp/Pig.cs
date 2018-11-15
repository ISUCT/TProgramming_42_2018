using System;


namespace ConsoleApp4
{
   public class Pig
    {
       public float salo;
       public int age;
        public string pol;
        private byte proverka = 2;//коэфициент проверки
        public Pig()
        {
            pol = "M";
            age = 20;
            salo = 70.0f;
        }
        public Pig(string n )
        {
            pol = n;
            if (pol == "F")
            {
                age = 15; salo = 45.0f;
            }
            else
            { age = 20; salo = 70.0f; }
        }
        public Pig(float s)
        {
            salo = s;
            if (salo <= 70.0f && salo>45.0f)
            {
                pol = "M";age = 20;
            }
            if (salo <= 45.0f && salo >= 30.0f)
            {
                pol = "F";age = 15;
            }
            if (salo < 30.0f || salo > 70.0f) { Console.WriteLine("ОШИБКА!Вес должен попадать в диапазон[30.0f;70.0f]"); proverka = 0; }
        }
        public Pig(int a)
        {
            age = a;
            if (age > 15 && age<=20) { pol = "M";salo = 65.0f; }
            if (age<=15 && age > 1) { pol = "F";salo = 45.0f; }
            if (age < 1 || age > 20) { Console.WriteLine("ОШИБКА!Возраст должен попадать в диапазон[1;20]"); proverka = 1; }
        }
        public void Info()
        {
            if (proverka != 0 && proverka !=1) { Console.WriteLine($"Пол: {pol}  Возраст: {age}  Масса сало: {salo}"); }
        }

    }

}
