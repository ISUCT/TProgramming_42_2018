using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestofDate
    {
        [Fact]
        public void EqualDates()
        {
            string schetvozrasta = Date.SchetVozrasta(new DateTime(1999, 9, 30), new DateTime(1999, 9, 30));
            Assert.Equal("Ваш возраст: 0 лет, 0 месяцев, 0 дней", schetvozrasta);
        }

        [Fact]
        public void BirthdayBeforeToday()
        {
            string schetvozrasta = Date.SchetVozrasta(new DateTime(1999, 9, 30), new DateTime(2019, 4, 14));
            Assert.Equal("Ваш возраст: 19 лет, 6 месяцев, 14 дней", schetvozrasta);
        }

        [Fact]
        public void BirthdayAfterToday()
        {
            string schetvozrasta = Date.SchetVozrasta(new DateTime(2029, 9, 30), new DateTime(2019, 4, 14));
            Assert.Equal("Еще не родился!", schetvozrasta);
        }
    }
}