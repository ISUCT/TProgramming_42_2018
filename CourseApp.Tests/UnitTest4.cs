using System;
using Xunit;
using Zadanie1;

namespace CourseApp.Tests
{
    public class UnitTest4
    {
        [Fact]
        public void Test17()
        {
            Rifles m16 = new Rifles();
            var name = m16.Name;
            var kalibr = m16.Kalibr;
            var emkostmag = m16.Emkostmag;
            var mass = m16.Mass;
            Assert.Equal("M16", name);
            Assert.Equal(5.56, kalibr);
            Assert.Equal(30, emkostmag);
            Assert.Equal(2.4f, mass);
        }

        [Fact]
        public void Test18()
        {
            Rifles m16 = new Rifles();
            string rifles = m16.Display();
            Assert.Equal(
                @"

                           ______
        |\_______________ (_____\\______________
HH======#H###############H######################
        ' ~""""""""""""""`##(_))#H\""""Y########
                          ))    \#H\        Y###
                                 }#H)


", rifles);
        }

        [Fact]
        public void Test19()
        {
            Rifles m16 = new Rifles();
            var name = m16.Name;
            var kalibr = m16.Kalibr;
            var mass = m16.Mass;
            var emkostmag = m16.Emkostmag;
            Assert.Equal("M16", name);
            string rifles = m16.ToString();
            Assert.Equal($"Наименование: M16  калибр: 5,56 масса: 2,4 емкость магазина: 30\n Винтовка M16 Выстрелила: \"Бах!\"", rifles);
        }

        [Fact]
         public void Test20()
        {
            Pistol colt = new Pistol();
            string shooting = colt.Shoot(colt);
            Assert.Equal($" Я выстрелил из пистолета Colt ", shooting);
        }

        [Fact]
        public void Test21()
        {
            Rifles m16 = new Rifles();
            string shooting = m16.Shoot(m16);
            Assert.Equal($" Я выстрелил из винтовки M16 ", shooting);
        }
    }
}
