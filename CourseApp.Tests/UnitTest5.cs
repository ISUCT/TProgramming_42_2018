using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest5
    {
        [Fact]
        public void Test20()
        {
        DateTime date = Date.Calc(new DateTime(1998, 08, 06), new DateTime(2019, 03, 06));
        DateTime min = new DateTime(1, 1, 12);
        DateTime max = new DateTime(50, 12, 31);
        Assert.InRange(date, min, max);
        }
    }
}