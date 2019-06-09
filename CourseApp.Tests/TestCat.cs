using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestCat
    {
        [Fact]
        public void Test_ProverkaBezZnachenij()
        {
           Cat murka = new Cat();

            Assert.Equal(15, murka.Age);
            Assert.Equal(15.0f, murka.Weight);
            Assert.Equal("K", murka.Pol);
        }

        [Fact]
        public void Test_ProverkaPolaBoy()
        {
            Cat murka = new Cat("K");
            Assert.Equal(9, murka.Age);
            Assert.Equal(10.0f, murka.Weight);
        }

        [Fact]
        public void Test_ProverkaPolaGirl()
        {
            Cat murka = new Cat("Kisa");
            Assert.Equal(11, murka.Age);
            Assert.Equal(12.0f, murka.Weight);
        }

        [Fact]
        public void Test_ProverkaMetodaPicture()
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
        public void Test_ProverkaMetodaGolos()
        {
            Cat murka = new Cat();
            Assert.Equal($"кот возраста {15} подал голос мяу ", murka.Golos());
        }

        [Fact]
        public void Test_ProverkaMetodaToString()
        {
            Cat murka = new Cat();
            Assert.Equal("кот возраста 15 и полом K", murka.ToString());
        }
    }
}