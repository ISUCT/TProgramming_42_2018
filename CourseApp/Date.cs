using System;

namespace CourseApp
{
    public static class Date
    {
        public static DateTime Calc(DateTime data1, DateTime data2)
        {
            DateTime age = data2;
            age = age.AddYears(-data1.Year);
            age = age.AddMonths(-data1.Month);
            age = age.AddDays(-data1.Day);
            return age;
        }
    }
}