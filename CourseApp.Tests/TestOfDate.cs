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
        DateTime date = Date.Calc(new DateTime(1999, 10, 26), new DateTime(2019, 03, 05));
        DateTime min = new DateTime(1, 1, 12);
        DateTime max = new DateTime(100, 12, 31);
        Assert.InRange(date, min, max);
        }
    }
}