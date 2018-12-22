using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        // тесты проверки программы Сow
        [Fact]
        public void Test25()
        {
            Cow murka = new Cow();
            Assert.Equal(15, murka.Age);
            Assert.Equal(70.0f, murka.Meat);
            Assert.Equal("M", murka.Pol);
        }

        [Fact]
        public void Test26()
        {
            Cow murka = new Cow("M");
            Assert.Equal(13, murka.Age );
            Assert.Equal(80.0f, murka.Meat);
        }

        [Fact]
        public void Test27()
        {
            Cow murka = new Cow("F");
            Assert.Equal(15, murka.Age);
            Assert.Equal(75.0f, murka.Meat);
        }

        [Fact]
        public void Test28()
        {
            Cow murka = new Cow(80.0f);
            Assert.Equal(13, murka.Age);
            Assert.Equal("M", murka.Pol);
        }

        [Fact]
        public void Test29()
        {
            Cow murka = new Cow(12);
            Assert.Equal(75.0f, murka.Meat);
            Assert.Equal("F", murka.Pol);
        }

        [Fact]
        public void Test30()
        {
            Cow murka = new Cow();
            Assert.Equal("это Корова возраста 15 и массой 70", murka.ToString() );
        }
    }
}
