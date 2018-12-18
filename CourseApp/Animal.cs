using System;

namespace CourseApp
{
    public abstract class Animal
    {
        public Animal()
        {
            Pol = "M";
            Ves = 70.0f;
        }

        public float Ves { get; set; }

        public int Age { get; set; }

        public string Pol { get; set; }

        public abstract string Voice();

        public abstract void Info();

        public abstract string Ris();
    }
}
