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
        public void Test_data_20180101()
        {
            DateTime hbd = new DateTime(2018, 1, 1);
            Assert.Equal(@"Year: 01  Month: 02  Day: 01 ", dr.Vozrost(hbd, td));
        }

        [Fact]
        public void Test_data_19700515()
        {
            DateTime hbd = new DateTime(1975, 10, 30);
            Assert.Equal(@"Year: 43  Month: 04  Day: 02 ", dr.Vozrost(hbd, td));
        }

        [Fact]
        public void Test_data_19190302()
        {
            DateTime hbd = new DateTime(1919, 7, 16 );
            Assert.Equal(@"Year: 99  Month: 07  Day: 17 ", dr.Vozrost(hbd, td));
        }
    }
}
