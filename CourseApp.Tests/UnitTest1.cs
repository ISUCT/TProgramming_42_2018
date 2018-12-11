using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        private double xn = 3.2;
        private double xk = 6.2;
        private double dx = 0.6;
        private double[] z = new double[5] { 4.48, 3.56, 2.78, 5.28, 3.21 };

        [Fact]
        public void Test1()
        {
            var res = Program.Formula(0.0, 0.4, 0.8);
            Assert.Equal(0.0, res);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.Formula(xn, 0.0, 0.8);
            Assert.Equal(0.0, res);
        }

        [Fact]
        public void Test3()
        {
            var res = Program.Formula(xn, 0.4, 0.0);
            Assert.Equal(0.0, res);
        }

        [Fact]
        public void Test4()
        {
            int i = 0;
            double[] e = new double[6] { 1.450, 1.321, 1.186, 1.055, 0.932, 0.821 };
            for (double x = xn; x <= xk; x += dx)
            {
                var res = Program.Formula(x, 0.4, 0.8);
                Assert.Equal(e[i], res, 3);
                i++;
            }
        }

        [Fact]
        public void Test5()
        {
            double[] e = new double[5] { 1.168, 1.374, 1.526, 0.996, 1.448 };
            for (int i = 0; i <= z.Length - 1; i++)
            {
                var res = Program.Formula(z[i], 0.4, 0.8);
                Assert.Equal(e[i], res, 3);
            }
        }
    }
}
