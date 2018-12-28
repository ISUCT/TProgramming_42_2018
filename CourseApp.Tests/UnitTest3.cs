using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void TestingTheFirstConstructorOfTheRefrigerator()
        {
            Refrigerator rg = new Refrigerator();
            Assert.Equal(3, rg.Temperature);
            Assert.Equal(1, rg.Model);
            Assert.Equal(5, rg.Age);
        }

        [Fact]
        public void TestingTheSecondConstructorOfTheRefrigerator()
        {
            Refrigerator rg = new Refrigerator(7);
            Assert.Equal(7, rg.Temperature);
            Assert.Equal(1, rg.Model);
            Assert.Equal(5, rg.Age);
        }

        [Fact]
        public void TestingTheThirdConstructorOfTheRefrigerator()
        {
            Refrigerator rg = new Refrigerator(2, 1, 8, true);
            Assert.Equal(2, rg.Temperature);
            Assert.Equal(1, rg.Model);
            Assert.Equal(8, rg.Age);
        }

        [Fact]
        public void TestingString()
        {
            Refrigerator rg = new Refrigerator(6, 1, 4, true);
            Assert.Equal($"Температура в холодильнике: +{rg.Temperature}, Модель холодильника {rg.Model}, Возраст холодильника: {rg.Age}. ", rg.ToString());
        }
    }
}
