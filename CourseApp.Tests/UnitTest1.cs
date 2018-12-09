using System;
using Xunit;
using exercise1;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        double xn = 1.2;
        double xk = 2.2;
        double dx = 0.2;
        double[] z = new double[5] { 1.21, 1.76, 2.53, 3.48, 4.52 };

        [Fact]
        public void Test1()
        {
            var res = exercise1.MyProgram.formula(0.0, 0.4, 0.8);
            Assert.Equal(double.NaN, res,3);
        }

        [Fact]
        public void Test2()
        {
            var res = exercise1.MyProgram.formula(xn, 0.0, 0.8);
            Assert.Equal(double.NaN, res,3);
        }

        [Fact]
        public void Test3()
        {
            var res = exercise1.MyProgram.formula(xn, 0.4, 0.0);
            Assert.Equal(1.04, res,3);
        }

    }
}
