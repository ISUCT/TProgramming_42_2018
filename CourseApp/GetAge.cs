using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class GetAge
    {
        public DateTime GetInfo(int dd, int mm, int yyyy)
        {
            DateTime date = new DateTime(yyyy, mm, dd);
            DateTime result = DateTime.Today;
            result = result.AddYears(-date.Year);
            result = result.AddDays(-date.Day);
            result = result.AddMonths(-date.Month);
            Console.WriteLine($"{result.Year}, {result.Day}, {result.Month}");
            return result;
        }
    }
}
