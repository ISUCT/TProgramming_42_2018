using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test6()
        {
           Dog snech = new Dog();
            
            Assert.Equal(15, snech.Age);
            Assert.Equal(50.0f, snech.Weight);
            Assert.Equal("K", snech.Pol);
        }

        [Fact]
        public void Test7()
        {
            Dog snech = new Dog("S");
            Assert.Equal(12, snech.Age);
            Assert.Equal(45.0f, snech.Weight);
        }

        [Fact]
        public void Test8()
        {
            Dog snech = new Dog("K");
            Assert.Equal(14, snech.Age);
            Assert.Equal(50.0f, snech.Weight);
        }

        [Fact]
        public void Test9()
        {
            Dog snech = new Dog();
            Assert.Equal(
                @" __ _ 
o'')}____// 
`_/ ) 
(_(_/-(_/", snech.Picture());
        }

        [Fact]
        public void Test10()
        {
            Dog snech = new Dog();
            Assert.Equal($"������ �������� {15} ������ ����� ���-��� ", snech.Golos());
        }
    }
}