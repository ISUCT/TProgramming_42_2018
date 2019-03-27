using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestDate
    {
        private readonly Date dr = new Date();
        private readonly DateTime td = new DateTime(2019, 3, 2);

        [Fact]
        public void TestData20180101()
        {
            DateTime hbd = new DateTime(2018, 1, 1);
            Assert.Equal(@"Year: 01  Month: 02  Day: 01 ", dr.Vozrost(hbd, td));
        }

        [Fact]
        public void TestData19701030()
        {
            DateTime hbd = new DateTime(1975, 10, 30);
            Assert.Equal(@"Year: 43  Month: 04  Day: 02 ", dr.Vozrost(hbd, td));
        }

        [Fact]
        public void TestData19190716()
        {
            DateTime hbd = new DateTime(1919, 7, 16 );
            Assert.Equal(@"Year: 99  Month: 07  Day: 17 ", dr.Vozrost(hbd, td));
        }

        [Fact]
        public void TestData20090302()
        {
            DateTime hbd = new DateTime(2009, 3, 2);
            Assert.Equal(@"Year: 09  Month: 11  Day: 30 ", dr.Vozrost(hbd, td)); // 9 year + 11 month + 30 day = 10 year
        }
    }
}
