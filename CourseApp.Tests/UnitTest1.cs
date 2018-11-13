using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        float xn = 1.23f;//х начальное
        float xk = 7.23f;//х конечное
        float dx = 1.2f;//шаг
        double[] Xm = new double[5] { 1.88, 2.26, 3.84, 4.55, 6.21 };

        [Fact]
        public void Test1()
        {
            var res = Program.Func(0.0,0.8f,0.4f);            
            Assert.Equal(Double.NaN, res,3);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.Func(1.0, 0.8f, 0.4f);
            Assert.Equal(Double.NaN, res, 3);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.Func(1.0, 0.0f, 0.4f);
            Assert.Equal(2.11, res, 3);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.Func(1.0, 0.8f, 0.0f);
            Assert.Equal(1.503, res, 3);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.Func(1.0, 0.0f, 0.0f);
            Assert.Equal(2, res, 3);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.Func(0.0, 0.0f, 0.0f);
            Assert.Equal(Double.NaN, res, 3);
        }
        [Fact]
        public void Test7()
        {
            int i = 0;
            double[] p = new double[6] { 2.237,2.216,2.527,2.785,3.008,3.205 };//вектор ответов 
            for (float x = xn; x <= xk; x += dx)
            {
                var res = Program.Func(x, 0.8f, 0.4f);         
                    Assert.Equal(p[i], res, 3);
                i++;
            }            
        }
        [Fact]
        public void Test8()
        {
            int i = 0;
            double[] p = new double[6] { 2.176, 2.502, 2.77, 2.997, 3.197, 3.378 };//вектор ответов при a=0
            for (float x = xn; x <= xk; x += dx)
            {
                var res = Program.Func(x, 0.0f, 0.4f);
                Assert.Equal(p[i], res, 3);
                i++;

            }
        }
        [Fact]
        public void Test9()
        {
            int i = 0;
            double[] p = new double[6] { 1.637, 2.145, 2.488, 2.759, 2.988, 3.189 };//вектор ответов при b=0
            for (float x = xn; x <= xk; x += dx)
            {
                var res = Program.Func(x, 0.8f, 0.0f);
                Assert.Equal(p[i], res, 3);
                i++;

            }
        }
        [Fact]
        public void Test10()
        {
            int i = 0;
            double[] p = new double[6] { 2.092, 2.464, 2.745, 2.979, 3.183, 3.366 };//вектор ответов при a=0 и b=0
            for (float x = xn; x <= xk; x += dx)
            {
                var res = Program.Func(x, 0.0f, 0.0f);
                Assert.Equal(p[i], res, 3);
                i++;

            }
        }
        [Fact]
        public void Test11()
        {
            int j = 0; 
            double[] q = new double[5] { 2.056, 2.167, 2.575, 2.729,3.039 };//вектор ответов
            for (int i = 0; i < Xm.Length; i++)
            {
                var res = Program.Func(Xm[i], 0.8f, 0.4f);
                Assert.Equal(q[j], res, 3);
                j++;
            }       
        }
        [Fact]
        public void Test12()
        {
            int j = 0;
            double[] q = new double[5] { 2.361, 2.46, 2.812, 2.947, 3.225 };//вектор ответов при a=0
            for (int i = 0; i < Xm.Length; i++)
            {
                var res = Program.Func(Xm[i], 0.0f, 0.4f);
                Assert.Equal(q[j], res, 3);
                j++;
            }
        }
        [Fact]
        public void Test13()
        {
            int j = 0;
            double[] q = new double[5] { 1.944, 2.087, 2.539, 2.7, 3.02 };//вектор ответов при b=0
            for (int i = 0; i < Xm.Length; i++)
            {
                var res = Program.Func(Xm[i], 0.8f, 0.0f);
                Assert.Equal(q[j], res, 3);
                j++;
            }
        }
        [Fact]
        public void Test14()
        {
            int j = 0;
            double[] q = new double[5] { 2.31, 2.419, 2.789, 2.928, 3.212 };//вектор ответов при a=0 и b=0
            for (int i = 0; i < Xm.Length; i++)
            {
                var res = Program.Func(Xm[i], 0.0f, 0.0f);
                Assert.Equal(q[j], res, 3);
                j++;
            }
        }

    }
}
