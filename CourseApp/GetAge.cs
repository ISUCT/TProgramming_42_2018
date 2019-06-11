using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class GetAge
    {
        public string Get(DateTime dateBorn, DateTime dateToday)
        {
            if (dateBorn == dateToday)
            {
                return "Это сегодняшняя дата";
            }

            if (dateToday < dateBorn)
            {
                return $"Дата ещё не наступила";
            }

            dateToday = dateToday.AddYears(-dateBorn.Year);
            dateToday = dateToday.AddMonths(-dateBorn.Month);
            dateToday = dateToday.AddDays(-dateBorn.Day);

            return $"Возраст: {dateToday.Year}, {dateToday.Month}, {dateToday.Day}";
        }
    }
}
