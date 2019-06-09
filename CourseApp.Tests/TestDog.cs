using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestDog
    {
        [Fact]
        public void Test_ProverkaBezZnachenij()
        {
           Dog snech = new Dog();

            Assert.Equal(15, snech.Age);
            Assert.Equal(50.0f, snech.Weight);
            Assert.Equal("K", snech.Pol);
        }

        [Fact]
        public void Test_ProverkaPolaGirl()
        {
            Dog snech = new Dog("S");
            Assert.Equal(12, snech.Age);
            Assert.Equal(45.0f, snech.Weight);
        }

        [Fact]
        public void Test_ProverkaPolaBoy()
        {
            Dog snech = new Dog("K");
            Assert.Equal(14, snech.Age);
            Assert.Equal(50.0f, snech.Weight);
        }

        [Fact]
        public void Test_ProverkaMetodaPicture()
        {
            Dog snech = new Dog();
            Assert.Equal(
                @" __ _ 
o'')}____// 
`_/ ) 
(_(_/-(_/", snech.Picture());
        }

        [Fact]
        public void Test_ProverkaMetodaGolos()
        {
            Dog snech = new Dog();
            Assert.Equal($"собака возраста {15} подала голос гав-гав ", snech.Golos());
        }

        [Fact]
        public void Test_ProverkaMetodaToString()
        {
            Dog snech = new Dog();
            Assert.Equal("собака возраста 15 и полом K", snech.ToString());
        }
    }
}