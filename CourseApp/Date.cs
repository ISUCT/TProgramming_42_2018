using System;
using CourseApp;

namespace CourseApp
{
    public class Date
    {
        public string Vozrost(DateTime hbd, DateTime td)
        {
            DateTime today = td;
            today = today.AddYears(-hbd.Year);
            today = today.AddMonths(-hbd.Month);
            today = today.AddDays(-hbd.Day);
            return today.ToString(@"\Year: yy  \Mon\t\h: MM  \Da\y: dd ");
        }
    }
}
