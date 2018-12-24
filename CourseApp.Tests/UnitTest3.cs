using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test19()
        {
            Refrigerator rg = new Refrigerator();
            Assert.Equal(3, rg.Temperature);
            Assert.Equal(1, rg.Model);
            Assert.Equal(5, rg.Age);
        }

        [Fact]
        public void Test20()
        {
            Refrigerator rg = new Refrigerator(7);
            Assert.Equal(7, rg.Temperature);
            Assert.Equal(1, rg.Model);
            Assert.Equal(7, rg.Age);
        }

        [Fact]
        public void Test21()
        {
            Refrigerator rg = new Refrigerator(2, 1, 8);
            Assert.Equal(2, rg.Temperature);
            Assert.Equal(1, rg.Model);
            Assert.Equal(8, rg.Age);
        }

        [Fact]
        public void Test22()
        {
            Refrigerator rg = new Refrigerator(6, 1, 4);
            Assert.Equal("\nХолодильник включён", rg.Status());
            Assert.Equal($"Температура в холодильнике: +{rg.Temperature}, Модель холодильника {rg.Model}, Возраст холодильника: {rg.Age}. ", rg.ToString());
        }
    }
}
