using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest
    {
        double[] z = new double[] { 0.35, 1.28, 3.51, 5.21, 4.16 };

        [Fact]
        public void Test1()
        {
            var result = Program.Formula(0.0, 1.35, 0.98);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test2()
        {
            var result = Program.Formula(1.14, 0.0, 0.98);
            Assert.Equal(308.817, result,3);
        }

    }
}