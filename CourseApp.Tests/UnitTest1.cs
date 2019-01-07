using System;
using Xunit;
using Matan;

namespace CourseApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.Y(0, 0, 0);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.Y(1, 0, 0);
            Assert.Equal(double.NaN, res);
        }

        [Fact]
        public void Test3()
        {
            var res = Program.Y(1, 1, 0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void Test4()
        {
            var res = Program.Y(5, 1, -8);
            Assert.Equal(10.96, res, 2);
        }

        [Fact]
        public void Test5()
        {
            var res = Program.Y(2, 3, 0);
            Assert.Equal(10.49, res, 2);
        }

        [Fact]
        public void Test6()
        {
            var res = Program.Y(0, 4, -9);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test7()
        {
            var res = Program.Y(8, 2, 4);
            Assert.Equal(6.38, res, 2);
        }

        [Fact]
        public void Test9()
        {
            var res = Program.Y(0, 3, 2);
            Assert.Equal(0, res);
        }

        [Fact]
        public void Test10()
        {
            var res = Program.Y(0, 3, 3);
            Assert.Equal(0, res);
        }
    }
}
