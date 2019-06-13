using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class Appliances : IStatus
    {
        private int model;
        private int age;

        public Appliances()
        {
            Model = 1;
            Age = 5;
            Status = true;
        }

        public Appliances(int md, int ag, bool st)
        {
            Model = md;
            Age = ag;
            Status = st;
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

        public abstract bool Status { get; set; }

        public abstract string Art();

        public abstract void GetInfo();
    }
}
