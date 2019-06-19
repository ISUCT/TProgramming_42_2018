using System;

namespace CourseApp
{
    public abstract class Transport
    {
        private string name;
        private int dlina;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value != null)
                {
                    this.name = value;
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
