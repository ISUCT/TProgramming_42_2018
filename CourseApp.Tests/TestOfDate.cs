using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestOfDate
    {
        [Fact]
        public void DateSame()
        {
            string calc = Date.Calc(new DateTime(1999, 10, 26), new DateTime(1999, 10, 26));
            Assert.Equal("возраст человека  0 лет, 0 месяцев, 0 дней", calc);
        }

        [Fact]
        public void BeforeToDay()
        {
            string calc = Date.Calc(new DateTime(1999, 10, 26), new DateTime(2019, 3, 9));
            Assert.Equal("разность между датами 19 лет, 4 месяцев, 13 дней", calc);
        }

        [Fact]
        public void AfterToDay()
        {
            string calc = Date.Calc(new DateTime(2034, 10, 26), new DateTime(2019, 3, 9));
            Assert.Equal("человек еще не родился, разность между датами 15 лет, 7 месяцев, 17 дней", calc);
        }
    }
}