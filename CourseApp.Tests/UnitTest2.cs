using System;
using Xunit;
using Menu;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            Dish salad = new Dish("Cesar", 500, "Salad", 250);
            Assert.Equal("Cesar", salad.Name);
            Assert.Equal(500, salad.Price);
            Assert.Equal("Salad", salad.Type);
            Assert.Equal(250, salad.Weight);
        }

        [Fact]
        public void Test2()
        {
            Dish soup = new Dish("chees", 250);
            Assert.Equal("chees", soup.Name);
            Assert.Equal(250, soup.Price);
        }

        [Fact]
        public void Test3()
        {
            Dish soup = new Dish("chees", -3);
            Assert.Equal("chees", soup.Name);
            Assert.Equal(0, soup.Price);
        }

        [Fact]
        public void Test4()
        {
            Dish soup = new Dish("Cesar", 20);
            Assert.Equal("Cesar", soup.Name);
            Assert.Equal(20, soup.Price);
        }

        [Fact]
        public void Test5()
        {
            Dish salad = new Dish("Paprica", 500, "Salad", -3);
            Assert.Equal("Paprica", salad.Name);
            Assert.Equal(500, salad.Price);
            Assert.Equal("Salad", salad.Type);
            Assert.Equal(0, salad.Weight);
        }

        [Fact]
        public void Test6()
        {
            Dish salad = new Dish("Cesar", -100, "rrrrrrrrr", 1000);
            Assert.Equal("Cesar", salad.Name);
            Assert.Equal(0, salad.Price);
            Assert.Equal("NoType", salad.Type);
            Assert.Equal(1000, salad.Weight);
        }
    }
}