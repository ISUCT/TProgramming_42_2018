using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test15()
        {
            Ship admiral = new Ship();
            Kater carter = new Kater();
            var resPredlojenie = admiral.Predlojenie();
            var dlina = admiral.Dlina;
            var resPredlojenies = carter.Predlojenie();
            var dlinas = carter.Dlina;
            Assert.Equal($"Катер с длиной {dlinas} метров поплыл вдоль реки", resPredlojenies);
            Assert.Equal($"Корабль с длиной {dlina} метров вышел в открытое море", resPredlojenie);
        }
    }
}