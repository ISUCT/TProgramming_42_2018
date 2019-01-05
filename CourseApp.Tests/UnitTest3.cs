using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test12()
        {
           Cat murka = new Cat();

            Assert.Equal(15, murka.Age);
            Assert.Equal(15.0f, murka.Weight);
            Assert.Equal("K", murka.Pol);
        }

        [Fact]
        public void Test13()
        {
            Cat murka = new Cat("K");
            Assert.Equal(9, murka.Age);
            Assert.Equal(10.0f, murka.Weight);
        }

        [Fact]
        public void Test14()
        {
            Cat murka = new Cat("Kisa");
            Assert.Equal(11, murka.Age);
            Assert.Equal(12.0f, murka.Weight);
        }

        [Fact]
        public void Test15()
        {
            Cat murka = new Cat();
            Assert.Equal(
                @" 
    /\___/\
   (  o o  )
   /   *   \
   \__\_/__/ meow!
     /   \
    / ___ \
    \/___\/", murka.Picture());
        }

        [Fact]
        public void Test16()
        {
            Cat murka = new Cat();
            Assert.Equal($"кот возраста {15} подал голос мяу ", murka.Golos());
        }

        [Fact]
        public void Test17()
        {
            Cat murka = new Cat();
            Assert.Equal("кот возраста 15 и полом K", murka.ToString());
        }
    }
}