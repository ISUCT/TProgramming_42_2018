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
            Rifles M16 = new Rifles();
            var name = M16.Name;
            var kalibr = M16.Kalibr;
            var emkostmag = M16.Emkostmag;
            var mass = M16.Mass;
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
            Assert.Equal(@"

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
            Rifles M16 = new Rifles();
            var name = M16.Name;
            var kalibr = M16.Kalibr;
            var mass = M16.Mass;
            var emkostmag = M16.Emkostmag;
            Assert.Equal("M16", name);
            string rifles = M16.ToString();
            Assert.Equal($"Наименование: M16  калибр: 5,56 масса: 2,4 емкость магазина: 30\n Винтовка M16 Выстрелила: \"Бах!\"", rifles);
        }

    }
}