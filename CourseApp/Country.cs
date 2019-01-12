using System;

namespace ConsoleApp1
{
    public class Country : Land
    {
        public Country()
            : base()
        {
            People = 24140800;
            Square = 7692024;
        }

        public Country(int a, float b)
            : this(a, b, "Kohma")
        {
        }

        public Country(int people, float square, string name)
        {
            People = people;
            Square = square;
            Name = name;
        }

        public override void GetInfo()
        {
            Console.WriteLine("����� - ������");
            Console.WriteLine($"���: {Name}, ���������: {People}, �������: {Square} ");
            Console.WriteLine(Voice());
        }

        public override string ToString()
        {
            return $"������ {Name} ��������� � �������";
        }

        public override string Voice()
        {
            return $"������ {Name} ������� \'Dhou!\', ���������� � ����";
        }
    }
    }