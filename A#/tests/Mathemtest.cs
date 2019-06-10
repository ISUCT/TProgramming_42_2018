using System;
using Xunit;
using ASharp;

namespace ASharpTests
{
    public class MathemTest
    {
        [Fact]
        public void More()
        {
            string n1 = "1";
            string n2 = "0";
            Assert.True(Mathem.More(n1, n2));
        }
        [Fact]
        public void Less()
        {
            string n1 = "0";
            string n2 = "1";
            Assert.True( Mathem.Less(n1, n2));
        }
        [Fact]
        public void Equally()
        {
            string n1 = "1";
            string n2 = "1";
            Assert.True(Mathem.Equally(n1, n2));
        }
        [Fact]
        public void MoreOrEqually()
        {
            string n1 = "1";
            string n2 = "0";
            Assert.True(Mathem.MoreOrEqually(n1, n2));
        }
        [Fact]
        public void LessOrEqually()
        {
            string n1 = "0";
            string n2 = "1";
            Assert.True(Mathem.LessOrEqually(n1, n2));
        }
        [Fact]
        public void NotEqually()
        {
            string n1 = "1";
            string n2 = "0";
            Assert.True(Mathem.NotEqually(n1, n2));
        }
        [Fact]
        public void Sum()
        {
            string n1 = "2";
            string n2 = "3";
            Assert.Equal("5", Mathem.Sum(n1,n2));
        }
        [Fact]
        public void Min()
        {
            string n1 = "2";
            string n2 = "3";
            Assert.Equal("-1", Mathem.Min(n1,n2));
        }
        [Fact]
        public void Multiply()
        {
            string n1 = "2";
            string n2 = "3";
            Assert.Equal("6", Mathem.Multiply(n1, n2));
        }
        [Fact]
        public void Divide()
        {
            string n1 = "4";
            string n2 = "2";
            Assert.Equal("2", Mathem.Divide(n1, n2));
        }
        [Fact]
        public void Power()
        {
            string n1 = "2";
            string n2 = "3";
            Assert.Equal("8", Mathem.Power(n1, n2));
        }
        [Fact]
        public void Mod()
        {
            string n1 = "5";
            string n2 = "3";
            Assert.Equal("2", Mathem.Mod(n1, n2));
        }
        [Fact]
        public void InDigitTest()
        {
            Assert.Equal(5, Mathem.InDigit("testName"));
        }
        [Fact]
        public void InDigitTestError()
        {
            Assert.Equal(5, Mathem.InDigit("5"));
        }
    }
}
