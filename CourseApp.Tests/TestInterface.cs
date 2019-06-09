using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestInterface
    {
        private Dog sharik = new Dog();

        [Fact]
        public void TestStrokeDog()
        {
            Assert.Equal("stroke a dog", sharik.Stroke_dog());
        }

        [Fact]
        public void TestIComparable_0_S_S()
        {
            Dog snech = new Dog("S");
            Dog nura = new Dog("S");
            Dog[] dogs = new Dog[] { snech, sharik, nura };
            Array.Sort(dogs);
            Assert.Equal(nura.Weight, dogs[0].Weight);
            Assert.Equal(nura.Pol, dogs[0].Pol);
            Assert.Equal(snech.Weight, dogs[1].Weight);
            Assert.Equal(snech.Pol, dogs[1].Pol);
            Assert.Equal(sharik.Weight, dogs[2].Weight);
            Assert.Equal(sharik.Pol, dogs[2].Pol);
        }
    }
}