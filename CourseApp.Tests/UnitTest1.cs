using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CourseApp;

namespace CourseApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.Func(0.0, 0.8, 0.4);
            Assert.Equal(0.283, res, 3);
        }

        [Fact]
        public void Test2()
        {
            var res = Program.Func(0.0, 1.1, 0.1);
            Assert.Equal(0.639, res, 3);
        }

        [Fact]
        public void Test3()
        {
            var res = Program.Func(0.1, 0.4, 0.3);
            Assert.Equal(0.063, res, 3);
        }

        [Fact]
        public void Test4()
        {
            var res = Program.Func(2.2, 1.8, 3.4);
            Assert.Equal(203.09, res, 3);
        }

        [Fact]
        public void Test5()
        {
            var res = Program.Func(0.09, 0.71, 0.2);
            Assert.Equal(0.224, res, 3);
        }

        [Fact]
        public void Test6()
        {
            var res = Program.Func(0.0, 0.01, 0.33);
            Assert.Equal(0.0, res, 3);
        }

        [Fact]
        public void Test7()
        {
            var res = Program.Func(0.9, 0.8, 0.7);
            Assert.Equal(1.266, res, 3);
        }

        [Fact]
        public void Test8()
        {
            var res = Program.Func(0.1, 0.2, 0.3);
            Assert.Equal(0.017, res, 3);
        }
    }
}