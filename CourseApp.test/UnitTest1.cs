using System;
using Xunit;
using CourseApp;

namespace CourseApp.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.Func(0.0, 0.0, 0.0);
            Assert.Equal(0.0, res, 3);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.Func(0.0, 2.5,4.6);
            Assert.Equal(5.589, res, 3);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.Func(10.1, 2.5, 4.6);
            Assert.Equal(21815.62, res, 3);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.Func(5.6, 2.5, 4.6);
            Assert.Equal(4603.76, res, 3);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.Func(6.0, 2.5, 4.6);
            Assert.Equal(5501.345, res, 3);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.Func(3.4, 2.5, 4.6);
            Assert.Equal(1321.403, res, 3);
        }
        [Fact]
        public void Test7()
        {
            var res = Program.Func(5.5, 2.5, 4.6);
            Assert.Equal(4395.368, res, 3);
        }
        [Fact]
        public void Test8()
        {
            var res = Program.Func(8.8, 2.5, 4.6);
            Assert.Equal(15075.594, res, 3);
        }
        [Fact]
        public void Test9()
        {
            var res = Program.Func(1.2, 2.5, 4.6);
            Assert.Equal(135.452, res, 3);
        }
        [Fact]
        public void Test10()
        {
            var res = Program.Func(5.0, 2.5, 4.6);
            Assert.Equal(3445.065, res, 3);
        }
    }

}
