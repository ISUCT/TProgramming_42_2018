using System;
using Xunit;
using Zadanie1;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test15()
        {
            Gun[] arsenals = new Gun[2];
            arsenals[0] = new Pistol();
            arsenals[1] = new Rifles();
            Assert.Equal("Colt", arsenals[0].Name);
            Assert.Equal(7, arsenals[0].Emkostmag);
            Assert.Equal("M16", arsenals[1].Name);
            Assert.Equal(30, arsenals[1].Emkostmag);
        }
        [Fact]
        public void Test16()
        {
            Gun[] arsenals = new Gun[2];
            arsenals[0] = new Pistol("name",2,3);
            arsenals[1] = new Rifles("name",2,3);
            Assert.Equal(7, arsenals[0].Emkostmag);
            Assert.Equal(2, arsenals[0].Kalibr);
            Assert.Equal(30, arsenals[1].Emkostmag);
            Assert.Equal(2, arsenals[1].Kalibr);
        }
    }
}