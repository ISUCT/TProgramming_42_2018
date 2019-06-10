using System;
using Xunit;
using ASharp;
using System.Collections.Generic;

namespace ASharpTests
{
    public class VariablesTest
    {
        [Fact]
        public void TestOfPrinting1()
        {
            Assert.Equal("testName = 5", Variables.Print("testName"));
        }
        [Fact]
        public void TestOfPrinting2()
        {
            Assert.Equal("testName2 - 404 not found", Variables.Print("testName2"));
        }
        [Fact]
        public void SearchTest()
        {
            Assert.Equal(5, Variables.Search("testName"));
        }
        [Fact]
        public void SearchTestError()
        {
            Assert.Equal(0, Variables.Search("testNameError"));
        }
    }
}