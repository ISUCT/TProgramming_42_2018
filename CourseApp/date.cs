using System;
using CourseApp;

namespace CourseApp
{
    public class Date
    {
        public string Age(DateTime birthday, DateTime today)
        {
            DateTime date = today;
            date = date.AddYears(-birthday.Year);
            date = date.AddMonths(-birthday.Month);
            date = date.AddDays(-birthday.Day);
            return date.ToString(@"\Year: yy  \Mon\t\h: MM  \Da\y: dd ");
        }
    }
}