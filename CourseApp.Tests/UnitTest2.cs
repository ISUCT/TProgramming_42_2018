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
            var name = Colt.Name;
            var kalibr = Colt.Kalibr;
            var emkostmag = Colt.Emkostmag;
            var mass = Colt.Mass;
            Assert.Equal("Colt", name);
            Assert.Equal(0.45, kalibr);
            Assert.Equal(7, emkostmag);
            Assert.Equal(1.4f, mass);
           
        }
        [Fact]
        public void Test13()
        {
            Pistol Colt = new Pistol();
            string pistol = Colt.Display();
            Assert.Equal(@"

      +-'~`---------------------------------/\--
 ||"""""""""""""""""""""""""""""""" \\\\\\  \/~)
 ||                                  \\\\\\  \/_
  |~~~~~~~~-________________-_________________\ ~--_
  !---------|_________       ------~~~~~(--   )--~~
                      \ /~~~~\~~\   )--- \_ /(
                       ||     |  | \   ()   \\
                       \\____/_ / ()\        \\
                        `~~~~~~~~~-. \        \\
                                    \ \  <($)> \\
                                     \ \        \\
                                      \ \        \\
                                       \ \        \\
                                        \ \  ()    \|
                                        _\_\__====~~~
       

", pistol);
        }
        [Fact]
        public void Test14()
        {
            Pistol Colt = new Pistol();
            var name = Colt.Name;
            var kalibr = Colt.Kalibr;
            var mass = Colt.Mass;
            var emkostmag = Colt.Emkostmag;
            Assert.Equal("Colt", name);
            string Pistol = Colt.GetInfo();
            Assert.Equal($"Наименование: {name}  Калибр: {kalibr} Масса: {mass} Емкость магазина: {emkostmag}\n Пистолет {name} выстрелил: \"Бах!\"", Pistol);
        }

    }
}
