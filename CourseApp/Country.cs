using System;

namespace ConsoleApp1
{
    public class Country
    {
        private int people;

        public Country()
            : this(24140800, 7692024, "Australiya")
        {
        }

        public Country(int a, double b)
            : this(a, b, "Kohma")
        {
        }

        public Country(int people, double square, string name)
        {
            this.people = people;
            this.Square = square;
            this.Name = name;
        }

        public double Square { get; set; }

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

        public void GetInfo()
        {
            Console.WriteLine($"Население:{people} Площадь:{Square}  название страны: {Name}");
        }

                public string Dhou()
        {
            return $"Strana {Name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
        }
    }
    }