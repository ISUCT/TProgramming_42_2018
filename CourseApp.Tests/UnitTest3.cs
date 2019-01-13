using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void TestofPicture()
        {
            Kater carter = new Kater();
            Assert.Equal(
                @"

░░░░░░░░░░░░░█▀▀▀█████████▄▄▄░░░░░░░░░░░
░░░░░░░░░░░▄█▀░░░░░█▀░░░░░█▀░░░░░░░░░░░░
███████▄▄▄██▄▄▄▄░░░█░░░░░░█░░▀████▄▄▄▄▄▄
░▄░░░▀▀▀▀▀▀▀▀███████████████▄▄▄█▄▄▄█░░██
░▀█████████▄▄▄▄▄▄▄▄▄░░▀▀▀▀▀▀▀▀▀████████░
░░░▀█████████████████████████▄▄▄▄▄▄▄▄▄░░
░░░░░▀▀███████████████████████████████░░
░░░░░░░░░░░▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀░░░
", carter.Picture());
        }

        [Fact]
        public void Testofznacheniya()
        {
            Kater carter = new Kater();
            Assert.Equal(5, carter.Passangers);
            Assert.Equal(10, carter.Dlina);
            Assert.Equal(50, carter.Maxspeed);
        }

        [Fact]
        public void Testofpredlojeniya()
        {
            Kater carter = new Kater();
            Assert.Equal($"Катер с длиной {carter.Dlina} метров поплыл вдоль реки", carter.Predlojenie());
        }
    }
}