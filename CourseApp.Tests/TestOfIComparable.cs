using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestOfIComparable
    {
        [Fact]
        public void TestName()
        {
            string comparable = @"Бегемот - 7
Рыжик - 6
Том - 6";
            Cat tom = new Cat();
            Cat red = new Cat("Рыжик", 6);
            Cat begemot = new Cat("Бегемот", "черный");
            Cat[] arrayOfCat = new Cat[] {tom, red, begemot };
            Assert.Equal(
                @"Бегемот - 7
Рыжик - 6
Том - 6", comparable);
        }
    }
}