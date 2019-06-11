using Xunit;
using System;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest5
    {
        [Fact]
        public void UnitTest17()
        {
            GetAge newAge = new GetAge();
            DateTime dateBorn = new DateTime(1997, 02, 08);
            DateTime dateToday = new DateTime(2019, 03, 18);
            Assert.Equal("Возраст: 22, 1, 10", newAge.Get(dateBorn, dateToday));
        }
        [Fact]
        public void UnitTest18()
        {
            GetAge newAge = new GetAge();
            DateTime dateBorn = new DateTime(2019, 03, 18);
            DateTime dateToday = new DateTime(2019, 03, 18);
            Assert.Equal("Это сегодняшняя дата", newAge.Get(dateBorn, dateToday));
        }
        [Fact]
        public void UnitTest19()
        {
            GetAge newAge = new GetAge();
            DateTime dateBorn = new DateTime(2020, 02, 08);
            DateTime dateToday = new DateTime(2019, 03, 18);
            Assert.Equal("Дата ещё не наступила", newAge.Get(dateBorn, dateToday));
        }
    }
}

