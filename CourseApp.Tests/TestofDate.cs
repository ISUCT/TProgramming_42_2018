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
            Assert.Equal("��� �������: 0 ���, 0 �������, 0 ����", schetvozrasta);
        }

        [Fact]
        public void BirthdayBeforeToday()
        {
            string schetvozrasta = Date.SchetVozrasta(new DateTime(1999, 9, 30), new DateTime(2019, 4, 14));
            Assert.Equal("��� �������: 19 ���, 6 �������, 14 ����", schetvozrasta);
        }

        [Fact]
        public void BirthdayAfterToday()
        {
            string schetvozrasta = Date.SchetVozrasta(new DateTime(2029, 9, 30), new DateTime(2019, 4, 14));
            Assert.Equal("��� �� �������!", schetvozrasta);
        }
    }
}