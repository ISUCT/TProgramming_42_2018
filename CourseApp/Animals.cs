using System;

namespace CourseApp
{
    public abstract class Animals
    {
        private int age;

        public Animals()
    {
        Name = "Неизвестное";
        Color = "Прозрачный";
    }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public abstract void GetInfo();

        public abstract string Mut();

        public abstract string GetView();
    }
}