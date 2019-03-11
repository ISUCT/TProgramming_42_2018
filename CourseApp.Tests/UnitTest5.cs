using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest5
    {
        [Fact]
        public void DateTest2()
        {
            GetAge newAge = new GetAge();
            DateTime birthDate = new DateTime(1975, 10, 30);
            DateTime nowDate = new DateTime(2019, 03, 06);
            Assert.Equal("43, 4, 6", newAge.GetInfo(birthDate, nowDate));
        }

        [Fact]
        public void DateTest3()
        {
            GetAge newAge = new GetAge();
            DateTime birthDate = new DateTime(1978, 09, 30);
            DateTime nowDate = new DateTime(2019, 03, 06);
            Assert.Equal("40, 5, 7", newAge.GetInfo(birthDate, nowDate));
        }
    }
}
