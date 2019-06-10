using System;

namespace ConsoleApp1
{
    public class Date
    {
        public string Vozrast(DateTime bd)
        {
            DateTime today = new DateTime(2019, 3, 2);
            today = today.AddYears(-bd.Year);
            today = today.AddMonths(-bd.Month);
            today = today.AddDays(-bd.Day);
            return today.ToString(@"\Year: yy  \Mon\t\h: MM  \Da\y: dd ");
        }
    }
}