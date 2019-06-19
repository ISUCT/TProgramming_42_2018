using System;

namespace CourseApp
{
    public class Date
    {
        public static string SchetVozrasta(DateTime bornday, DateTime today)
        {
            DateTime todaydate = today;
            if (today.Day == bornday.Day)
            {
                return "Ваш возраст: 0 лет, 0 месяцев, 0 дней";
            }

            if (today < bornday)
            {
                return $"Еще не родился!";
            }

            todaydate = todaydate.AddYears(-bornday.Year);
            todaydate = todaydate.AddMonths(-bornday.Month);
            todaydate = todaydate.AddDays(-bornday.Day);
            return $"Ваш возраст: {todaydate.Year} лет, {todaydate.Month} месяцев, {todaydate.Day} дней";
        }
    }
}
