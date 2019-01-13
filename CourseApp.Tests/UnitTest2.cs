using Xunit;
using System;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test3()
        {
            Employee one = new Employee();
            var name = one.Name;
            var surname = one.Surname;
            var title = one.Title;
            var age = one.Age;
            var height = one.Height;
            var weight = one.Weight;
            var hireDateTime = one.HireDateTime;
            Assert.Equal("John", name);
            Assert.Equal("Smith", surname);
            Assert.Equal("Mr.", title);
            Assert.Equal(30, age);
            Assert.Equal(120, height);
            Assert.Equal(120, weight);
            Assert.Equal(new DateTime(2018, 9, 27, 0, 0, 0, 0), hireDateTime);
        }

        [Fact]
        public void Test4()
        {
            Employee two = new Employee("Борис", "Годунов", 466, new DateTime(2018, 9, 27, 0, 0, 0, 0));
            var name = two.Name;
            var surname = two.Surname;
            var title = two.Title;
            var age = two.Age;
            var height = two.Height;
            var weight = two.Weight;
            var hireDateTime = two.HireDateTime;
            Assert.Equal("Борис", name);
            Assert.Equal("Годунов", surname);
            Assert.Equal("Mr.", title);
            Assert.Equal(466, age);
            Assert.Equal(150, height);
            Assert.Equal(55, weight);
            Assert.Equal(new DateTime(2018, 9, 27, 0, 0, 0, 0), hireDateTime);
        }

        [Fact]
        public void Test5()
        {
            Employee three = new Employee("Лазарь", "Водянец", "Господин", 56, 170, 75, new DateTime(2018, 9, 27, 0, 0, 0, 0));
            var name = three.Name;
            var surname = three.Surname;
            var title = three.Title;
            var age = three.Age;
            var height = three.Height;
            var weight = three.Weight;
            var hireDateTime = three.HireDateTime;
            Assert.Equal("Лазарь", name);
            Assert.Equal("Водянец", surname);
            Assert.Equal("Господин", title);
            Assert.Equal(56, age);
            Assert.Equal(170, height);
            Assert.Equal(75, weight);
            Assert.Equal(new DateTime(2018, 9, 27, 0, 0, 0, 0), hireDateTime);
        }

        [Fact]
        public void Test6()
        {
            Employee one = new Employee();
            var age = one.Age;
            one.Age = -1;
            Assert.Equal(30, age);
        }

        [Fact]
        public void Test7()
        {
            Employee one = new Employee();
            Assert.Equal("Mr. Smith, John", one.ToString());

        }
    }
}
