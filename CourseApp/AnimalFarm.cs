using System;

namespace CourseApp
{
    public abstract class AnimalFarm
    {
        public int Age { get; set; }

        public string Pol { get; set; }

        public abstract void Voice();

        public abstract void Info();

        public abstract string Ris();
    }
}
