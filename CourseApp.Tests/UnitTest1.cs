using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        double xn = 0.1;
        double xk = 0.36;
        double dx = 0.05;
        double[] Xm = new double[5] { 0.2, 0.3, 0.38, 0.43, 0.57 };

        [Fact]
        public void Test1()
        {
            var res = Program.Func(0.0, 0.8f, 0.4f);
            Assert.Equal(Double.NaN, res, 3);

        }
    }
}