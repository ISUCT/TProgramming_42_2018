using System;

namespace CourseApp
{
    public abstract class Pet
    {
        public Pet()
        {
            Pol = "K";
            Age = 15;
        }

        public string Pol { get; set; }

        public abstract int Age { get; set; }

        public abstract float Weight { get; set; }

        public abstract string Golos();

        public abstract void GetInfo();

        public abstract string Picture();
    }
}