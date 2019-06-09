using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class TestFunction
    {
        [Fact]
        public void TestWith0()
        {
            var res = Program.Prgrm(0.0, 0.0f, 0.0f);
            Assert.Equal(double.NaN, res, 3);
        }

        [Fact]
        public void Test_SecondConst2()
        {
            var res = Program.Prgrm(0.0, 0.0f, 2.0f);
            Assert.Equal(double.NaN, res, 3);
        }

        [Fact]
        public void Test_Xraven1_FirstConst2()
        {
            var res = Program.Prgrm(1.0, 2.0f, 0.0f);
            Assert.Equal(-0.898, res, 3);
        }

        [Fact]
        public void Test_Xraven2()
        {
            var res = Program.Prgrm(2.0, 0.0f, 0.0f);
            Assert.Equal(double.NaN, res, 3);
        }

        [Fact]
        public void Test_SecondConstPoltora()
        {
            var res = Program.Prgrm(0.0, 0.0f, 1.5f);
            Assert.Equal(double.NaN, res, 3);
        }
    }
}