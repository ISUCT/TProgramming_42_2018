using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test8()
        {
            Skateboarder one = new Skateboarder();
            var name = one.Name;
            var surname = one.Surname;
            var title = one.Title;
            var age = one.Age;
            var height = one.Height;
            var weight = one.Weight;
            var stance = one.Stance;
            Assert.Equal("John", name);
            Assert.Equal("Smith", surname);
            Assert.Equal("Mr.", title);
            Assert.Equal(30, age);
            Assert.Equal(120, height);
            Assert.Equal(120, weight);
            Assert.Equal("goofy", stance);
        }

        [Fact]
        public void Test9()
        {
            Skateboarder two = new Skateboarder("Борис", "Годунов", 466, "regular");
            var name = two.Name;
            var surname = two.Surname;
            var title = two.Title;
            var age = two.Age;
            var height = two.Height;
            var weight = two.Weight;
            var stance = two.Stance;
            Assert.Equal("Борис", name);
            Assert.Equal("Годунов", surname);
            Assert.Equal("Mr.", title);
            Assert.Equal(466, age);
            Assert.Equal(150, height);
            Assert.Equal(55, weight);
            Assert.Equal("regular", stance);
        }

        [Fact]
        public void Test10()
        {
            Skateboarder three = new Skateboarder("Лазарь", "Водянец", "Господин", 56, 170, 75, "mongo-goofy");
            var name = three.Name;
            var surname = three.Surname;
            var title = three.Title;
            var age = three.Age;
            var height = three.Height;
            var weight = three.Weight;
            var stance = three.Stance;
            Assert.Equal("Лазарь", name);
            Assert.Equal("Водянец", surname);
            Assert.Equal("Господин", title);
            Assert.Equal(56, age);
            Assert.Equal(170, height);
            Assert.Equal(75, weight);
            Assert.Equal("mongo-goofy", stance);
        }

        [Fact]
        public void Test11()
        {
            Skateboarder one = new Skateboarder();
            var age = one.Age;
            one.Age = -1;
            Assert.Equal(30, age);
        }

        [Fact]
        public void Test12()
        {
            Skateboarder one = new Skateboarder();
            Assert.Equal("John Smith", one.ToString());

        }
    }
}
