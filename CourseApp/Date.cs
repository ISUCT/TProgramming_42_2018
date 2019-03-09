using System;

namespace CourseApp
{
    public static class Date
    {
        public static string Calc(DateTime dateOfBorn, DateTime dateOfToDay)
        {
            DateTime age = dateOfToDay;
            if (dateOfBorn.Day == dateOfToDay.Day)
            {
                return "возраст человека  0 лет, 0 месяцев, 0 дней";
            }

            if (dateOfToDay < dateOfBorn)
            {
                return $"человек еще не родился, {Calc(dateOfToDay, dateOfBorn)}";
            }

            age = age.AddYears(-dateOfBorn.Year);
            age = age.AddMonths(-dateOfBorn.Month);
            age = age.AddDays(-dateOfBorn.Day);
            return $"разность между датами {age.Year} лет, {age.Month} месяцев, {age.Day} дней";
        }
    }
}