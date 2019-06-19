using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class TestofKater
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
            Assert.Equal("Carter", carter.Name);
            Assert.Equal(10, carter.Dlina);
            Assert.Equal(50, carter.Maxspeed);
        }

        [Fact]
        public void Testofpredlojeniya()
        {
            Kater carter = new Kater();
            Assert.Equal($"Катер {carter.Name} поплыл вдоль реки", carter.Predlojenie());
        }

        [Fact]
        public void CarterISwim()
        {
            Kater carter = new Kater();
            string iswim = carter.Swim(carter);
            Assert.Equal($"{carter.Name} плывет по течению", iswim);
        }
    }
}