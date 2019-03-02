using System;

namespace GetAge
{
    public class GetAge
    {
        public static string _GetAge(DateTime birth) => DateTime.Today.AddYears(-birth.Year).AddMonths(-birth.Month).AddDays(-birth.Day).ToString("Лет: yy\nМесяцев: MM\nДней: dd");
        public static void Main(string[] args)
        {
            DateTime birth = new DateTime(2000, 3, 25);

            Console.WriteLine(_GetAge(birth));
        }
    }
}