using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestInterface
    {
        private Pig svin = new Pig();

        [Fact]
        public void TestMetodCut()
        {
            Assert.Equal("a pig slaughtered", svin.Cut());
        }

        [Fact]
        public void TestIComparable_0_15_9()
        {
            Pig alkash = new Pig(15);
            Pig pitochok = new Pig(9);
            Pig[] slaughterhouse = new Pig[] { svin, alkash, pitochok };
            Array.Sort(slaughterhouse);
            Assert.Equal(pitochok.Salo, slaughterhouse[0].Salo );
            Assert.Equal(pitochok.Age, slaughterhouse[0].Age);
            Assert.Equal(alkash.Salo, slaughterhouse[1].Salo);
            Assert.Equal(alkash.Age, slaughterhouse[1].Age);
            Assert.Equal(svin.Salo, slaughterhouse[2].Salo);
            Assert.Equal(svin.Age, slaughterhouse[2].Age);
        }

        [Fact]
        public void TestIComparable_0_5_20()
        {
            Pig alkash = new Pig(5);
            Pig pitochok = new Pig(20);
            Pig[] slaughterhouse = new Pig[] { svin, alkash, pitochok };
            Array.Sort(slaughterhouse);
            Assert.Equal(alkash.Salo, slaughterhouse[0].Salo);
            Assert.Equal(alkash.Age, slaughterhouse[0].Age);
            Assert.Equal(svin.Salo, slaughterhouse[1].Salo);
            Assert.Equal(svin.Age, slaughterhouse[1].Age);
            Assert.Equal(pitochok.Salo, slaughterhouse[2].Salo);
            Assert.Equal(pitochok.Age, slaughterhouse[2].Age);
        }
    }
}
