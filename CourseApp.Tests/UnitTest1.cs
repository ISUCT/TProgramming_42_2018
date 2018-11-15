using System;
using Xunit;
using CourseApp;
using ConsoleApp4;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        float xn = 1.23f;//� ���������
        float xk = 7.23f;//� ��������
        float dx = 1.2f;//���
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
            double[] p = new double[6] { 2.237,2.216,2.527,2.785,3.008,3.205 };//������ ������� 
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
            double[] p = new double[6] { 2.176, 2.502, 2.77, 2.997, 3.197, 3.378 };//������ ������� ��� a=0
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
            double[] p = new double[6] { 1.637, 2.145, 2.488, 2.759, 2.988, 3.189 };//������ ������� ��� b=0
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
            double[] p = new double[6] { 2.092, 2.464, 2.745, 2.979, 3.183, 3.366 };//������ ������� ��� a=0 � b=0
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
            double[] q = new double[5] { 2.056, 2.167, 2.575, 2.729,3.039 };//������ �������
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
            double[] q = new double[5] { 2.361, 2.46, 2.812, 2.947, 3.225 };//������ ������� ��� a=0
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
            double[] q = new double[5] { 1.944, 2.087, 2.539, 2.7, 3.02 };//������ ������� ��� b=0
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
            double[] q = new double[5] { 2.31, 2.419, 2.789, 2.928, 3.212 };//������ ������� ��� a=0 � b=0
            for (int i = 0; i < Xm.Length; i++)
            {
                var res = Program.Func(Xm[i], 0.0f, 0.0f);
                Assert.Equal(q[j], res, 3);
                j++;
            }
        }
        //����� �������� ��������� Pig
        [Fact]
        public void Test15()
        {
            Pig svin = new Pig();
            var res_age = svin.age;
            var res_salo = svin.salo;
            var res_pol = svin.pol;
            Assert.Equal(20, res_age);
            Assert.Equal(70.0f, res_salo);
            Assert.Equal("M", res_pol);
        }
        [Fact]
        public void Test16()
        {
            Pig svin = new Pig("M");
            var res_age = svin.age;
            var res_salo = svin.salo;
            Assert.Equal(20, res_age);
            Assert.Equal(70.0f, res_salo);
          
        }
        [Fact]
        public void Test17()
        {
            Pig svin = new Pig("F");
            var res_age = svin.age;
            var res_salo = svin.salo;
            Assert.Equal(15, res_age);
            Assert.Equal(45.0f, res_salo);
           
        }
        [Fact]
        public void Test18()
        {
            Pig svin = new Pig(57.5f);
            var res_age = svin.age;
            var res_pol = svin.pol;
            Assert.Equal(20, res_age);
            Assert.Equal("M", res_pol);
        }
        [Fact]
        public void Test19()
        {
            Pig svin = new Pig(37.5f);
            var res_age = svin.age;
            var res_pol = svin.pol;
            Assert.Equal(15, res_age);
            Assert.Equal("F", res_pol);
        }
        [Fact]
        public void Test20()
        {
            Pig svin = new Pig(17);
            var res_salo = svin.salo;
            var res_pol = svin.pol;
            Assert.Equal(65.0f, res_salo);
            Assert.Equal("M", res_pol);
        }
        [Fact]
        public void Test21()
        {
            Pig svin = new Pig(8);
            var res_salo = svin.salo;
            var res_pol = svin.pol;
            Assert.Equal(45.0f, res_salo);
            Assert.Equal("F", res_pol);
        }
    }
}
