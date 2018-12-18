using System;
using Xunit;

using ConsoleApp1;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        private double x1 = 0.08;
        private double x2 = 1.08;
        private double dx = 0.2;
        private double[] z = new double[5] { 0.1, 0.3, 0.4, 0.45, 0.65 };

        [Fact]
        public void Test1()
        {
            double y = Program.Formula(0.1, 2.0, 1.1);
            Assert.Equal(0.138, y, 3);
        }

        [Fact]
        public void Test2()
        {
            double y = Program.Formula(0, 2.0, 1.1);
            Assert.Equal(0.144, y, 3);
        }

        [Fact]
        public void Test3()
        {
            double y = Program.Formula(0.1, 0, 1.1);
            Assert.Equal(-0.025, y, 3);
        }

        [Fact]
        public void Test4()
        {
            double y = Program.Formula(0.1, 2.0, 0);
            Assert.Equal(-3.492, y, 3);
        }

        [Fact]
        public void Test5()
        {
            double[] mas = new double[5] { 0.138, 0.086, 0.037, 0.006, -0.185 };
            for (int i = 0; i < mas.Length; i++)
            {
                var y = Program.Formula(z[i], 2.0, 1.1);
                Assert.Equal(mas[i], y, 3);
            }
        }

        [Fact]
        public void Test6()
        {
            int i = 0;
            double[] mas = new double[6] { 0.140, 0.094, -0.016, -0.226, -0.657, -2.544 };
            for (double j = x1; j <= x2; j += dx)
            {
                var y = Program.Formula(j, 2.0, 1.1);
                Assert.Equal(mas[i], y, 3);
                i++;
            }
        }
    }
}
