using System;
using Xunit;
using ASharp;
using System.Collections.Generic;

namespace ASharpTests
{
    public class ProgramTest
    {
        [Fact]
        public void LinesToStringTest()
        {
            string[] str = new string[3] {"123","456","789"};
            Assert.Equal("  123 456 789", Program.LinesToString(str));
        }
        [Fact]
        public void RemovingTest()
        {
            string str = "   123          456 789      ";
            Assert.Equal(" 123 456 789 ", Program.Removing(str));
        }
    }
}