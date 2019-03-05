using System;

namespace CourseApp
{
    public static class Date
    {
        public static DateTime Calc(DateTime dateOfBorn, DateTime dateOfToDay)
        {
            DateTime age = dateOfToDay;
            age = age.AddYears(-dateOfBorn.Year);
            age = age.AddMonths(-dateOfBorn.Month);
            age = age.AddDays(-dateOfBorn.Day);
            return age;
        }
    }
}