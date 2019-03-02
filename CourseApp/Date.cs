using System;
using CourseApp;

namespace CourseApp
{
    public class Date
    {
        public string Vozrost(DateTime hbd)
        {
            DateTime today = new DateTime(2019, 3, 2);
            today = today.AddYears(-hbd.Year);
            today = today.AddMonths(-hbd.Month);
            today = today.AddDays(-hbd.Day);
            return today.ToString(@"\Year: yy  \Mon\t\h: MM  \Da\y: dd ");
        }
    }
}
