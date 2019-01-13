using System;

namespace CourseApp
{
    public abstract class Transport
    {
        private int passangers;
        private int dlina;

        public int Passangers
        {
            get
            {
                return passangers;
            }

            set
            {
                if (value > 250 || value < 0)
                {
                    Console.WriteLine("Невозможное количество пассажиров(min:0 max:250)");
                    throw new Exception();
                }
                else
                {
                    passangers = value;
                }
            }
        }

        public int Dlina
        {
            get
            {
                return dlina;
            }

            set
            {
                if (value > 1000 || value < 5)
                {
                    Console.WriteLine("Невозможная длина корабля(min:5 max:1000)");
                    throw new Exception();
                }
                else
                {
                    dlina = value;
                }
            }
        }

        public abstract void Info();

        public abstract string Predlojenie();
    }
}
