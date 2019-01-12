using System;

namespace ConsoleApp1
{
    public abstract class Land
    {
        private int people;

        private float square;

        public Land()
        {
            Name = "Неизвестная земля";
        }

        public string Name { get; set; }

        public int People
        {
            get
            {
                return people;
            }

            set
            {
                if (value > 0)
                {
                    this.people = value;
                }
            }
        }

        public float Square
        {
            get
            {
                return square;
            }

            set
            {
                if (value > 0)
                {
                    this.square = value;
                }
            }
        }

        public abstract void GetInfo();

        public abstract string Voice();
    }
}
