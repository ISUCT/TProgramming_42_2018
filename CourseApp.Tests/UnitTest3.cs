using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest3
    {
        [Fact]
        public void Test12()
        {
            Kater carter = new Kater();
            var resPicture = carter.Picture();
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
", resPicture);
        }

        [Fact]
        public void Test13()
        {
            Kater carter = new Kater();
            var passangers = carter.Passangers;
            var dlina = carter.Dlina;
            var vodoizmeschenie = carter.Vodoizmeschenie;
            Assert.Equal(5, passangers);
            Assert.Equal(10, dlina);
            Assert.Equal(15, vodoizmeschenie);
        }

        [Fact]
        public void Test14()
        {
            Kater carter = new Kater();
            var resPredlojenie = carter.Predlojenie();
            var dlina = carter.Dlina;
            Assert.Equal($"Катер с длиной {dlina} метров поплыл вдоль реки", resPredlojenie);
        }
    }
}