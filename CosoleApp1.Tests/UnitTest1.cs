using System;
using Xunit;
using ConsoleApp1;

namespace CosoleApp1.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            var res = Program.formula(0.0, 0.4, 0.8);
            Assert.Equal(double.NaN, res);
        }
    }
}
