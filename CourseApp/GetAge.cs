using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class GetAge
    {
        public void GetInfo()
        {
            DateTime date = new DateTime(2000, 03, 25);
            DateTime result = DateTime.Today;

            result = result.AddYears(-date.Year);
            result = result.AddDays(-date.Day);
            result = result.AddMonths(-date.Month);

            int days = DateTime.Today.Subtract(date).Days;
            int years = days / 365;
            int months = 0;
            while (date.AddMonths(1) <= DateTime.Today)
            {
                date = date.AddMonths(1);
                months++;
            }

            Console.WriteLine($"{years}, { days}, {months}");
            Console.WriteLine($"{result.Year}, {result.Day}, {result.Month}");
        }
    }
}
