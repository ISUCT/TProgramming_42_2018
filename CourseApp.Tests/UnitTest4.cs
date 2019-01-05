using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test18()
        {
            Pet[] pet = new Pet[2];
            pet[0] = new Dog();
            pet[1] = new Cat();
            foreach (Pet i in pet)
            {
                Assert.Equal(15, i.Age);
                Assert.Equal("K", i.Pol);
            }
        }
    }
}