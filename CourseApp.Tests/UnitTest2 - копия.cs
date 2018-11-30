using System;
using Xunit;
using CourseApp;


namespace CourseApp.Tests
{
    public class UnitTest2
    {
        //тесты проверки программы Pig
        [Fact]
        public void Test15()
        {
            Pig svin = new Pig();
            var res_age = svin.Age;
            var res_salo = svin.Salo;
            var res_pol = svin.Pol;
            Assert.Equal(20, res_age);
            Assert.Equal(70.0f, res_salo);
            Assert.Equal("M", res_pol);
        }
        [Fact]
        public void Test16()
        {
            Pig svin = new Pig("M");
            var res_age = svin.Age;
            var res_salo = svin.Salo;
            Assert.Equal(20, res_age);
            Assert.Equal(70.0f, res_salo);

        }
        [Fact]
        public void Test17()
        {
            Pig svin = new Pig("F");
            var res_age = svin.Age;
            var res_salo = svin.Salo;
            Assert.Equal(15, res_age);
            Assert.Equal(45.0f, res_salo);

        }
        [Fact]
        public void Test18()
        {
            Pig svin = new Pig(57.5f);
            var res_age = svin.Age;
            var res_pol = svin.Pol;
            Assert.Equal(20, res_age);
            Assert.Equal("M", res_pol);
        }
        [Fact]
        public void Test19()
        {
            Pig svin = new Pig(37.5f);
            var res_age = svin.Age;
            var res_pol = svin.Pol;
            Assert.Equal(15, res_age);
            Assert.Equal("F", res_pol);
        }
        [Fact]
        public void Test20()
        {
            Pig svin = new Pig(17);
            var res_salo = svin.Salo;
            var res_pol = svin.Pol;
            Assert.Equal(65.0f, res_salo);
            Assert.Equal("M", res_pol);
        }
        [Fact]
        public void Test21()
        {
            Pig svin = new Pig(8);
            var res_salo = svin.Salo;
            var res_pol = svin.Pol;
            Assert.Equal(45.0f, res_salo);
            Assert.Equal("F", res_pol);
        }
        [Fact]
        public void Test22()
        {
            Pig svin = new Pig();
            var res_ris = svin.ris();
            Assert.Equal(@"     _
         <`--'\>______
         /. .  `'     \
        (`')  ,        @
         `-._,        /
            )-)_/--( >  
           ''''  ''''", res_ris);
          
        }
        [Fact]
        public void Test23()
        {
            Pig svin = new Pig();
            var res_graz = svin.graz();
            Assert.Equal($"свинья возраста {20} пошла поваляться в грязи  ", res_graz);

        }
    }
}
