using System;
using CourseApp;

namespace CourseApp
{
    public class Date
    {
        public string Age(DateTime birthday)
        {
            DateTime date = new DateTime(2019, 03, 05);
            date = date.AddYears(-birthday.Year);
            date = date.AddMonths(-birthday.Month);
            date = date.AddDays(-birthday.Day);
            return date.ToString(@"\Year: yy  \Mon\t\h: MM  \Da\y: dd ");
        }
    }
}