using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class Appliances
    {
        private int model;
        private int age;

        public Appliances()
        {
            Model = 1;
            Age = 5;
        }

        public Appliances(int md, int ag)
        {
            Model = md;
            Age = ag;
        }

        public int Model
        {
            get
            {
                return model;
            }

            set
            {
                if (value <= 1)
                {
                    model = 1;
                }
                else if (value >= 2)
                {
                    model = 2;
                }
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else if (value > 15)
                {
                    age = 15;
                }
                else
                {
                    age = value;
                }
            }
        }

        public abstract string Status();

        public abstract string Art();

        public abstract void GetInfo();
    }
}
