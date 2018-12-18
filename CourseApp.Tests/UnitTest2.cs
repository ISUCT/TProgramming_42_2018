using System;
using Xunit;

using ConsoleApp1;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test7()
        {
            Country country1 = new Country();
            var people = country1.People;
            var square = country1.Square;
            var name = country1.Name;

            Assert.Equal(24140800, people);
            Assert.Equal(7692024, square);
            Assert.Equal("Australiya", name);
        }

        [Fact]
        public void Test8()
        {
            Country country2 = new Country(30316, 12.6);
            var people = country2.People;
            var square = country2.Square;
            var name = country2.Name;

            Assert.Equal(30316, people);
            Assert.Equal(12.6, square);
            Assert.Equal("Kohma", name);
        }

        [Fact]
        public void Test9()
        {
            Country country2 = new Country();
            var name = country2.Name;
            Assert.Equal("Australiya", name);
            string word = $"Strana {name} skasala: \'Dhou!\', a mne nado pomenyat dillera";
            Assert.Equal($"Strana Australiya skasala: \'Dhou!\', a mne nado pomenyat dillera", word);
        }
    }
}
