using System;
using Xunit;

using ConsoleApp1;

namespace CourseApp.Tests
{
    public class UnitTest5_DateTime
    {
        private readonly Date td = new Date();

        [Fact]
        public void Test_data_2000_01_01()
        {
            DateTime bd = new DateTime(2000, 1, 1);
            Assert.Equal(@"Year: 19  Month: 02  Day: 01 ", td.Vozrast(bd));
        }

        [Fact]
        public void Test_data_1980_05_15()
        {
            DateTime bd = new DateTime(1980, 5, 15);
            Assert.Equal(@"Year: 38  Month: 09  Day: 17 ", td.Vozrast(bd));
        }

        [Fact]
        public void Test_data_1919_08_16()
        {
            DateTime bd = new DateTime(1919, 8, 16);
            Assert.Equal(@"Year: 99  Month: 06  Day: 16 ", td.Vozrast(bd));
        }
    }
}
