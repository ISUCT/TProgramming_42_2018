using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest5
    {
        [Fact]
        public void DateTest1()
        {
            GetAge newAge = new GetAge();
            Assert.Equal(18, newAge.GetInfo(25, 03, 2000).Year);
            Assert.Equal(11, newAge.GetInfo(25, 03, 2000).Month);
            Assert.Equal(6, newAge.GetInfo(25, 03, 2000).Day);
        }

        [Fact]
        public void DateTest2()
        {
            GetAge newAge = new GetAge();
            Assert.Equal(43, newAge.GetInfo(30, 10, 1975).Year);
            Assert.Equal(4, newAge.GetInfo(30, 10, 1975).Month);
            Assert.Equal(2, newAge.GetInfo(30, 10, 1975).Day);
        }

        [Fact]
        public void DateTest3()
        {
            GetAge newAge = new GetAge();
            Assert.Equal(40, newAge.GetInfo(30, 09, 1978).Year);
            Assert.Equal(5, newAge.GetInfo(30, 09, 1978).Month);
            Assert.Equal(1, newAge.GetInfo(30, 09, 1978).Day);
        }
    }
}
