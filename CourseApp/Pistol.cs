using System;
namespace Zadanie1
{
    public class Pistol
    {
        public string name; // имя
        public double kalibr;
        public float mass;
        public int emkostmag;

        public void GetInfo()
        {
            Console.WriteLine($"Наименование: {name}  Калибр: {kalibr} Масса: {mass} Емкость магазина: {emkostmag}");
        }
    }
}