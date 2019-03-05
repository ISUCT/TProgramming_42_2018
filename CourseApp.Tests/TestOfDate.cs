using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestOfDate
    {
        [Fact]
        public void DateIsNotBelowZeroAndBelowHundredYear()
        {
        DateTime value1 = new DateTime(1999, 10, 26);
        DateTime value2 = new DateTime(2019, 03, 05);
        DateTime date = Date.Calc(value1, value2);
        DateTime min = new DateTime(1, 1, 12);
        DateTime max = new DateTime(100, 12, 31);
        Assert.InRange(date, min, max);
        }
    }
}