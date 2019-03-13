using System;
using Xunit;
using CourseApp;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        // тесты проверки программы Pig
        [Fact]
        public void Test15()
        {
            Pig svin = new Pig();
            var resAge = svin.Age;
            var resSalo = svin.Salo;
            var resPol = svin.Pol;
            Assert.Equal(20, resAge);
            Assert.Equal(70.0f, resSalo);
            Assert.Equal("M", resPol);
        }

        [Fact]
        public void Test16()
        {
            Pig svin = new Pig("M");
            var resAge = svin.Age;
            var resSalo = svin.Salo;
            Assert.Equal(20, resAge);
            Assert.Equal(70.0f, resSalo);
        }

        [Fact]
        public void Test17()
        {
            Pig svin = new Pig("F");
            var resAge = svin.Age;
            var resSalo = svin.Salo;
            Assert.Equal(15, resAge);
            Assert.Equal(45.0f, resSalo);
        }

        [Fact]
        public void Test18()
        {
            Pig svin = new Pig(57.5f);
            var resAge = svin.Age;
            var resPol = svin.Pol;
            Assert.Equal(20, resAge);
            Assert.Equal("M", resPol);
        }

        [Fact]
        public void Test19()
        {
            Pig svin = new Pig(37.5f);
            var resAge = svin.Age;
            var resPol = svin.Pol;
            Assert.Equal(15, resAge);
            Assert.Equal("F", resPol);
        }

        [Fact]
        public void Test20()
        {
            Pig svin = new Pig(17);
            var resSalo = svin.Salo;
            var resPol = svin.Pol;
            Assert.Equal(65.0f, resSalo);
            Assert.Equal("M", resPol);
        }

        [Fact]
        public void Test21()
        {
            Pig svin = new Pig(8);
            var resSalo = svin.Salo;
            var resPol = svin.Pol;
            Assert.Equal(45.0f, resSalo);
            Assert.Equal("F", resPol);
        }

        [Fact]
        public void Test22()
        {
            Pig svin = new Pig();
            var resRis = svin.Ris();
            Assert.Equal(
                @"     _
         <`--'\>______
         /. .  `'     \
        (`')  ,        @
         `-._,        /
            )-)_/--( >  
           ''''  ''''", resRis);
        }

        [Fact]
        public void Test23()
        {
            Pig svin = new Pig();
            var resGraz = svin.Graz();
            Assert.Equal($"pig age 20 went to lie in the mud ", resGraz);
        }

        [Fact]
        public void Test24()
        {
            Pig svin = new Pig();
            Assert.Equal("it's a Pig of the age of 20 and weighing 70", svin.ToString());
        }
    }
}
