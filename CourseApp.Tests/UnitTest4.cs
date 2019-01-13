using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test13()
        {
            HumanBeing[] humanBeing = new HumanBeing[2];
            humanBeing[0] = new Employee();
            humanBeing[1] = new Skateboarder();
            Assert.Equal("Mr. Smith, John", humanBeing[0].ToString());
            Assert.Equal("John Smith", humanBeing[1].ToString());
        }

        [Fact]
        public void Test14()
        {
            HumanBeing[] humanBeing = new HumanBeing[2];
            humanBeing[0] = new Employee();
            humanBeing[1] = new Skateboarder();
            Assert.Equal("John", humanBeing[0].Name);
            Assert.Equal("Smith", humanBeing[0].Surname);
            Assert.Equal(30, humanBeing[0].Age);
            Assert.Equal("John", humanBeing[1].Name);
            Assert.Equal("Smith", humanBeing[1].Surname);
            Assert.Equal(30, humanBeing[1].Age);
        }

        [Fact]
        public void Test15()
        {
            HumanBeing[] humanBeing = new HumanBeing[2];
            humanBeing[0] = new Employee();
            humanBeing[1] = new Skateboarder();
            Assert.Equal("Hired 27 сентября 2018", humanBeing[0].GetHireDate());
            Assert.Equal("Skateboarders cannot be hired.", humanBeing[1].GetHireDate());
        }
    }
}