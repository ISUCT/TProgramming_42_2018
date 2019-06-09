using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestDate
    {
        private readonly Date birthday = new Date();
        private readonly DateTime today = new DateTime(2019, 3, 5);

        [Fact]
        public void TestDate20070909()
        {
            DateTime age = new DateTime(2007, 09, 09);
            Assert.Equal(@"Year: 11  Month: 05  Day: 27 ", birthday.Age(age, today));
        }

        [Fact]
        public void TestDate19800515()
        {
            DateTime age = new DateTime(1980, 05, 15);
            Assert.Equal(@"Year: 38  Month: 09  Day: 20 ", birthday.Age(age, today));
        }

        [Fact]
        public void TestDate19300307()
        {
            DateTime age = new DateTime(1930, 03, 07);
            Assert.Equal(@"Year: 88  Month: 11  Day: 28 ", birthday.Age(age, today));
        }
    }
}