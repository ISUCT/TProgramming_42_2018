using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestDate
    {
        private readonly Date dr = new Date();

        [Fact]
        public void Test_data_20180101()
        {
            DateTime hbd = new DateTime(2018, 1, 1);
            Assert.Equal(@"Year: 01  Month: 02  Day: 01 ", dr.Vozrost(hbd));
        }

        [Fact]
        public void Test_data_19700515()
        {
            DateTime hbd = new DateTime(1970, 5, 15);
            Assert.Equal(@"Year: 48  Month: 09  Day: 17 ", dr.Vozrost(hbd));
        }

        [Fact]
        public void Test_data_19190302()
        {
            DateTime hbd = new DateTime(1919, 7, 16 );
            Assert.Equal(@"Year: 99  Month: 07  Day: 17 ", dr.Vozrost(hbd));
        }
    }
}
