using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class HumanBeing
    {
        private int age; // years
        private int height; // cm
        private int weight; // kg

        public HumanBeing()
        {
            Name = "John";
            Surname = "Smith";
            Title = "Mr.";
            age = 30;
            height = 120;
            weight = 120;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Title { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if((value > 0) && (value < 600))
                {
                    age = value;
                }
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if((value > 50) && (value < 250))
                {
                    height = value;
                }
            }
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if((value > 40) && (value < 180))
                {
                    weight = value;
                }
            }
        }

        public abstract void GetInfo();

        public abstract void Injury();

        public abstract string GetHireDate();
    }
}
