using Xunit;
using System;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest6
    {
        public Fox one = new Fox();

        [Fact]
        public void UnitTest20()
        {
            Assert.Equal("Лиса сделала КУСЬ!", one.Kus());
        }

        [Fact]
        public void UnitTest21()
        {
            Fox one = new Fox();
            Fox two = new Fox("Вторая", "Черная");
            Fox[] fox = new Fox[] { one, two };
            Array.Sort(fox);
            Assert.Equal(one.Name, fox[1].Name);
            Assert.Equal(one.Age, fox[1].Age);
            Assert.Equal(two.Name, fox[0].Name);
            Assert.Equal(two.Age, fox[0].Age);
        }
    }
}
