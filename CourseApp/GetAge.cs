using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class GetAge
    {
        public string GetInfo(DateTime birthDate, DateTime nowDate)
        {
            nowDate = nowDate.AddYears(-birthDate.Year);
            nowDate = nowDate.AddMonths(-birthDate.Month);
            nowDate = nowDate.AddDays(-birthDate.Day);

            return $"{nowDate.Year}, {nowDate.Month}, {nowDate.Day}";
        }
    }
}
