using System;
using Xunit;

using ConsoleApp1;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test10()
        {
            Island ost = new Island();
            var name = ost.Name;
            var people = ost.People;
            var square = ost.Square;
            Assert.Equal("Неизвестная земля", name);
            Assert.Equal(24140800, people);
            Assert.Equal(7692024, square);
        }

        [Fact]
        public void Test11()
        {
            Island ost1 = new Island(56000, 43000, "Новая Зеландия");
            var name = ost1.Name;
            var people = ost1.People;
            var square = ost1.Square;
            Assert.Equal("Новая Зеландия", name);
            Assert.Equal(56000, people);
            Assert.Equal(43000, square);
        }

        [Fact]
        public void Test12()
        {
            Island ost = new Island();
            var people = ost.People;
            ost.People = -1;
            Assert.Equal(24140800, people);
        }

        [Fact]
        public void Test13()
        {
            Island ost = new Island();
            var square = ost.Square;
            ost.Square = -1;
            Assert.Equal(7692024, square);
        }
    }
}
