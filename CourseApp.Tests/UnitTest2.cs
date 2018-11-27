using System;
using Xunit;
using Zadanie1;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test12()
        {
            Pistol Colt = new Pistol();
            var name = Colt.name;
            var kalibr = Colt.kalibr;
            var emkostmag = Colt.emkostmag;
            var mass = Colt.mass;
            Assert.Equal("Colt", name);
            Assert.Equal(0.45, kalibr);
            Assert.Equal(7, emkostmag);
            Assert.Equal(1.4f, mass);
           
        }


    }
}
