using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        // тесты проверки Cупер класса
        [Fact]
        public void Test31()
        {
            Animal[] animal = new Animal[2];
            animal[0] = new Pig();
            animal[1] = new Cow();
            foreach (Animal i in animal)
            {
                Assert.Equal(70.0f, i.Ves);
                Assert.Equal("M", i.Pol);
            }
        }

        [Fact]
        public void Test32()
        {
            Animal[] animal = new Animal[2];
            animal[0] = new Pig();
            animal[1] = new Cow();
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Assert.Equal(20, animal[i].Age);
                }
                else
                {
                    Assert.Equal(15, animal[i].Age);
                }
            }
        }
    }
}