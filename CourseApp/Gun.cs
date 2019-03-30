using System;

namespace CourseApp
{
    public abstract class Gun
    {
        private string name;
        private double kalibr;
        private float mass;
        private byte emkostmag;

        public Gun()
        {
        }

        protected Gun(string name, double kalibr, float mass)
        {
            this.name = name;
            this.kalibr = kalibr;
            this.mass = mass;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Слишком длинное название");
                }
                else if (value.Length < 0)
                {
                    name = "Без названия";
                }
                else
                {
                    name = value;
                }
            }
        }

        public double Kalibr
        {
            get
            {
                return kalibr;
            }

            set
            {
                if (value >= 7.62)
                {
                    kalibr = 7.62;
                }
                else if (value < 0)
                {
                    name = "оружие повреждено";
                }
                else
                {
                    kalibr = value;
                }
            }
        }

        public float Mass
        {
            get
            {
                return mass;
            }

            set
            {
                if (value > 10)
                {
                    Console.WriteLine("Оружие слишком тяжелое ");
                }
                else if (value < 0)
                {
                    name = "оружие уничтожено";
                }
                else
                {
                    mass = value;
                }
            }
        }

           public byte Emkostmag
        {
            get
            {
                return emkostmag;
            }

            set
            {
                if (value > 50)
                {
                    emkostmag = 50;
                }
                else if (value < 0)
                {
                    name = "магазин отсутсвует";
                }
                else
                {
                    emkostmag = value;
                }
            }
        }

        public abstract void GetInfo();

        public abstract string Display();
    }
}
