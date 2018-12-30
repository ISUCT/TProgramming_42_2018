using System;
using Xunit;
using Zadanie1;

namespace CourseApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.Formula(0.11);
            Assert.Equal(-2.17, res, 2);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.Formula(0.16);
            Assert.Equal(-1.77, res, 2);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.Formula(0.21);
            Assert.Equal(-1.47, res, 2);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.Formula(0.26);
            Assert.Equal(-1.24, res, 2);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.Formula(0.31);
            Assert.Equal(-1.04, res, 2);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.Formula(0.36);
            Assert.Equal(-0.88, res, 2);
        }
        [Fact]
        public void Test7()
        {
            var res = Program.Formula(0.2);
            Assert.Equal(-1.53, res, 2);
        }
        [Fact]
        public void Test8()
        {
            var res = Program.Formula(0.3);
            Assert.Equal(-1.08, res, 2);
        }
        [Fact]
        public void Test9()
        {
            var res = Program.Formula(0.38);
            Assert.Equal(-0.82, res, 2);
        }
        [Fact]
        public void Test10()
        {
            var res = Program.Formula(0.43);
            Assert.Equal(-0.69, res, 2);
        }
        [Fact]
        public void Test11()
        {
            var res = Program.Formula(0.57);
            Assert.Equal(-0.42, res, 2);
        }
    }
}