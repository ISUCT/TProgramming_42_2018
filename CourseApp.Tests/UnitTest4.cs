using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void ArrayTesting1()
        {
            Appliances[] appliances = new Appliances[2];
            appliances[0] = new Television();
            appliances[1] = new Refrigerator();
            foreach (Appliances i in appliances)
            {
                Assert.Equal(1, i.Model);
                Assert.Equal(5, i.Age);
            }
        }

        [Fact]
        public void ArrayTesting2()
        {
            Appliances[] appliances = new Appliances[2];
            appliances[0] = new Television(132);
            appliances[1] = new Refrigerator(3);
            Assert.Equal(1, appliances[0].Model);
            Assert.Equal(3, appliances[0].Age);
            Assert.Equal(2, appliances[1].Model);
            Assert.Equal(5, appliances[1].Age);
        }
    }
}
