using System;

namespace Menu
{
    public class Dish
    {
        private int price;
        private string type;
        private int weight;

        public Dish(string name, int price, string type, int weight)
        {
            Name = name == string.Empty ? $"NoName" : name;
            this.Price = price;
            this.Type = type;
            this.Weight = weight;
        }

        public Dish(string name, int price)
            : this(name, price, string.Empty, 0)
        {
        }

        public string Name { get; set; }

        public int Price
        {
            get => price;
            set
            {
                price = value > 0 ? value : 0;
            }
        }

        public string Type
        {
            get => type;
            set
            {
                type = value == $"Salad" ? value : $"NoType";
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                weight = value > 0 ? value : 0;
            }
        }

        public void GetInfo() => Console.WriteLine($"Название: {Name}  Цена: {price}   Тип: {type}   Вес: {weight}");
    }
}
